using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace niushuai233Kit.Entity.Translation
{
    public class TranslationResponse
    {

        public bool Success { get; set; }

        public string ErrorMessage { get; set; }

        public string OriginalText { get; set; }
        
        public string TranslatedText { get; set; }
       
        public string DetectedSourceLanguage { get; set; }
       
        public string SpecifiedSourceLanguage { get; set; }
     
        public string TargetLanguage { get; set; }
      
    }
}
