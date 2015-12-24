using System;

namespace LearnWordsFast.DAL.Models
{
    public class Translation : IdModel
    {
        public Language Language { get; set; }
        public Guid LanguageId { get; set; }
        public string TranslationText { get; set; }
    }
}