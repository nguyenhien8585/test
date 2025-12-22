/**
 * 🎯 Enhanced OCR Tool with Complete LaTeX Support
 * Final version with variation table handling
 */
const MISTRAL_CONFIG = {
  API_KEY: 'H18aNxUyTYy4jWD3Cag2FkjfO01PYbp6',
  OCR_URL: 'https://api.mistral.ai/v1/ocr',
  FILES_URL: 'https://api.mistral.ai/v1/files',
  OCR_MODEL: 'mistral-ocr-latest',
  MAX_RETRIES: 3,
  REQUEST_TIMEOUT: 60000
};

function doGet() {
  return HtmlService.createTemplateFromFile('index')
    .evaluate()
    .setXFrameOptionsMode(HtmlService.XFrameOptionsMode.ALLOWALL)
    .setTitle('OCR LaTeX Converter - PDF & Image to Math');
}

function include(filename) {
  return HtmlService.createHtmlOutputFromFile(filename).getContent();
}

/**
 * 🎯 COMPLETE LATEX WRAPPING - With Variation Table Support
 */
function wrapAllMathInDollarSigns(text) {
  if (!text || !text.trim()) return text;
  
  console.log('🔧 Starting comprehensive LaTeX wrapping...');
  
  let result = text;
  const preserved = [];
  
  // ========================================
  // STEP 0: Handle markdown tables specially
  // ========================================
  
  // Find and process markdown tables (variation tables)
  const tablePattern = /^\|[^\n]+\|(?:\n\|[^\n]+\|)*$/gm;
  
  result = result.replace(tablePattern, (match) => {
    console.log('Found table block');
    
    const id = `__TABLE_${preserved.length}__`;
    let processedTable = match;
    
    // Split into lines
    const lines = processedTable.split('\n');
    const processedLines = lines.map(line => {
      // Skip separator rows (---, :--:, etc.)
      if (/^\|[\s:|\-]+\|$/.test(line)) {
        return line;
      }
      
      // Process content rows
      let processedLine = line;
      
      // Wrap x variable: |x| → |$x$|
      processedLine = processedLine.replace(/\|(\s*)x(\s*)\|/g, '|$1$x$$2|');
      
      // Wrap f(x): |f(x)| → |$f(x)$|
      processedLine = processedLine.replace(/\|(\s*)f\(x\)(\s*)\|/g, '|$1$f(x)$$2|');
      
      // Wrap infinity: −∞ → $-\infty$, +∞ → $+\infty$
      processedLine = processedLine.replace(/([−\-])∞/g, '$-\\infty$');
      processedLine = processedLine.replace(/\+∞/g, '$+\\infty$');
      
      // Wrap isolated numbers: |−2| → |$-2$|, |1| → |$1$|
      processedLine = processedLine.replace(/\|(\s*)([−\-]?\d+)(\s*)\|/g, '|$1$$$2$$3|');
      
      // Wrap 0: | 0 | → | $0$ |
      processedLine = processedLine.replace(/\|(\s*)0(\s*)\|/g, '|$1$0$$2|');
      
      // Wrap + and − signs: |+| → |$+$|, |−| → |$-$|
      processedLine = processedLine.replace(/\|(\s*)\+(\s*)\|/g, '|$1$+$$2|');
      processedLine = processedLine.replace(/\|(\s*)[−\-](\s*)\|/g, '|$1$-$$2|');
      
      return processedLine;
    });
    
    processedTable = processedLines.join('\n');
    preserved.push(processedTable);
    return id;
  });
  
  // ========================================
  // STEP 1: Preserve already valid LaTeX
  // ========================================
  
  result = result.replace(/\$\$([^$]+)\$\$/g, (match) => {
    const id = `__PRESERVE_${preserved.length}__`;
    preserved.push(match);
    return id;
  });
  
  result = result.replace(/\$([^$\n]{1,}?)\$/g, (match, content) => {
    if (/\\[a-zA-Z]+|[+\-*/=()[\]{}<>≤≥≠±×÷∞∈∉⊂⊃∩∪αβγδεζηθικλμνξοπρστυφχψω²³⁴⁵⁶⁷⁸⁹⁰ⁿ₀₁₂₃₄₅₆₇₈₉ₙ]/.test(content)) {
      const id = `__PRESERVE_${preserved.length}__`;
      preserved.push(match);
      return id;
    }
    return content;
  });
  
  // ========================================
  // STEP 2: Remove orphaned $ signs
  // ========================================
  
  result = result.replace(/\$/g, '');
  
  // ========================================
  // STEP 3: Wrap LaTeX patterns
  // ========================================
  
  // LaTeX commands: \frac{1}{2}, \sqrt{x}, \infty
  result = result.replace(/(\\[a-zA-Z]+(?:\{[^}]*\}|\([^)]*\)|[^\s\w])*)/g, (match) => {
    if (match.includes('__PRESERVE_') || match.includes('__TABLE_')) return match;
    if (match === '\\n' || match === '\\t') return match;
    return `$${match}$`;
  });
  
  // Function definitions: y = f(x), g(x) = ...
  result = result.replace(/\b([a-zA-Z])\s*=\s*([a-zA-Z])\(([a-zA-Z])\)/g, (match) => {
    if (match.includes('__PRESERVE_') || match.includes('__TABLE_')) return match;
    return `$${match}$`;
  });
  
  // Intervals with semicolons: [-7;+∞), (0;2], {-7;4}
  result = result.replace(/[\[\(\{]([^[\](){}]*[;][^[\](){}]*)[\]\)\}]/g, (match) => {
    if (match.includes('__PRESERVE_') || match.includes('__TABLE_')) return match;
    return `$${match}$`;
  });
  
  // Number ranges: [0 ; 40), [40 ; 80)
  result = result.replace(/\[\s*(\d+)\s*;\s*(\d+)\s*\)/g, (match) => {
    if (match.includes('__PRESERVE_') || match.includes('__TABLE_')) return match;
    return `$${match}$`;
  });
  
  // Simple equations: x = -4, y = 9
  result = result.replace(/\b([a-zA-Z])\s*=\s*([-+]?\d+(?:\.\d+)?)/g, (match) => {
    if (match.includes('__PRESERVE_') || match.includes('__TABLE_')) return match;
    return `$${match}$`;
  });
  
  // Complex equations: x = -7+4
  result = result.replace(/\b([a-zA-Z])\s*=\s*([-+]?\d+(?:\s*[+\-*/]\s*\d+)*)/g, (match) => {
    if (match.includes('__PRESERVE_') || match.includes('__TABLE_')) return match;
    return `$${match}$`;
  });
  
  // Infinity symbols (not in tables)
  result = result.replace(/([+\-−])∞/g, (match, sign) => {
    if (match.includes('__PRESERVE_') || match.includes('__TABLE_')) return match;
    const mathSign = sign === '−' ? '-' : sign;
    return `$${mathSign}\\infty$`;
  });
  
  // Greek letters
  const greekMap = {
    'α': '\\alpha', 'β': '\\beta', 'γ': '\\gamma', 'δ': '\\delta',
    'ε': '\\epsilon', 'ζ': '\\zeta', 'η': '\\eta', 'θ': '\\theta',
    'ι': '\\iota', 'κ': '\\kappa', 'λ': '\\lambda', 'μ': '\\mu',
    'ν': '\\nu', 'ξ': '\\xi', 'π': '\\pi', 'ρ': '\\rho',
    'σ': '\\sigma', 'τ': '\\tau', 'υ': '\\upsilon', 'φ': '\\phi',
    'χ': '\\chi', 'ψ': '\\psi', 'ω': '\\omega'
  };
  
  Object.keys(greekMap).forEach(greek => {
    const regex = new RegExp(greek, 'g');
    result = result.replace(regex, (match) => {
      if (result.includes('__PRESERVE_') || result.includes('__TABLE_')) return match;
      return `$${greekMap[greek]}$`;
    });
  });
  
  // Superscripts: x², y³
  result = result.replace(/([a-zA-Z0-9]+)([²³⁴⁵⁶⁷⁸⁹⁰ⁿ]+)/g, (match, base, sup) => {
    if (match.includes('__PRESERVE_') || match.includes('__TABLE_')) return match;
    const supMap = {'²':'^2','³':'^3','⁴':'^4','⁵':'^5','⁶':'^6','⁷':'^7','⁸':'^8','⁹':'^9','⁰':'^0','ⁿ':'^n'};
    let latex = base;
    for (let c of sup) latex += supMap[c] || c;
    return `$${latex}$`;
  });
  
  // Subscripts: x₀, a₁
  result = result.replace(/([a-zA-Z])([₀₁₂₃₄₅₆₇₈₉ₙ]+)/g, (match, base, sub) => {
    if (match.includes('__PRESERVE_') || match.includes('__TABLE_')) return match;
    const subMap = {'₀':'_0','₁':'_1','₂':'_2','₃':'_3','₄':'_4','₅':'_5','₆':'_6','₇':'_7','₈':'_8','₉':'_9','ₙ':'_n'};
    let latex = base;
    for (let c of sub) latex += subMap[c] || c;
    return `$${latex}$`;
  });
  
  // Fractions: 1/2, a/b
  result = result.replace(/\b([a-zA-Z0-9]+)\s*\/\s*([a-zA-Z0-9]+)\b/g, (match, num, den) => {
    if (match.includes('__PRESERVE_') || match.includes('__TABLE_')) return match;
    return `$\\frac{${num}}{${den}}$`;
  });
  
  // Square roots: √2, √x
  result = result.replace(/√\s*([a-zA-Z0-9]+)/g, (match, content) => {
    if (match.includes('__PRESERVE_') || match.includes('__TABLE_')) return match;
    return `$\\sqrt{${content}}$`;
  });
  
  // Absolute values: |x|, |-4| (but not table separators)
  result = result.replace(/\|([a-zA-Z0-9\s+\-*/]+)\|/g, (match, content) => {
    if (match.includes('__PRESERVE_') || match.includes('__TABLE_')) return match;
    // Don't wrap if it's likely a table separator
    if (/^[\s\-:]+$/.test(content)) return match;
    return `$|${content}|$`;
  });
  
  // Set notation: {1;2;3}
  result = result.replace(/\{([^{}]*;[^{}]*)\}/g, (match) => {
    if (match.includes('__PRESERVE_') || match.includes('__TABLE_')) return match;
    return `$${match}$`;
  });
  
  // ========================================
  // STEP 4: Merge adjacent math blocks
  // ========================================
  
  result = result.replace(/\$([^$]+)\$\s*([+\-*/=<>≤≥])\s*\$([^$]+)\$/g, '$$$1 $$2 $$3$$');
  
  let changed = true;
  let iterations = 0;
  while (changed && iterations < 10) {
    const before = result;
    result = result.replace(/\$([^$]+)\$\s*=\s*\$([^$]+)\$/g, '$$$1 = $$2$$');
    changed = (before !== result);
    iterations++;
  }
  
  result = result.replace(/\$([^$]+)\$\s*;\s*\$([^$]+)\$/g, '$$$1 ; $$2$$');
  
  // ========================================
  // STEP 5: Clean up
  // ========================================
  
  result = result.replace(/\$+([^$]+)\$+/g, (match, content) => {
    if (match.startsWith('$$') && match.endsWith('$$') && !match.includes('$$$')) {
      return match;
    }
    return `$${content}$`;
  });
  
  result = result.replace(/\$\s*\$/g, '');
  result = result.replace(/\s+\$/g, ' $');
  result = result.replace(/\$\s+/g, '$ ');
  
  // ========================================
  // STEP 6: Restore preserved blocks
  // ========================================
  
  preserved.forEach((block, i) => {
    result = result.replace(`__PRESERVE_${i}__`, block);
    result = result.replace(`__TABLE_${i}__`, block);
  });
  
  console.log('✅ LaTeX wrapping completed');
  return result;
}

