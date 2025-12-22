/**
 * code.gs - PDF/Image → Text Converter + Similar Problem Generator
 * HYBRID VERSION: Mistral OCR + Gemini Similar Generator
 * 
 * v8.2-Hybrid (2025-01-26)
 * - NEW: Mistral AI for OCR using chat completions with vision
 * - Gemini AI for Similar Problem Generation
 * - Complete LaTeX wrapping support
 * - Improved: Better error handling and fallback
 * - Optimized: Performance and reliability
 */

/* ========================= MISTRAL AI CONFIG (OCR) ========================= */
const MISTRAL_CONFIG = {
  API_KEY: 'H18aNxUyTYy4jWD3Cag2FkjfO01PYbp6',
  CHAT_URL: 'https://api.mistral.ai/v1/chat/completions',
  OCR_MODEL: 'mistral-ocr-latest',
  MAX_RETRIES: 3,
  REQUEST_TIMEOUT: 60000,
  GENERATION: {
    temperature: 0.1,
    max_tokens: 8192
  }
};

/* ========================= GEMINI CONFIG (Similar Generation) ========================= */
const GEMINI_CONFIG = {
  // Single array of API keys - Just update this one place!
  API_KEYS: [
    "AIzaSyAQtE8tkQBfsxoE552XQ8kpEYN5xYDURBg",
    "AIzaSyDzaTupNVfuFEQ0l6eAavUBkSbEpDL-vN4",
    "AIzaSyAVOgQe7qoKUPh-t03g7XM6l2Xgs8VaSm0",
    "AIzaSyD61TBHx1U2q7U-dhgur-nZ4ntOYwurSp0",
    "AIzaSyD6uAzLz6y2CwgEHg-1XVPM11iAPoEoc3E",
    "AIzaSyDCrzo3_3hKMF3jr114J7pb_wAAd2LesjI",
    "AIzaSyCVUtoKWzyw27LvVbQPxs5D4n48eZWNw9k",
    "AIzaSyAH1fQINWj6p_fK_dW8v5pQ2F5KAzoZQAw",
    "AIzaSyCP-2YaYvQD4w5E8uNlm150vVa0CJQFCGA",
    "AIzaSyCN94-Mkws5Ip0YJYL9nl6QNLwXdW6HxPE"
  ],
  
  // Models configuration (only for Similar Generation now)
  MODELS: {
    SIMILAR: 'gemini-2.5-flash'
  },
  
  // Generation parameters
  GENERATION: {
    SIMILAR: { temperature: 0.6, topK: 40, topP: 0.95, maxOutputTokens: 66536 }
  },
  
  // API configuration
  API_BASE: 'https://generativelanguage.googleapis.com/v1beta/models/',
  MAX_RETRIES: 5,
  RETRY_DELAY: 1500,
  RATE_DELAY: 800,
  
  // Enhanced key rotation settings
  ROTATION: {
    ENABLE_SMART_ROTATION: true,
    TRACK_KEY_PERFORMANCE: true,
    BLACKLIST_FAILED_KEYS: true,
    RESET_BLACKLIST_INTERVAL: 300000
  },
  
  // Script Properties keys - SIMPLIFIED
  PROPERTIES: {
    API_KEYS: 'GEMINI_API_KEYS',
    CURRENT_INDEX: 'GEMINI_KEY_IDX',
    KEY_PERFORMANCE: 'GEMINI_KEY_PERF',
    KEY_BLACKLIST: 'GEMINI_KEY_BLACKLIST'
  }
};

// Global variables for key management
let __keyPerformanceCache = null;
let __keyBlacklistCache = null;

/* ========================= WEB APP ========================= */
function doGet() {
  try {
    return HtmlService.createTemplateFromFile('index')
      .evaluate()
      .setXFrameOptionsMode(HtmlService.XFrameOptionsMode.ALLOWALL)
      .setTitle('PDF to Text & Similar Problem Generator');
  } catch (error) {
    console.error('Error serving HTML:', error);
    return HtmlService.createHtmlOutput('<h1>PDF to Text Generator</h1><p style="color:#ef4444">Error: ' + escapeHtml_(error.message) + '</p>');
  }
}

function include(filename) {
  return HtmlService.createHtmlOutputFromFile(filename).getContent();
}

/* ========================= SIMPLIFIED KEY MANAGEMENT ========================= */

/**
 * Get all available API keys - SIMPLIFIED VERSION
 */
function __getAllApiKeys() {
  const keys = [];
  
  try {
    const propsKeys = PropertiesService.getScriptProperties().getProperty(GEMINI_CONFIG.PROPERTIES.API_KEYS);
    if (propsKeys) {
      propsKeys.split(',').forEach(key => {
        const cleanKey = (key || '').trim();
        if (cleanKey && cleanKey.startsWith('AIzaSy') && !cleanKey.includes('ReplaceWithRealKey')) {
          keys.push(cleanKey);
        }
      });
    }
  } catch (e) {
    console.warn('Cannot read API keys from properties:', e.message);
  }
  
  // Fallback to hardcoded keys
  if (keys.length === 0) {
    GEMINI_CONFIG.API_KEYS.forEach(key => {
      const cleanKey = (key || '').trim();
      if (cleanKey && cleanKey.startsWith('AIzaSy') && !cleanKey.includes('ReplaceWithRealKey')) {
        keys.push(cleanKey);
      }
    });
  }
  
  return keys;
}

/**
 * Get next API key with smart rotation
 */
function __getNextApiKey() {
  const allKeys = __getAllApiKeys();
  
  if (!allKeys.length) {
    throw new Error('🚨 No valid API keys available. Please configure keys in Script Properties.');
  }
  
  if (!GEMINI_CONFIG.ROTATION.ENABLE_SMART_ROTATION) {
    return __getSimpleRotationKey(allKeys);
  }
  
  return __getSmartRotationKey(allKeys);
}

