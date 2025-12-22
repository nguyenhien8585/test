/**
 * code.gs - PDF/Image → Text Converter + Similar Problem Generator
 * SIMPLIFIED OCEAN VERSION - Single API Key Location
 * 
 * v8.1-Simple (2025-01-26)
 * - SIMPLIFIED: Single API key configuration (easier to manage)
 * - Enhanced: Multi-API Key Rotation System  
 * - Improved: Better error handling and fallback
 * - Optimized: Performance and reliability
 */

/* ========================= SIMPLIFIED GEMINI CONFIG ========================= */
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
      "AIzaSyCN94-Mkws5Ip0YJYL9nl6QNLwXdW6HxPE",
      "AIzaSyBrjb43nQTzQoRQd35hw8dtam4gWu6Dbfs",
      "AIzaSyDfVeYlNOrrvpuEzJ9GJgctJEcABrF1U_0",
      "AIzaSyDWn6DwNcimrOetCYvQHR3IE5LFLWLFLNE",
      "AIzaSyAfUdBJGiq1XkrYPrWsdj4lGhtR_H-f5rk",
      "AIzaSyAVQjuf0haGsLEYRY-rUGl8zFfx-EDzHUs",
      "AIzaSyCgpc8xsReNC3LXYfSwmLPqsMZOHhFnFOU",
      "AIzaSyBYarkjC4_zBgzn0eh3m_d3COWOaeAB_ok",
      "AIzaSyA_y1NS86T263turtvGI1MGf05SMSsCE5M",
      "AIzaSyDUIhn3PvydKJxXbZn3NtjowHD6KYtm6cI",
      "AIzaSyCR8lxCX3VOS3uzughEdD_EV_s9DwD7jMw",
      "AIzaSyD2skUF0Aeua0fgxgGlDdHfrtsfA0XrTbg",
      "AIzaSyDaYQ-ClvjBo5cNMfICdFkOojKwfyaMco8",
      "AIzaSyDIG4_v8Et4OHdGbKzKHSmgq5hpJc7-dfU",
      "AIzaSyAVI13vJFora3sOPA1x-b2SWNIt_ujEXZI",
      "AIzaSyBhwQ6QAv3mXxivzwB_sQ3552waeEWSvto",
      "AIzaSyDtsmDqVsYotAh8ggh0ZMWzE651CKw8hUk",
      "AIzaSyBqSl_4UYXDZgWmC0_fxOw9UOPcKHt795g",
      "AIzaSyDFKmhBRK4FM2gA9wClKBnxGPzyVRStrF4",
      "AIzaSyALIjwOKZ-vmyD3arpsN-BeUFrYKi2Cjhk",
      "AIzaSyDU-V2vrkAnzGfvtBdVXT74FyTdpDG2ojg",
      "AIzaSyCn44XdE8Vi1O3xWvQiRKsuBaCPexSoDYo",
      "AIzaSyBLBC9nWH6JQERlgnR1fez3GNhqFXN6yeI",
      "AIzaSyDTm0FhL5k_1tIMBTO-KFX4kAvWfmji5LM",
      "AIzaSyDtavNqPc5BG8Bi_YrtYuohOMYW4LAZpK0",
      "AIzaSyDNzMZXkVrX8bBJB07FU7j18fMNWdNB-kM",
      "AIzaSyAdX1hJbDFlA5nwSjLJGovlLdQ9IQ_PNFY",
      "AIzaSyCddxcJFWjSSpXCn77OKt0G6fNxhZEvB_g",
      "AIzaSyCO2JgRieXQMUrI7r5lNN8PxraJ5aLTwxI",
      "AIzaSyBD7fPXZ93nIOTRW3HvD6RzVP8HfO_xNmc"
  ],
  
  // Models configuration
  MODELS: {
    OCR: 'gemini-3-flash-preview',
    TRANSFORM: 'gemini-3-flash-preview', 
    SIMILAR: 'gemini-3-flash-preview'
  },
  
  // Generation parameters
  GENERATION: {
    OCR: { temperature: 0.1, topK: 32, topP: 0.95, maxOutputTokens: 8192 },
    TRANSFORM: { temperature: 0.3, topK: 40, topP: 0.95, maxOutputTokens: 16384 },
    SIMILAR: { temperature: 0.7, topK: 64, topP: 0.95, maxOutputTokens: 65536 }
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
      .setTitle('Ocean PDF Converter + Similar Generator');
  } catch (error) {
    console.error('Error serving HTML:', error);
    return HtmlService.createHtmlOutput('<h1>Ocean PDF Converter</h1><p style="color:#ef4444">Error: ' + escapeHtml_(error.message) + '</p>');
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
        combined += `\n=== TRANG ${i + 1} ===\n` + __ocrImageToWordText(data, mime) + '\n';
      } catch (e) {
        combined += `\n=== TRANG ${i + 1} - LỖI: ${e && e.message} ===\n`;
      }
      if (i < pages.length - 1) Utilities.sleep(600);
    }
    
    if (!combined.trim()) throw new Error('OCR rỗng.');
    
    return {
      success: true,
      result: formatTextOutput(combined, pages.length),
      metadata: {
        total_pages: pages.length,
        model_ocr: GEMINI_CONFIG.MODELS.OCR,
        timestamp: new Date().toISOString(),
        theme: 'ocean'
      }
    };
  } catch (error) {
    return { success: false, error: error.message || 'PDF→Text lỗi.' };
  }
}