/**
 * Upload file to Mistral
 */
function uploadFileToMistral(fileBlob) {
  console.log(`Uploading file: ${fileBlob.getName()}, size: ${fileBlob.getBytes().length} bytes`);
  
  const options = {
    method: 'post',
    headers: {
      'Authorization': 'Bearer ' + MISTRAL_CONFIG.API_KEY
    },
    payload: {
      purpose: 'ocr',
      file: fileBlob
    },
    muteHttpExceptions: true,
    timeout: MISTRAL_CONFIG.REQUEST_TIMEOUT
  };
  
  const resp = UrlFetchApp.fetch(MISTRAL_CONFIG.FILES_URL, options);
  const responseCode = resp.getResponseCode();
  
  if (responseCode !== 200 && responseCode !== 201) {
    const error = resp.getContentText();
    console.error(`Upload failed with code ${responseCode}: ${error}`);
    throw new Error(`Upload failed: ${error}`);
  }
  
  const result = JSON.parse(resp.getContentText());
  console.log(`Upload successful, file ID: ${result.id}`);
  return result;
}

/**
 * Get signed URL
 */
function getSignedFileUrl(fileId, expiryHours = 24) {
  console.log(`Getting signed URL for file: ${fileId}`);
  Utilities.sleep(2000);
  
  const resp = UrlFetchApp.fetch(
    `${MISTRAL_CONFIG.FILES_URL}/${fileId}/url?expiry=${expiryHours}`,
    {
      method: 'get', 
      headers: {
        'Accept': 'application/json',
        'Authorization': 'Bearer ' + MISTRAL_CONFIG.API_KEY
      },
      muteHttpExceptions: true
    }
  );
  
  const responseCode = resp.getResponseCode();
  if (responseCode !== 200) {
    throw new Error(`Get signed URL failed (${responseCode}): ${resp.getContentText()}`);
  }
  
  const result = JSON.parse(resp.getContentText());
  console.log('Signed URL obtained');
  return result.url;
}

