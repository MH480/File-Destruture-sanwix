
namespace File_Destruture_sanwix.MessUps
{
    public class HtmlWaper
    {
        const string HeadPattern = @"^[\s\n\t\r]*<[Hh]ead[^>]*>[\s\S]*<\/[Hh]ead>[\s\n\t\r]*$";
        const string ScriptPattern = @"^[\s\n\t\r]*<script[^>]*>[\s\S]*<\/script>[\s\n\t\r]*$";
        const string LinkPattern = @"^[\s\n\t\r]*<link[^>]* [\s\S]* [\/]?>[\s\n\t\r]*$";
        public HtmlWaper()
        {
            
        }
    }
}