function processImageToText(dataUrlOrBase64, mode = 'word') {
  try {
    const { data, mime } = __splitDataUrl(dataUrlOrBase64);
    const out = __ocrImageToWordText(data, mime);
    
    return {
      success: true,
      result: out,
      metadata: {
        mode: 'word',
        model_ocr: GEMINI_CONFIG.MODELS.OCR,
        theme: 'ocean',
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
      console.log('🎯 Attempting single-shot generation...');
      const single = generateSimilarSingleShot(originalContent, mode, options);
      if (single?.success) {
        console.log('✅ Single-shot generation successful!');
        return single;
      }
    } catch (e) {
      console.warn('⚠️ Single-shot failed, falling back to batch mode');
      console.warn('Reason:', e && e.message);
    }
  }
  console.log('🔄 Using batch generation mode...');
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

    console.log(`📄 Processing content length: ${working.length} chars`);
    
    const parsed = __parseQuestions(working, mode, options);
    console.log(`✅ Found ${parsed.length} questions`);
    
    if (!parsed.length) {
      console.error('❌ No questions parsed from content');
      throw new Error('Không tìm thấy câu hỏi.');
    }
    
    const sanitizedList = parsed.map(q => __sanitizeQuestion(q, mode));
    const targetCount = sanitizedList.length;
    console.log(`🎯 Target count: ${targetCount} questions`);

    const compactBody = sanitizedList
      .map((q, idx) => `<<Q${idx + 1}>>\n${__tightenText(q.content, mode)}`)
      .join('\n\n');

    const questionList = sanitizedList.map((q, i) => `Q${i+1}`).join(', ');
    
    const instructions =
`BẠN LÀ CHUYÊN GIA BIÊN SOẠN ĐỀ THI - OCEAN AI

🎯 NHIỆM VỤ CỐT LÕI:
Tạo CHÍNH XÁC ${targetCount} câu hỏi tương tự (${questionList})
⚠️ QUAN TRỌNG: PHẢI ĐỦ ${targetCount} CÂU, THIẾU 1 CÂU LÀ THẤT BẠI!

📋 YÊU CẦU CHI TIẾT:
1. SỐ LƯỢNG: Bắt buộc ${targetCount} câu (Câu 1 → Câu ${targetCount})
2. GIỐNG: Dạng toán, độ khó, cấu trúc, loại câu hỏi
3. KHÁC: Số liệu, ngữ cảnh, tình huống cụ thể
4. CÔNG THỨC: Dùng $...$ cho toán (VD: $2x+3$, $\\sqrt{5}$, $\\frac{a}{b}$)
5. KHÔNG: Lời giải, đáp án đúng, chú thích thêm

✅ ĐỊNH DẠNG BẮT BUỘC (COPY CHÍNH XÁC):
===BEGIN_SIMILAR===
Câu 1: [Đề bài tương tự Q1]
A. [Đáp án]
B. [Đáp án]
C. [Đáp án]
D. [Đáp án]

---END_QUESTION---
Câu 2: [Đề bài tương tự Q2]
A. [Đáp án]
B. [Đáp án]
C. [Đáp án]
D. [Đáp án]

---END_QUESTION---
Câu 3: [Đề bài tương tự Q3]
[...]

---END_QUESTION---
[... TIẾP TỤC CHO ĐẾN ...]

---END_QUESTION---
Câu ${targetCount}: [Đề bài tương tự Q${targetCount}]
[Đáp án nếu có]

===END_SIMILAR===

📚 DỮ LIỆU GỐC (${targetCount} CÂU):
${compactBody}

🚀 BẮT ĐẦU TẠO ${targetCount} CÂU (NHỚ: PHẢI ĐỦ ${targetCount} CÂU!):`;

    console.log(`🚀 Sending to AI: ${targetCount} questions to generate`);
    
    let resp = __geminiGenerate({
      model: GEMINI_CONFIG.MODELS.SIMILAR,
      prompt: instructions,
      temperature: GEMINI_CONFIG.GENERATION.SIMILAR.temperature,
      topK: GEMINI_CONFIG.GENERATION.SIMILAR.topK,
      topP: GEMINI_CONFIG.GENERATION.SIMILAR.topP,
      maxOutputTokens: GEMINI_CONFIG.GENERATION.SIMILAR.maxOutputTokens
    });

    console.log(`📥 Received response: ${resp.length} chars`);
    console.log(`📄 Response preview: ${resp.substring(0, 500)}...`);
    
    let blocks = __extractSimilarBlocks(resp, targetCount);
    console.log(`✅ First attempt extracted: ${blocks.length}/${targetCount} questions`);
    
    // RETRY nếu thiếu câu (tối đa 2 lần retry)
    let retryCount = 0;
    const maxRetries = 2;
    
    while (blocks.length < targetCount && retryCount < maxRetries) {
      retryCount++;
      console.warn(`⚠️ Retry ${retryCount}/${maxRetries}: Only got ${blocks.length}/${targetCount} questions`);
      
      const missingCount = targetCount - blocks.length;
      const retryPrompt = `BẠN ĐANG BỊ THIẾU ${missingCount} CÂU!

YÊU CẦU: Tạo lại CHÍNH XÁC ${targetCount} câu (từ Câu 1 đến Câu ${targetCount}).
Format: Mỗi câu phải có "---END_QUESTION---" ở cuối.

${targetCount} CÂU GỐC:
${compactBody}

TẠO LẠI NGAY ${targetCount} CÂU (KHÔNG ĐƯỢC THIẾU):`;
      
      resp = __geminiGenerate({
        model: GEMINI_CONFIG.MODELS.SIMILAR,
        prompt: retryPrompt,
        temperature: 0.8,
        topK: 64,
        topP: 0.95,
        maxOutputTokens: GEMINI_CONFIG.GENERATION.SIMILAR.maxOutputTokens
      });
      
      blocks = __extractSimilarBlocks(resp, targetCount);
      console.log(`🔄 Retry ${retryCount} result: ${blocks.length}/${targetCount} questions`);
    }
    
    // Kiểm tra kết quả cuối cùng
    if (blocks.length < targetCount) {
      console.error(`❌ FAILED: Only generated ${blocks.length}/${targetCount} questions after ${retryCount} retries`);
      console.warn(`⚠️ Falling back to batch mode...`);
      // Throw error để fallback sang batch mode
      throw new Error(`Single-shot failed: ${blocks.length}/${targetCount} questions generated`);
    } else if (blocks.length > targetCount) {
      console.log(`✅ Generated ${blocks.length} questions (expected ${targetCount}) - will trim`);
      blocks = blocks.slice(0, targetCount);
    } else {
      console.log(`✅✅✅ PERFECT! Generated exactly ${targetCount} questions!`);
    }
    
    const similarCombined = 'BÀI TẬP TƯƠNG TỰ - OCEAN GENERATOR\n' + '='.repeat(48) + '\n\n' + blocks.join('\n\n');

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
function formatTextOutput(textContent, totalPages) {
  const hdr =
`Ocean PDF/Image → Word Format (with $…$) — Enhanced Gemini
Generated: ${new Date().toLocaleString('vi-VN')}
Pages: ${totalPages}
OCR Model: ${GEMINI_CONFIG.MODELS.OCR}
Theme: Ocean Blue

========================================

`;
  return hdr + (textContent || '').trim();
}

function __parseQuestions(content, mode, options = {}) {
  const a = [];
  try {
    const kind = (options.granularity || __detectGranularity(content));
    __parseWordTopLevel(content, kind).forEach(it => a.push(it));
    return a;
  } catch {
    return [{ type: 'question', content: content.trim() }];
  }
}

function __detectGranularity(content) {
  const cau = (content.match(/^\s*(?:Câu|CÂU)\s*\d+/gmi) || []).length;
  const bai = (content.match(/^\s*(?:Bài|BÀI)\s*\d+/gmi) || []).length;
  
  console.log(`🔍 Detected: ${cau} câu, ${bai} bài`);
  
  if (cau === 0 && bai === 0) {
    console.log('⚠️ No structured questions found, defaulting to "cau" mode');
    return 'cau';
  }
  
  const result = (cau >= bai) ? 'cau' : 'bai';
  console.log(`📊 Granularity selected: ${result}`);
  return result;
}

function __parseWordTopLevel(content, kind) {
  const lines = String(content || '').split(/\r?\n/);
  const items = [];
  let cur = '', num = null;
  const reStart = kind === 'bai'
    ? /^\s*(?:Bài|BÀI)\s*(\d+)\s*([\.\-:–—\)])?/i
    : /^\s*(?:Câu|CÂU)\s*(\d+)\s*([\.\-:–—\)])?/i;
  
  for (let i = 0; i < lines.length; i++) {
    const line = lines[i];
    const m = reStart.exec(line);
    
    if (m) {
      // Tìm thấy câu mới, lưu câu trước
      if (cur.trim()) {
        items.push({ 
          type: kind === 'bai' ? 'problem' : 'question', 
          index: num, 
          content: cur.trim() 
        });
      }
      cur = line.trim();
      num = Number(m[1]);
    } else {
      // Nối dòng vào câu hiện tại
      cur += (cur ? '\n' : '') + line;
    }
  }
  
  // Lưu câu cuối cùng
  if (cur.trim()) {
    items.push({ 
      type: kind === 'bai' ? 'problem' : 'question', 
      index: num, 
      content: cur.trim() 
    });
  }
  
  console.log(`📋 Parsed ${items.length} items in ${kind} mode`);
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
    s = s.replace(/\[Hình.*?\]/g, '').replace(/\(Hình.*?\)/g, '').replace(/\s+/g, ' ').trim();
    cleaned.content = s;
    return cleaned;
  } catch { return q; }
}