/**
 * Call Mistral OCR
 */
function callMistralOcr(signedUrl, includeImageBase64 = true) {
  console.log(`Calling OCR API with model: ${MISTRAL_CONFIG.OCR_MODEL}`);
  
  const payload = {
    model: MISTRAL_CONFIG.OCR_MODEL,
    document: {
      type: 'document_url',
      document_url: signedUrl
    },
    include_image_base64: includeImageBase64
  };
  
  const resp = UrlFetchApp.fetch(MISTRAL_CONFIG.OCR_URL, {
    method: 'post',
    contentType: 'application/json',
    payload: JSON.stringify(payload),
    headers: {
      'Content-Type': 'application/json',
      'Authorization': 'Bearer ' + MISTRAL_CONFIG.API_KEY
    },
    muteHttpExceptions: true,
    timeout: MISTRAL_CONFIG.REQUEST_TIMEOUT
  });
  
  const responseCode = resp.getResponseCode();
  const responseText = resp.getContentText();
  
  if (responseCode !== 200) {
    console.error(`OCR failed (${responseCode}): ${responseText}`);
    throw new Error(`OCR failed: ${responseText}`);
  }
  
  console.log(`OCR response received, length: ${responseText.length}`);
  return JSON.parse(responseText);
}

/**
 * Main OCR processing with LaTeX wrapping
 */