/**
 * Simple round-robin key rotation
 */
function __getSimpleRotationKey(keys) {
  try {
    const props = PropertiesService.getScriptProperties();
    let currentIndex = parseInt(props.getProperty(GEMINI_CONFIG.PROPERTIES.CURRENT_INDEX) || '0', 10);
    
    if (isNaN(currentIndex) || currentIndex < 0 || currentIndex >= keys.length) {
      currentIndex = 0;
    }
    
    const selectedKey = keys[currentIndex];
    const nextIndex = (currentIndex + 1) % keys.length;
    
    props.setProperty(GEMINI_CONFIG.PROPERTIES.CURRENT_INDEX, nextIndex.toString());
    
    console.log(`🔄 Key rotation: ${currentIndex} → ${nextIndex} (${keys.length} total)`);
    return selectedKey;
    
  } catch (e) {
    console.warn('Simple rotation failed, using first key:', e.message);
    return keys[0];
  }
}

/**
 * Smart key rotation with performance tracking
 */
function __getSmartRotationKey(keys) {
  try {
    const performance = __getKeyPerformance();
    const blacklist = __getKeyBlacklist();
    const now = Date.now();
    
    const availableKeys = keys.filter(key => {
      const blacklistEntry = blacklist[key];
      if (!blacklistEntry) return true;
      
      const isExpired = (now - blacklistEntry.timestamp) > GEMINI_CONFIG.ROTATION.RESET_BLACKLIST_INTERVAL;
      if (isExpired) {
        delete blacklist[key];
        return true;
      }
      
      return false;
    });
    
    const keysToUse = availableKeys.length > 0 ? availableKeys : keys;
    
    if (availableKeys.length === 0) {
      console.warn('🔄 All keys blacklisted, resetting blacklist');
      __saveKeyBlacklist({});
    }
    
    const sortedKeys = keysToUse.sort((a, b) => {
      const perfA = performance[a] || { success: 0, total: 0, lastUsed: 0 };
      const perfB = performance[b] || { success: 0, total: 0, lastUsed: 0 };
      
      const successRateA = perfA.total > 0 ? perfA.success / perfA.total : 0.5;
      const successRateB = perfB.total > 0 ? perfB.success / perfB.total : 0.5;
      
      const timeSinceUsedA = now - perfA.lastUsed;
      const timeSinceUsedB = now - perfB.lastUsed;
      
      const scoreA = successRateA * 0.7 + (timeSinceUsedA / 60000) * 0.3;
      const scoreB = successRateB * 0.7 + (timeSinceUsedB / 60000) * 0.3;
      
      return scoreB - scoreA;
    });
    
    console.log(`🧠 Smart rotation selected key with highest score (${sortedKeys.length} available)`);
    return sortedKeys[0];
    
  } catch (e) {
    console.warn('Smart rotation failed, falling back to simple:', e.message);
    return __getSimpleRotationKey(keys);
  }
}

/**
 * Track API key performance
 */
function __trackKeyPerformance(apiKey, success, responseTime = 0) {
  if (!GEMINI_CONFIG.ROTATION.TRACK_KEY_PERFORMANCE) return;
  
  try {
    const performance = __getKeyPerformance();
    const now = Date.now();
    
    if (!performance[apiKey]) {
      performance[apiKey] = {
        success: 0,
        total: 0,
        totalResponseTime: 0,
        lastUsed: 0,
        created: now
      };
    }
    
    const keyPerf = performance[apiKey];
    keyPerf.total++;
    keyPerf.lastUsed = now;
    keyPerf.totalResponseTime += responseTime;
    
    if (success) {
      keyPerf.success++;
    } else if (GEMINI_CONFIG.ROTATION.BLACKLIST_FAILED_KEYS) {
      const recentFailures = keyPerf.total - keyPerf.success;
      if (recentFailures >= 3) {
        __addToBlacklist(apiKey, 'Multiple consecutive failures');
      }
    }
    
    __saveKeyPerformance(performance);
    
  } catch (e) {
    console.warn('Failed to track key performance:', e.message);
  }
}

function __getKeyPerformance() {
  if (__keyPerformanceCache) return __keyPerformanceCache;
  
  try {
    const stored = PropertiesService.getScriptProperties().getProperty(GEMINI_CONFIG.PROPERTIES.KEY_PERFORMANCE);
    __keyPerformanceCache = stored ? JSON.parse(stored) : {};
  } catch (e) {
    __keyPerformanceCache = {};
  }
  
  return __keyPerformanceCache;
}

function __saveKeyPerformance(performance) {
  try {
    __keyPerformanceCache = performance;
    const serialized = JSON.stringify(performance);
    PropertiesService.getScriptProperties().setProperty(GEMINI_CONFIG.PROPERTIES.KEY_PERFORMANCE, serialized);
  } catch (e) {
    console.warn('Failed to save key performance:', e.message);
  }
}

function __getKeyBlacklist() {
  if (__keyBlacklistCache) return __keyBlacklistCache;
  
  try {
    const stored = PropertiesService.getScriptProperties().getProperty(GEMINI_CONFIG.PROPERTIES.KEY_BLACKLIST);
    __keyBlacklistCache = stored ? JSON.parse(stored) : {};
  } catch (e) {
    __keyBlacklistCache = {};
  }
  
  return __keyBlacklistCache;
}

function __saveKeyBlacklist(blacklist) {
  try {
    __keyBlacklistCache = blacklist;
    const serialized = JSON.stringify(blacklist);
    PropertiesService.getScriptProperties().setProperty(GEMINI_CONFIG.PROPERTIES.KEY_BLACKLIST, serialized);
  } catch (e) {
    console.warn('Failed to save key blacklist:', e.message);
  }
}