function __tightenText(s, mode) {
  if (!s) return '';
  return s.replace(/\s+/g, ' ').trim();
}

function __buildPerQuestionPrompt(q, mode, idx) {
  const oceanPrefix = 'Ocean AI Assistant - ';
  return `${oceanPrefix}Sinh 1 câu tương tự giữ định dạng Word (công thức $...$), CHỈ in câu, bắt đầu bằng "Câu ${idx}:", không lời giải:\n\nCÂU GỐC:\n${q.content}\n\nBẮT ĐẦU:`;
}

function __extractSimilarBlocks(resp, targetCount) {
  if (!resp) return [];
  
  // Bước 1: Tìm và trích xuất phần nội dung giữa markers
  const start = resp.indexOf('===BEGIN_SIMILAR===');
  const end = resp.lastIndexOf('===END_SIMILAR===');
  let body = (start !== -1 && end !== -1 && end > start)
    ? resp.substring(start + '===BEGIN_SIMILAR==='.length, end).trim()
    : resp.trim();
  
  // Bước 2: Thử tách theo marker ---END_QUESTION---
  let rawBlocks = body.split(/---END_QUESTION---/gi).map(s => s.trim()).filter(Boolean);
  console.log(`📝 Step 2 - Split by marker: ${rawBlocks.length} blocks`);
  
  // Bước 3: Nếu không có marker, thử tách theo "Câu X:"
  if (rawBlocks.length < 2) {
    // Thử tách theo pattern "Câu [số]:" hoặc "Câu [số]."
    const byQuestion = body.split(/(?=(?:^|\n)\s*(?:Câu|CÂU)\s+\d+\s*[:\.\-])/i);
    rawBlocks = byQuestion.map(s => s.trim()).filter(Boolean);
    console.log(`📝 Step 3 - Split by 'Câu X:': ${rawBlocks.length} blocks`);
  }
  
  // Bước 4: Nếu vẫn chỉ có 1 block, thử tách theo xuống dòng 2 lần
  if (rawBlocks.length < 2) {
    const byParagraph = body.split(/\n\s*\n+/);
    console.log(`📝 Step 4 - Split by double newline: ${byParagraph.length} paragraphs`);
    
    if (byParagraph.length > 1) {
      // Gộp lại các đoạn nhỏ thành câu hỏi hoàn chỉnh
      rawBlocks = [];
      let current = '';
      for (let para of byParagraph) {
        para = para.trim();
        if (!para) continue;
        
        // Nếu đoạn bắt đầu bằng "Câu X:", bắt đầu câu hỏi mới
        if (/^(?:Câu|CÂU)\s+\d+\s*[:\.\-]/i.test(para)) {
          if (current) rawBlocks.push(current.trim());
          current = para;
        } else {
          current += (current ? '\n\n' : '') + para;
        }
      }
      if (current) rawBlocks.push(current.trim());
      console.log(`📝 Step 4 - Regrouped into: ${rawBlocks.length} questions`);
    }
  }
  
  // Bước 5: Nếu không tách được, trả về toàn bộ
  if (rawBlocks.length < 1) {
    console.warn('⚠️ Could not split response, returning as single block');
    rawBlocks = [body];
  }
  
  // Bước 6: Lọc và giới hạn số lượng
  const filtered = rawBlocks.filter(s => s && s.length > 10);
  
  console.log(`📊 Extracted ${filtered.length} blocks from response (target: ${targetCount})`);
  
  if (filtered.length < targetCount) {
    console.warn(`⚠️ WARNING: Only found ${filtered.length} questions, expected ${targetCount}`);
  }
  
  // Trả về tất cả câu tìm được (không giới hạn)
  return filtered;
}