function processPdfOcr(base64Data, fileName) {
  const logs = [];
  const images = {};
  
  function log(message) {
    const logEntry = `[${new Date().toISOString()}] ${message}`;
    logs.push(logEntry);
    console.log(message);
  }
  
  try {
    log(`Starting OCR process for: ${fileName}`);
    
    let cleanBase64 = base64Data;
    if (base64Data.includes(',')) {
      cleanBase64 = base64Data.split(',')[1];
    }
    
    log('Converting base64 to PDF blob...');
    const bytes = Utilities.base64Decode(cleanBase64);
    const blob = Utilities.newBlob(bytes, 'application/pdf', fileName);
    const fileSizeMB = blob.getBytes().length / (1024 * 1024);
    log(`Created blob - Size: ${fileSizeMB.toFixed(2)} MB`);
    
    if (fileSizeMB > 50) {
      throw new Error(`File too large: ${fileSizeMB.toFixed(2)} MB. Limit is 50MB.`);
    }
    
    log('Step 1: Uploading file to Mistral...');
    const uploadInfo = uploadFileToMistral(blob);
    const fileId = uploadInfo.id;
    log(`File uploaded with ID: ${fileId}`);
    
    log('Step 2: Getting signed URL...');
    const signedUrl = getSignedFileUrl(fileId);
    log('Signed URL obtained');
    
    log('Step 3: Processing OCR with include_image_base64=true...');
    const ocrResult = callMistralOcr(signedUrl, true);
    
    const pages = ocrResult.pages || [];
    log(`OCR completed with ${pages.length} pages`);
    
    let allPagesMarkdown = '';
    let totalChars = 0;
    let pagesWithText = 0;
    let totalImages = 0;
    
    pages.forEach((page, index) => {
      const pageText = page.markdown || page.text || '';
      const charCount = pageText.length;
      totalChars += charCount;
      
      if (charCount > 0) {
        pagesWithText++;
      }
      
      // 🎯 WRAP ALL MATH IN $...$
      let processedText = wrapAllMathInDollarSigns(pageText);
      
      if (index > 0) {
        allPagesMarkdown += '\n\n---\n\n';
      }
      allPagesMarkdown += `### 📄 Page ${index + 1}\n\n`;
      allPagesMarkdown += processedText || '*(No text content detected)*';
      
      // Extract images
      if (page.images && Array.isArray(page.images)) {
        page.images.forEach(img => {
          if (img.id && img.image_base64) {
            let cleanImageBase64 = img.image_base64;
            
            if (cleanImageBase64.includes(',')) {
              cleanImageBase64 = cleanImageBase64.split(',')[1];
            }
            
            cleanImageBase64 = cleanImageBase64.replace(/\s+/g, '');
            
            while (cleanImageBase64.length % 4 !== 0) {
              cleanImageBase64 += '=';
            }
            
            try {
              Utilities.base64Decode(cleanImageBase64);
              images[img.id] = cleanImageBase64;
              
              const idWithoutExt = img.id.replace(/\.(jpg|jpeg|png)$/i, '');
              images[idWithoutExt] = cleanImageBase64;
              
              totalImages++;
              log(`✅ Stored image ${img.id} from page ${index + 1}`);
            } catch (cleanError) {
              log(`❌ Failed to clean base64 for ${img.id}: ${cleanError.message}`);
            }
          }
        });
      }
      
      log(`Page ${index + 1}: ${charCount} characters`);
    });
    
    log(`Total images processed: ${Math.floor(totalImages / 2)} unique images`);
    
    return {
      success: true,
      markdown: allPagesMarkdown,
      pageCount: pages.length,
      pagesWithText: pagesWithText,
      totalChars: totalChars,
      fileId: fileId,
      fileName: fileName,
      images: images,
      logs: logs,
      rawData: ocrResult
    };
    
  } catch (error) {
    log(`ERROR: ${error.message}`);
    console.error('Full error:', error);
    
    return {
      success: false,
      error: error.message,
      logs: logs
    };
  }
}

