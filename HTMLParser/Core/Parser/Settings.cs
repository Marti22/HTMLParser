
namespace HTMLParser.Core.Parser
{
    class Settings : IParserSettings
    {

        public Settings(int start, int end)
        {
            StartPoint = start;
            EndPoint = end;
        }
        public string BaseUrl { get; set; } = "https://habrahabr.ru/";

        public int EndPoint { get; set; }

        public string Prefix { get; set; } = "page{CurrentId}";

        public int StartPoint { get; set; }
    }
}