function __postProcessSimilar(text, mode, idx) {
  return text.trim();
}

function __createFallbackSimilar(q, mode, idx) {
  return `Ocean Fallback\n${q.content}`;
}

function __combineSimilarQuestions(questions, mode) {
  const header = 'BÀI TẬP TƯƠNG TỰ - OCEAN GENERATOR (Batch)\n' + '='.repeat(48) + '\n\n';
  return header + questions.join('\n\n');
}

function getWordOCRPrompt() {
  return `Ocean AI OCR Assistant
Gõ lại CHÍNH XÁC nội dung trong ảnh.
- Giữ xuống dòng tự nhiên; không thêm thuyết minh.
- Bảng có thể dùng markdown nếu nhận diện được.
- Toán học: [BẮT BUỘC] tất cả công thức viết dưới dạng Latex bọc $...$ hoặc $$...$$ theo bố cục.
Chỉ trả về văn bản OCR (kèm công thức đã bọc).`;
}


function __ocrImageToWordText(base64, mime = 'image/png') {
  return __geminiGenerate({
    model: GEMINI_CONFIG.MODELS.OCR,
    prompt: getWordOCRPrompt(),
    imageBase64: base64,
    imageMime: mime,
    temperature: GEMINI_CONFIG.GENERATION.OCR.temperature,
    topK: GEMINI_CONFIG.GENERATION.OCR.topK,
    topP: GEMINI_CONFIG.GENERATION.OCR.topP,
    maxOutputTokens: GEMINI_CONFIG.GENERATION.OCR.maxOutputTokens
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

console.log('Ocean Enhanced PDF Converter v8.1-Simple - Word Mode Only');
console.log('✅ Word format with $...$ for formulas');
console.log('✅ Multi-API Key Rotation System: ENABLED');
console.log('✅ Smart Performance Tracking: ENABLED'); 
console.log('✅ Automatic Key Blacklisting: ENABLED');
console.log('🔧 Configure keys: setGeminiApiKeys("key1,key2,key3")');
console.log('📊 Check status: getApiKeyStatus()');