/**
 * Process Image OCR
 */
function processImageOcr(base64Data, fileName) {
  const logs = [];
  
  function log(message) {
    const logEntry = `[${new Date().toISOString()}] ${message}`;
    logs.push(logEntry);
    console.log(message);
  }
  
  try {
    log(`Starting image OCR process for: ${fileName}`);
    
    let cleanBase64 = base64Data;
    if (base64Data.includes(',')) {
      cleanBase64 = base64Data.split(',')[1];
    }
    
    log('Converting base64 to image blob...');
    const imageBytes = Utilities.base64Decode(cleanBase64);
    
    let mimeType = 'image/jpeg';
    const extension = fileName.toLowerCase().split('.').pop();
    if (extension === 'png') {
      mimeType = 'image/png';
    }
    
    const imageBlob = Utilities.newBlob(imageBytes, mimeType, fileName);
    const imageSizeMB = imageBlob.getBytes().length / (1024 * 1024);
    log(`Image blob created - Size: ${imageSizeMB.toFixed(2)} MB`);
    
    log('Converting image to PDF...');
    const pdfBlob = convertImageToPdf(imageBlob, fileName);
    const pdfSizeMB = pdfBlob.getBytes().length / (1024 * 1024);
    log(`PDF created - Size: ${pdfSizeMB.toFixed(2)} MB`);
    
    const pdfBase64 = 'data:application/pdf;base64,' + Utilities.base64Encode(pdfBlob.getBytes());
    const pdfFileName = fileName.replace(/\.(jpg|jpeg|png)$/i, '_converted.pdf');
    
    const ocrResult = processPdfOcr(pdfBase64, pdfFileName);
    
    if (ocrResult.success) {
      ocrResult.originalFileName = fileName;
      ocrResult.originalImageSize = imageSizeMB;
      ocrResult.pdfSize = pdfSizeMB;
      
      ocrResult.markdown = `### 🖼️ Image Conversion Info\n\n` +
                          `- **Original**: ${fileName} (${imageSizeMB.toFixed(2)} MB)\n` +
                          `- **PDF**: ${pdfFileName} (${pdfSizeMB.toFixed(2)} MB)\n\n` +
                          `---\n\n` +
                          ocrResult.markdown;
      
      if (ocrResult.logs) {
        ocrResult.logs = [...logs, ...ocrResult.logs];
      } else {
        ocrResult.logs = logs;
      }
    }
    
    return ocrResult;
    
  } catch (error) {
    log(`ERROR: ${error.message}`);
    return {
      success: false,
      error: error.message,
      logs: logs
    };
  }
}