function __addToBlacklist(apiKey, reason) {
  const blacklist = __getKeyBlacklist();
  blacklist[apiKey] = {
    reason: reason,
    timestamp: Date.now()
  };
  __saveKeyBlacklist(blacklist);
  console.warn(`⚫ Blacklisted API key: ${reason}`);
}

/* ========================= GEMINI API CALL ========================= */
function __geminiGenerate({ model, prompt, imageBase64 = null, imageMime = 'image/png', temperature = 0.2, topK = 40, topP = 0.95, maxOutputTokens = 2048 }) {
  const allKeys = __getAllApiKeys();
  
  if (!allKeys.length) {
    throw new Error('🚨 No Gemini API keys configured. Please set up keys in Script Properties.');
  }
  
  const maxAttempts = Math.min(allKeys.length * 2, 10);
  let lastError = null;
  
  for (let attempt = 0; attempt < maxAttempts; attempt++) {
    const apiKey = __getNextApiKey();
    const startTime = Date.now();
    
    try {
      const url = `${GEMINI_CONFIG.API_BASE}${model}:generateContent?key=${encodeURIComponent(apiKey)}`;
      
      const parts = [{ text: prompt || '' }];
      if (imageBase64) {
        parts.push({
          inline_data: {
            mime_type: imageMime || 'image/png',
            data: imageBase64
          }
        });
      }
      
      const payload = {
        contents: [{ role: 'user', parts }],
        generationConfig: { temperature, topK, topP, maxOutputTokens },
        safetySettings: [
          { category: "HARM_CATEGORY_HARASSMENT", threshold: "BLOCK_MEDIUM_AND_ABOVE" },
          { category: "HARM_CATEGORY_HATE_SPEECH", threshold: "BLOCK_MEDIUM_AND_ABOVE" },
          { category: "HARM_CATEGORY_SEXUALLY_EXPLICIT", threshold: "BLOCK_MEDIUM_AND_ABOVE" },
          { category: "HARM_CATEGORY_DANGEROUS_CONTENT", threshold: "BLOCK_MEDIUM_AND_ABOVE" }
        ]
      };
      
      const response = UrlFetchApp.fetch(url, {
        method: 'POST',
        contentType: 'application/json',
        payload: JSON.stringify(payload),
        muteHttpExceptions: true
      });
      
      const responseTime = Date.now() - startTime;
      const statusCode = response.getResponseCode();
      const responseBody = response.getContentText();
      
      if (statusCode === 200) {
        try {
          const data = JSON.parse(responseBody);
          const candidates = data?.candidates || [];
          
          if (candidates.length === 0) {
            throw new Error('No candidates in response');
          }
          
          const content = candidates[0]?.content?.parts || [];
          const text = content.map(part => part.text || '').join('').trim();
          
          if (!text) {
            throw new Error('Empty response text');
          }
          
          __trackKeyPerformance(apiKey, true, responseTime);
          
          console.log(`✅ Gemini API success (${responseTime}ms, attempt ${attempt + 1})`);
          return text;
          
        } catch (parseError) {
          throw new Error(`Response parse error: ${parseError.message}`);
        }
      } else {
        let errorMessage = `HTTP ${statusCode}`;
        
        try {
          const errorData = JSON.parse(responseBody);
          errorMessage = errorData?.error?.message || errorMessage;
        } catch (e) {
          errorMessage = responseBody.substring(0, 200);
        }
        
        __trackKeyPerformance(apiKey, false, responseTime);
        
        const shouldRetry = statusCode === 429 || statusCode === 503 || statusCode === 500 || statusCode === 403;
        
        if (!shouldRetry) {
          throw new Error(`${errorMessage} (Non-retryable error)`);
        }
        
        lastError = new Error(`${errorMessage} (Key ${attempt + 1})`);
        console.warn(`⚠️ API attempt ${attempt + 1} failed: ${errorMessage}`);
        
        if (attempt < maxAttempts - 1) {
          Utilities.sleep(GEMINI_CONFIG.RETRY_DELAY + (attempt * 500));
        }
      }
      
    } catch (error) {
      const responseTime = Date.now() - startTime;
      __trackKeyPerformance(apiKey, false, responseTime);
      
      lastError = error;
      console.warn(`🔴 API key attempt ${attempt + 1} failed: ${error.message}`);
      
      if (attempt < maxAttempts - 1) {
        Utilities.sleep(GEMINI_CONFIG.RETRY_DELAY);
      }
    }
  }
  
  throw new Error(`🚨 All API attempts failed. Last error: ${lastError?.message || 'Unknown error'}`);
}

/* ========================= MISTRAL AI OCR FUNCTIONS ========================= */

/**
 * 🎯 COMPLETE LATEX WRAPPING - Enhanced version from working code
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
 * Mistral OCR - Convert image to text using Mistral AI chat completions
 */
