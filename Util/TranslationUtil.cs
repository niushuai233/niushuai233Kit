using Google.Cloud.Translation.V2;
using niushuai233Kit.Entity.Settings;
using niushuai233Kit.Entity.Translation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace niushuai233Kit.Util
{
    public class TranslationUtil
    {
        public static TranslationSettings settings = new TranslationSettings();

        /// <summary>
        /// Google 翻译
        /// </summary>
        /// <param name="source">待翻译文本</param>
        /// <param name="specifiedSourceLanguage">源语言</param>
        /// <param name="targetLanguage">目标语言</param>
        /// <returns>封装好的翻译结果</returns>
        public static TranslationResponse GoogleTranslate(string source, string targetLanguage, string specifiedSourceLanguage = null)
        {
            TranslationResponse response;

            if (settings == null || StringUtil.IsEmpty(settings.GoogleApiKey))
            {
                return response = new TranslationResponse() { 
                    Success = false,
                    ErrorMessage = "请先设置 Google ApiKey"
                };
            }

            try
            {
                TranslationClient client = TranslationClient.CreateFromApiKey(settings.GoogleApiKey);
                TranslationResult result = client.TranslateText(source, targetLanguage, specifiedSourceLanguage);

                return response = new TranslationResponse()
                {
                    Success = true,
                    OriginalText = source,
                    TranslatedText = result.TranslatedText,
                    DetectedSourceLanguage = result.DetectedSourceLanguage,
                    SpecifiedSourceLanguage = result.SpecifiedSourceLanguage,
                    TargetLanguage = result.TargetLanguage
                };
            }
            catch (Exception e)
            {
                return response = new TranslationResponse()
                {

                    Success = false,
                    ErrorMessage = e.Message
                };
            }

        }
    }
}
