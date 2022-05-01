using Newtonsoft.Json;

namespace Translater.Model
{
    public class Rootobject
    {
        public Translation[] Translations { get; set; }
    }

    public class Translation
    {
        public string Text { get; set; }
        public string DetectedLanguageCode { get; set; }
    }
}