function __mistralOCR(base64Image, prompt) {
  const maxAttempts = MISTRAL_CONFIG.MAX_RETRIES;
  let lastError = null;
  
  for (let attempt = 0; attempt < maxAttempts; attempt++) {
    const startTime = Date.now();
    
    try {
      const url = MISTRAL_CONFIG.CHAT_URL;
      
      const payload = {
        model: MISTRAL_CONFIG.OCR_MODEL,
        messages: [
          {
            role: 'user',
            content: [
              {
                type: 'text',
                text: prompt
              },
              {
                type: 'image_url',
                image_url: `data:image/jpeg;base64,${base64Image}`
              }
            ]
          }
        ],
        temperature: MISTRAL_CONFIG.GENERATION.temperature,
        max_tokens: MISTRAL_CONFIG.GENERATION.max_tokens
      };
      
      const response = UrlFetchApp.fetch(url, {
        method: 'POST',
        contentType: 'application/json',
        headers: {
          'Authorization': `Bearer ${MISTRAL_CONFIG.API_KEY}`
        },
        payload: JSON.stringify(payload),
        muteHttpExceptions: true
      });
      
      const responseTime = Date.now() - startTime;
      const statusCode = response.getResponseCode();
      const responseBody = response.getContentText();
      
      if (statusCode === 200) {
        try {
          const data = JSON.parse(responseBody);
          const content = data?.choices?.[0]?.message?.content;
          
          if (!content) {
            throw new Error('No content in Mistral response');
          }
          
          // Return plain text without LaTeX wrapping
          console.log(`✅ Mistral OCR success (${responseTime}ms, attempt ${attempt + 1})`);
          return content.trim();
          
        } catch (parseError) {
          throw new Error(`Mistral response parse error: ${parseError.message}`);
        }
      } else {
        let errorMessage = `HTTP ${statusCode}`;
        
        try {
          const errorData = JSON.parse(responseBody);
          errorMessage = errorData?.error?.message || errorData?.message || errorMessage;
        } catch (e) {
          errorMessage = responseBody.substring(0, 200);
        }
        
        const shouldRetry = statusCode === 429 || statusCode === 503 || statusCode === 500;
        
        if (!shouldRetry) {
          throw new Error(`${errorMessage} (Non-retryable error)`);
        }
        
        lastError = new Error(`${errorMessage} (Attempt ${attempt + 1})`);
        console.warn(`⚠️ Mistral OCR attempt ${attempt + 1} failed: ${errorMessage}`);
        
        if (attempt < maxAttempts - 1) {
          Utilities.sleep(2000 + (attempt * 1000)); // Progressive backoff
        }
      }
      
    } catch (error) {
      lastError = error;
      console.warn(`🔴 Mistral OCR attempt ${attempt + 1} error: ${error.message}`);
      
      if (attempt < maxAttempts - 1) {
        Utilities.sleep(2000 + (attempt * 1000));
      }
    }
  }
  
  throw new Error(`🚨 All Mistral OCR attempts failed. Last error: ${lastError?.message || 'Unknown error'}`);
}

/* ========================= ADMIN FUNCTIONS - SIMPLIFIED ========================= */

/**
 * Set API keys (comma-separated) - SINGLE LOCATION
 */
function setGeminiApiKeys(csvKeys) {
  if (!csvKeys || typeof csvKeys !== 'string') {
    throw new Error('Please provide comma-separated API keys: "key1,key2,key3"');
  }
  
  const keys = csvKeys.split(',').map(k => k.trim()).filter(k => k.startsWith('AIzaSy'));
  
  if (keys.length === 0) {
    throw new Error('No valid API keys found. Keys must start with "AIzaSy"');
  }
  
  try {
    PropertiesService.getScriptProperties().setProperty(GEMINI_CONFIG.PROPERTIES.API_KEYS, keys.join(','));
    PropertiesService.getScriptProperties().setProperty(GEMINI_CONFIG.PROPERTIES.CURRENT_INDEX, '0');
    
    __keyPerformanceCache = null;
    __keyBlacklistCache = null;
    
    return {
      success: true,
      message: `✅ Saved ${keys.length} API keys successfully!`,
      keys: keys.length
    };
  } catch (error) {
    throw new Error(`Failed to save API keys: ${error.message}`);
  }
}

/**
 * Get API key status
 */
function getApiKeyStatus() {
  try {
    const allKeys = __getAllApiKeys();
    const performance = __getKeyPerformance();
    const blacklist = __getKeyBlacklist();
    const now = Date.now();
    
    const status = {
      totalKeys: allKeys.length,
      activeKeys: 0,
      blacklistedKeys: 0,
      keyStats: []
    };
    
    allKeys.forEach((key, index) => {
      const keyId = `Key_${index + 1}`;
      const perf = performance[key] || { success: 0, total: 0, lastUsed: 0 };
      const isBlacklisted = blacklist[key] && (now - blacklist[key].timestamp) < GEMINI_CONFIG.ROTATION.RESET_BLACKLIST_INTERVAL;
      
      if (isBlacklisted) {
        status.blacklistedKeys++;
      } else {
        status.activeKeys++;
      }
      
      status.keyStats.push({
        id: keyId,
        successRate: perf.total > 0 ? ((perf.success / perf.total) * 100).toFixed(1) + '%' : 'N/A',
        totalCalls: perf.total,
        lastUsed: perf.lastUsed > 0 ? new Date(perf.lastUsed).toLocaleString() : 'Never',
        status: isBlacklisted ? 'Blacklisted' : 'Active',
        avgResponseTime: perf.total > 0 ? Math.round(perf.totalResponseTime / perf.total) + 'ms' : 'N/A'
      });
    });
    
    return status;
  } catch (error) {
    throw new Error(`Failed to get API status: ${error.message}`);
  }
}

/**
 * Reset API key tracking
 */
function resetApiKeyTracking() {
  try {
    const props = PropertiesService.getScriptProperties();
    props.deleteProperty(GEMINI_CONFIG.PROPERTIES.KEY_PERFORMANCE);
    props.deleteProperty(GEMINI_CONFIG.PROPERTIES.KEY_BLACKLIST);
    props.setProperty(GEMINI_CONFIG.PROPERTIES.CURRENT_INDEX, '0');
    
    __keyPerformanceCache = null;
    __keyBlacklistCache = null;
    
    return {
      success: true,
      message: '✅ API key tracking data reset successfully!'
    };
  } catch (error) {
    throw new Error(`Failed to reset tracking: ${error.message}`);
  }
}