/**
 * Convert image to PDF
 */
function convertImageToPdf(imageBlob, originalFileName) {
  const doc = DocumentApp.create(`TempDoc_${new Date().getTime()}`);
  const body = doc.getBody();
  body.clear();
  
  const image = body.appendImage(imageBlob);
  
  const maxWidth = 500;
  const maxHeight = 700;
  let width = image.getWidth();
  let height = image.getHeight();
  
  const scale = Math.min(maxWidth / width, maxHeight / height, 1);
  
  if (scale < 1) {
    image.setWidth(Math.round(width * scale));
    image.setHeight(Math.round(height * scale));
  }
  
  const paragraph = image.getParent().asParagraph();
  paragraph.setAlignment(DocumentApp.HorizontalAlignment.CENTER);
  
  doc.saveAndClose();
  
  const docFile = DriveApp.getFileById(doc.getId());
  const pdfBlob = docFile.getBlob().setName(`converted_${new Date().getTime()}.pdf`);
  
  DriveApp.getFileById(doc.getId()).setTrashed(true);
  
  return pdfBlob;
}

/**
 * Test API connection
 */
function testMistralConnection() {
  try {
    console.log('Testing Mistral API connection...');
    
    const options = {
      method: 'get',
      headers: {
        'Accept': 'application/json',
        'Authorization': 'Bearer ' + MISTRAL_CONFIG.API_KEY
      },
      muteHttpExceptions: true
    };
    
    const response = UrlFetchApp.fetch(MISTRAL_CONFIG.FILES_URL, options);
    const code = response.getResponseCode();
    
    if (code === 200) {
      console.log('✓ API connection successful');
      return {
        success: true,
        message: 'API connection successful'
      };
    } else if (code === 401) {
      console.error('✗ Invalid API key');
      return {
        success: false,
        message: 'Invalid API key'
      };
    } else {
      console.error(`✗ Unexpected response code: ${code}`);
      return {
        success: false,
        message: `Unexpected response code: ${code}`
      };
    }
  } catch (error) {
    console.error('✗ Connection test failed:', error.message);
    return {
      success: false,
      message: `Connection test failed: ${error.message}`
    };
  }
}