/* ========================= CORE PROCESSING ========================= */
function processPdfToText(pages, mode = 'word') {
  try {
    if (!Array.isArray(pages) || pages.length === 0) throw new Error('Không có dữ liệu ảnh.');
    const MAX_PAGES = 25;
    if (pages.length > MAX_PAGES) throw new Error(`Quá ${MAX_PAGES} trang, hãy chia nhỏ.`);
    
    let combined = '';
    for (let i = 0; i < pages.length; i++) {
      const { data, mime } = __splitDataUrl(pages[i]);
      try {
        // Always use Word mode with Mistral OCR
        combined += `\n=== TRANG ${i + 1} ===\n` + __ocrImageToWordText(data, mime) + '\n';
      } catch (e) {
        combined += `\n=== TRANG ${i + 1} - LỖI: ${e && e.message} ===\n`;
      }
      if (i < pages.length - 1) Utilities.sleep(600);
    }
    
    if (!combined.trim()) throw new Error('OCR rỗng.');
    
    return {
      success: true,
      result: formatTextOutput(combined, pages.length, mode),
      metadata: {
        total_pages: pages.length,
        ocr_engine: 'Mistral AI',
        model_ocr: MISTRAL_CONFIG.OCR_MODEL,
        timestamp: new Date().toISOString(),
        theme: 'hybrid'
      }
    };
  } catch (error) {
    return { success: false, error: error.message || 'PDF→Text lỗi.' };
  }
}

function processImageToText(dataUrlOrBase64, mode = 'word') {
  try {
    const { data, mime } = __splitDataUrl(dataUrlOrBase64);
    // Always use Mistral OCR in Word mode
    const out = __ocrImageToWordText(data, mime);
    
    return {
      success: true,
      result: out,
      metadata: {
        mode: 'word',
        ocr_engine: 'Mistral AI',
        model_ocr: MISTRAL_CONFIG.OCR_MODEL,
        theme: 'hybrid',
        ts: new Date().toISOString()
      }
    };
  } catch (e) {
    return { success: false, error: e.message || 'Image→Text lỗi.' };
  }
}

/* ========================= SIMILAR GENERATION ========================= */
function generateSimilarProblems(originalContent, mode = 'word', options = {}) {
  const preferSingleShot = options.singleShot !== false;
  if (preferSingleShot) {
    try {
      const single = generateSimilarSingleShot(originalContent, mode, options);
      if (single?.success) return single;
    } catch (e) {
      console.warn('Single-shot failed → fallback batch. Reason:', e && e.message);
    }
  }
  return generateSimilarProblems_Batch(originalContent, mode, options);
}

function generateSimilarSingleShot(originalContent, mode = 'word', options = {}) {
  try {
    if (!originalContent || typeof originalContent !== 'string' || originalContent.trim().length < 50) {
      throw new Error('Nội dung gốc quá ngắn hoặc không hợp lệ.');
    }

    let working = originalContent;
    if (mode === 'word' && options.range && options.range.from != null && options.range.to != null) {
      const kind = (options.range.type || options.granularity || 'auto');
      const sliced = __extractRangeWord(originalContent, kind, Number(options.range.from), Number(options.range.to));
      if (sliced) working = sliced;
    }

    const parsed = __parseQuestions(working, mode, options);
    if (!parsed.length) throw new Error('Không tìm thấy câu hỏi.');
    
    const sanitizedList = parsed.map(q => __sanitizeQuestion(q, mode));
    const targetCount = sanitizedList.length;

    const compactBody = sanitizedList
      .map((q, idx) => `<<Q${idx + 1}>>\n${__tightenText(q.content, mode)}`)
      .join('\n\n');

    const instructions =
`Ocean AI Assistant - Chuyên gia biên soạn đề ${mode === 'latex' ? 'LaTeX (ex_test)' : 'Word'}.
Hãy TẠO BÀI TƯƠNG TỰ cho toàn bộ câu sau, giữ nguyên số lượng (${targetCount} câu), dạng toán, độ khó, nhưng THAY số liệu/ngữ cảnh.

QUY TẮC:
- Không thêm lời giải.
- ${mode === 'latex'
  ? 'Mỗi câu bọc đầy đủ \\begin{ex} ... \\end{ex}; dùng \\choice/\\choiceTF/\\shortans khi phù hợp.'
  : 'Giữ công thức trong $...$; mỗi câu bắt đầu bằng "Câu i:"; xuống dòng gọn.'}
- Trả về CHỈ NỘI DUNG đề tương tự, KHÔNG kèm chú thích, KHÔNG giải thích.
- Phải sinh đủ ${targetCount} câu, theo đúng thứ tự Q1→Q${targetCount}.
- Dùng các marker sau để phân tách:
===BEGIN_SIMILAR===
... (Câu 1 tương ứng Q1) ...
---END_QUESTION---
... (Câu 2 tương ứng Q2) ...
---END_QUESTION---
... (tiếp tục cho đến Q${targetCount}) ...
===END_SIMILAR===

DỮ LIỆU GỐC:
${compactBody}

BẮT ĐẦU SINH:`;

    const resp = __geminiGenerate({
      model: GEMINI_CONFIG.MODELS.SIMILAR,
      prompt: instructions,
      temperature: GEMINI_CONFIG.GENERATION.SIMILAR.temperature,
      topK: GEMINI_CONFIG.GENERATION.SIMILAR.topK,
      topP: GEMINI_CONFIG.GENERATION.SIMILAR.topP,
      maxOutputTokens: GEMINI_CONFIG.GENERATION.SIMILAR.maxOutputTokens
    });

    const blocks = __extractSimilarBlocks(resp, targetCount);
    const similarCombined = (mode === 'latex')
      ? '% Ocean Similar Generator\n' + blocks.join('\n\n')
      : 'BÀI TẬP TƯƠNG TỰ - OCEAN GENERATOR\n' + '='.repeat(48) + '\n\n' + blocks.join('\n\n');

    return {
      success: true,
      result: {
        original: originalContent,
        similar: similarCombined,
        comparison: {
          original_questions: targetCount,
          similar_questions: blocks.length,
          mode,
          strategy: 'single-shot',
          theme: 'ocean'
        }
      },
      metadata: {
        processing_mode: mode,
        generation_model: GEMINI_CONFIG.MODELS.SIMILAR,
        single_shot: true,
        theme: 'ocean',
        timestamp: new Date().toISOString()
      }
    };
  } catch (error) {
    throw error;
  }
}

function generateSimilarProblems_Batch(originalContent, mode = 'word', options = {}) {
  try {
    if (!originalContent || typeof originalContent !== 'string') {
      throw new Error('Nội dung gốc không hợp lệ.');
    }
    
    let working = originalContent;
    if (mode === 'word' && options.range && options.range.from != null && options.range.to != null) {
      const kind = (options.range.type || options.granularity || 'auto');
      const clipped = __extractRangeWord(originalContent, kind, Number(options.range.from), Number(options.range.to));
      if (clipped) working = clipped;
    }
    
    const qs = __parseQuestions(working, mode, options);
    if (!qs.length) throw new Error('Không tìm thấy câu hỏi.');

    const limit = Math.min(Math.max(options.limit || qs.length, 1), qs.length);
    const throttleMs = Math.max(options.throttleMs || GEMINI_CONFIG.RATE_DELAY, 200);
    const skipTypes = Array.isArray(options.skipTypes) ? options.skipTypes : [];
    const stopAtTimeout = options.stopAtTimeout !== false;

    const out = [];
    const log = [];
    let ok = 0, fail = 0;
    const start = Date.now();

    for (let i = 0, produced = 0; i < qs.length && produced < limit; i++) {
      const q = qs[i];
      const idx = produced + 1;
      if (skipTypes.includes(q.type)) { log.push(`⏭️ Skip type ${q.type} @${i + 1}`); continue; }
      if (__isTimeUp(start, 300000)) { log.push(`⏰ Sắp quá thời gian, dừng tại ${idx}/${limit}`); if (stopAtTimeout) break; }

      try {
        const sanitized = __sanitizeQuestion(q, mode);
        const prompt = __buildPerQuestionPrompt(sanitized, mode, idx);
        const text = __geminiGenerate({
          model: GEMINI_CONFIG.MODELS.SIMILAR,
          prompt,
          temperature: GEMINI_CONFIG.GENERATION.SIMILAR.temperature,
          topK: GEMINI_CONFIG.GENERATION.SIMILAR.topK,
          topP: GEMINI_CONFIG.GENERATION.SIMILAR.topP,
          maxOutputTokens: Math.min(GEMINI_CONFIG.GENERATION.SIMILAR.maxOutputTokens, 4096)
        });
        out.push(__postProcessSimilar(text, mode, idx));
        ok++; produced++;
        if (produced < limit) Utilities.sleep(throttleMs + Math.floor(Math.random()*200));
      } catch (e) {
        out.push(__createFallbackSimilar(q, mode, idx));
        log.push(`⚠️ Câu ${idx} fallback: ${e.message}`);
        fail++; produced++;
      }
    }

    const combined = __combineSimilarQuestions(out, mode);
    return {
      success: true,
      result: {
        original: originalContent,
        similar: combined,
        comparison: {
          original_questions: qs.length,
          similar_questions: out.length,
          success_count: ok,
          error_count: fail,
          mode,
          strategy: 'batch',
          theme: 'ocean'
        }
      },
      metadata: {
        processing_mode: mode,
        generation_model: GEMINI_CONFIG.MODELS.SIMILAR,
        batch_processing: true,
        theme: 'ocean',
        timestamp: new Date().toISOString()
      }
    };
  } catch (error) {
    return { success: false, error: error.message || 'Lỗi batch similar.' };
  }
}

/* ========================= HELPER FUNCTIONS ========================= */
function formatTextOutput(textContent, totalPages, mode) {
  const hdr =
`PDF/Image to Text — Hybrid AI (Mistral OCR + Gemini Similar)
Generated: ${new Date().toLocaleString('vi-VN')}
Pages: ${totalPages}
OCR Engine: Mistral AI (${MISTRAL_CONFIG.OCR_MODEL})
Similar Generator: Gemini AI (${GEMINI_CONFIG.MODELS.SIMILAR})
Format: Plain text (no LaTeX formatting)

========================================

`;
  return hdr + (textContent || '').trim();
}

function __parseQuestions(content, mode, options = {}) {
  const a = [];
  try {
    if (mode === 'latex') {
      const re = /\\begin\{(?:ex\*?|bt\*?|vd\*?)\}(?:\[[^\]]*\])?([\s\S]*?)\\end\{(?:ex\*?|bt\*?|vd\*?)\}/g;
      let m;
      while ((m = re.exec(content)) !== null) {
        const inner = (m[1] || '').trim();
        const full = m[0].trim();
        if (inner) {
          const envMatch = /\\begin\{(ex\*?|bt\*?|vd\*?)\}/.exec(full);
          const env = envMatch ? envMatch[1] : 'ex';
          a.push({ type: env.replace('*',''), content: full, inner });
        }
      }
      if (!a.length) {
        const parts = content.split(/(?=\\begin\{ex)/);
        if (parts.length > 1) parts.forEach(p => { const seg = p.trim(); if (seg) a.push({ type: 'ex', content: seg, inner: seg }); });
      }
    } else {
      const kind = (options.granularity || __detectGranularity(content));
      __parseWordTopLevel(content, kind).forEach(it => a.push(it));
    }
    return a;
  } catch {
    return [{ type: mode === 'latex' ? 'ex' : 'question', content: content.trim() }];
  }
}

function __detectGranularity(content) {
  const cau = (content.match(/^\s*(?:Câu|CÂU)\s*\d+/gmi) || []).length;
  const bai = (content.match(/^\s*(?:Bài|BÀI)\s*\d+/gmi) || []).length;
  if (cau === 0 && bai === 0) return 'cau';
  return (cau >= bai) ? 'cau' : 'bai';
}

function __parseWordTopLevel(content, kind) {
  const lines = String(content || '').split(/\r?\n/);
  const items = [];
  let cur = '', num = null;
  const reStart = kind === 'bai'
    ? /^\s*(?:Bài|BÀI)\s*(\d+)\s*([\.\-:–—\)])?/i
    : /^\s*(?:Câu|CÂU)\s*(\d+)\s*([\.\-:–—\)])?/i;
  for (let i = 0; i < lines.length; i++) {
    const line = lines[i], m = reStart.exec(line);
    if (m) { if (cur.trim()) items.push({ type: kind === 'bai' ? 'problem' : 'question', index: num, content: cur.trim() }); cur = line.trim(); num = Number(m[1]); continue; }
    cur += (cur ? '\n' : '') + line;
  }
  if (cur.trim()) items.push({ type: kind === 'bai' ? 'problem' : 'question', index: num, content: cur.trim() });
  return items;
}

function __extractRangeWord(content, kind = 'auto', from = 1, to = 1) {
  const g = kind === 'auto' ? __detectGranularity(content) : kind;
  const items = __parseWordTopLevel(content, g).filter(it => typeof it.index === 'number' && it.index >= from && it.index <= to);
  return items.length ? items.map(it => it.content).join('\n\n') : '';
}

function __sanitizeQuestion(q, mode) {
  const cleaned = { ...q };
  try {
    let s = q.content || '';
    if (mode === 'latex') {
      s = s.replace(/\\loigiai\{[^{}]*(?:\{[^{}]*\}[^{}]*)*\}/g, '');
      s = s.replace(/\\includegraphics[^{}]*\{[^}]*\}/g, '');
      s = s.replace(/\\begin\{figure\}[\s\S]*?\\end\{figure\}/g, '');
      s = s.replace(/^%.*$/gm, '');
      s = s.replace(/\n\s*\n\s*\n/g, '\n\n');
    } else {
      s = s.replace(/\[Hình.*?\]/g, '').replace(/\(Hình.*?\)/g, '').replace(/\s+/g, ' ').trim();
    }
    cleaned.content = s;
    return cleaned;
  } catch { return q; }
}

function __tightenText(s, mode) {
  if (!s) return '';
  if (mode === 'latex') {
    return s
      .replace(/^\s*%.*$/gm, '')
      .replace(/\\loigiai\{[\s\S]*?\}/g, '')
      .replace(/\\begin\{figure\}[\s\S]*?\\end\{figure\}/g, '')
      .replace(/\\includegraphics[^{}]*\{[^}]*\}/g, '')
      .replace(/[ \t]+\n/g, '\n')
      .replace(/\n{3,}/g, '\n\n')
      .trim();
  }
  return s.replace(/\s+/g, ' ').trim();
}

function __buildPerQuestionPrompt(q, mode, idx) {
  const oceanPrefix = 'Ocean AI Assistant - ';
  if (mode === 'latex') {
    return `${oceanPrefix}Sinh 1 câu tương tự theo ex_test (không \\loigiai), CHỈ in LaTeX hoàn chỉnh:\n\nCÂU GỐC:\n${q.content}\n\nBẮT ĐẦU:`;
  }
  return `${oceanPrefix}Sinh 1 câu tương tự giữ định dạng Word (công thức $...$), CHỈ in câu, bắt đầu bằng "Câu ${idx}:", không lời giải:\n\nCÂU GỐC:\n${q.content}\n\nBẮT ĐẦU:`;
}

function __extractSimilarBlocks(resp, targetCount) {
  if (!resp) return [];
  const start = resp.indexOf('===BEGIN_SIMILAR===');
  const end = resp.lastIndexOf('===END_SIMILAR===');
  const body = (start !== -1 && end !== -1 && end > start)
    ? resp.substring(start + '===BEGIN_SIMILAR==='.length, end).trim()
    : resp.trim();
  const rawBlocks = body.split(/^\s*---END_QUESTION---\s*$/gmi).map(s => s.trim()).filter(Boolean);
  
  if (!rawBlocks.length) {
    const approx = body.split(/\n(?=Câu\s+\d+\s*[:\.\-])/i);
    if (approx.length > 1) return approx.map(s => s.trim()).filter(Boolean);
    const exsplit = body.split(/(?=\\begin\{ex)/);
    if (exsplit.length > 1) return exsplit.map(s => s.trim()).filter(Boolean);
    return [body];
  }
  
  return rawBlocks.slice(0, Math.max(targetCount, rawBlocks.length));
}

function __postProcessSimilar(text, mode, idx) {
  return text.trim();
}

function __createFallbackSimilar(q, mode, idx) {
  const fallbackPrefix = mode === 'latex' ? '% Ocean Fallback' : 'Ocean Fallback';
  return `${fallbackPrefix}\n${q.content}`;
}

function __combineSimilarQuestions(questions, mode) {
  const header = mode === 'latex' 
    ? '% Ocean Similar Generator - Batch Mode\n'
    : 'BÀI TẬP TƯƠNG TỰ - OCEAN GENERATOR (Batch)\n' + '='.repeat(48) + '\n\n';
  
  return header + questions.join('\n\n');
}

function getWordOCRPrompt() {
  return `Bạn là trợ lý OCR chuyên nghiệp. Hãy trích xuất CHÍNH XÁC TẤT CẢ văn bản từ ảnh này.

QUY TẮC QUAN TRỌNG:
- Giữ NGUYÊN tất cả xuống dòng và định dạng đoạn văn
- Với bảng biểu: sử dụng định dạng markdown nếu có thể
- Với công thức toán học: Viết dưới dạng văn bản thuần túy đơn giản (VD: x^2, sqrt(x), f(x) = 2x + 1, 1/2, a + b = c)
- KHÔNG sử dụng LaTeX ($...$, $$...$$, \\frac, \\sqrt, v.v.)
- KHÔNG thêm bất kỳ ký hiệu đặc biệt hay format LaTeX
- Chỉ trả về văn bản thuần túy, dễ đọc

Bắt đầu trích xuất:`;
}

function getRawOCRPrompt() {
  return `Trích xuất TẤT CẢ văn bản từ ảnh này CHÍNH XÁC như trong ảnh.

QUY TẮC:
- Giữ nguyên xuống dòng và cấu trúc
- Công thức toán: viết dưới dạng văn bản thuần túy đơn giản (x^2, f(x), sqrt, 1/2, a + b, etc)
- KHÔNG dùng LaTeX hay ký hiệu đặc biệt
- Chỉ văn bản thuần túy

Văn bản:`;
}

function getExTestTransformPrompt(includeSolutions = false) {
  return `Ocean AI LaTeX Assistant
Bạn là một chuyên gia biên soạn đề theo LaTeX gói ex_test.
NHIỆM VỤ: Chuyển đổi văn bản OCR thành LaTeX theo đúng cấu trúc ex_test, KHÔNG thay đổi nội dung gốc, KHÔNG bịa thêm.

QUY TẮC CHUNG:
- Mỗi câu hỏi bọc trong:
\\begin{ex}
[Phần nội dung]
[Khối đáp án tuỳ loại câu hỏi]
${includeSolutions ? '\\loigiai{[Lời giải ngắn gọn, nếu và chỉ nếu văn bản OCR đã có sẵn lời giải hoặc được yêu cầu thêm]}' : '% Không thêm \\loigiai nếu không có trong văn bản'}
\\end{ex}

- Không được tự suy đoán đáp án đúng. Nếu văn bản gốc chỉ có "A., B., C., D." thì giữ nguyên nội dung đó (chỉ chuyển cấu trúc).
- Ký hiệu toán học (≥, ≤, ∈, …) phải là LaTeX (\\ge, \\le, \\in, …). Giữ $...$ của công thức.

PHÂN LOẠI & CẤU TRÚC:
1) Trắc nghiệm (Multiple choice: có các phương án A., B., C., D.):
   Sử dụng:
   \\choice
   {[Phương án A]}
   {[Phương án B]}
   {[Phương án C]}
   {[Phương án D]}

2) Đúng/Sai (True/False: a), b), c), d) hoặc có từ "Đúng/Sai"):
   Sử dụng:
   \\choiceTF[t]
   {[Mệnh đề 1]}
   {[Mệnh đề 2]}
   {[Mệnh đề 3 (nếu có)]}
   {[Mệnh đề 4 (nếu có)]}
   * Nếu số mệnh đề != 4, chỉ đưa đúng số mệnh đề thu được (2–4). Không bịa thêm.

3) Trả lời ngắn (Short Answer): dùng \\shortans{} khi phù hợp.
4) Tự luận: chỉ \\begin{ex} ... \\end{ex}.

RÀNG BUỘC:
- Tách câu theo chỉ báo như "Câu x.", "Bài x.", hoặc ngắt đoạn hợp lý.
- Không thêm/bớt dữ kiện; không sửa số liệu.
- Không thêm \\True, không đánh dấu đáp án.
- Nếu văn bản gốc CÓ lời giải/đáp án, cho vào \\loigiai{...}; nếu KHÔNG, thì bỏ qua.

ĐẦU VÀO (OCR):
<<<OCR_TEXT>>>

Hãy trả về CHỈ LaTeX ex_test hợp lệ, không bao thêm bình luận.`;
}

function __ocrImageToWordText(base64, mime = 'image/png') {
  // Using Mistral AI for OCR
  return __mistralOCR(base64, getWordOCRPrompt());
}

function __ocrImageRaw(base64, mime = 'image/png') {
  // Using Mistral AI for OCR
  return __mistralOCR(base64, getRawOCRPrompt());
}

function __transformTextToExTest(ocrText, { includeSolutions = false } = {}) {
  if (typeof ocrText !== 'string' || ocrText.trim().length < 2) throw new Error('OCR trống.');
  const prompt = getExTestTransformPrompt(includeSolutions).replace('<<<OCR_TEXT>>>', ocrText.trim());
  return __geminiGenerate({
    model: GEMINI_CONFIG.MODELS.TRANSFORM,
    prompt,
    temperature: GEMINI_CONFIG.GENERATION.TRANSFORM.temperature,
    topK: GEMINI_CONFIG.GENERATION.TRANSFORM.topK,
    topP: GEMINI_CONFIG.GENERATION.TRANSFORM.topP,
    maxOutputTokens: GEMINI_CONFIG.GENERATION.TRANSFORM.maxOutputTokens
  });
}

function escapeHtml_(s) {
  return String(s || '').replace(/&/g,'&amp;').replace(/</g,'&lt;').replace(/>/g,'&gt;').replace(/"/g,'&quot;');
}

function __splitDataUrl(input) {
  if (!input) return { data: '', mime: 'image/png' };
  if (input.startsWith('data:')) {
    const comma = input.indexOf(','), header = input.substring(5, comma);
    const mime = (header.split(';')[0] || 'image/png'); const data = input.substring(comma + 1);
    return { data, mime };
  }
  return { data: input, mime: 'image/png' };
}

function __isTimeUp(startTime, threshold = 300000) {
  return (Date.now() - startTime) >= threshold;
}

console.log('🚀 PDF to Text & Similar Problem Generator v8.2-Hybrid');
console.log('✅ OCR Engine: Mistral AI (' + MISTRAL_CONFIG.OCR_MODEL + ')');
console.log('✅ Similar Generator: Gemini AI (' + GEMINI_CONFIG.MODELS.SIMILAR + ')');
console.log('✅ Multi-API Key Rotation: ENABLED');
console.log('✅ Smart Performance Tracking: ENABLED'); 
console.log('✅ Automatic Key Blacklisting: ENABLED');
console.log('🔧 Configure Gemini keys: setGeminiApiKeys("key1,key2,key3")');
console.log('📊 Check status: getApiKeyStatus()');
