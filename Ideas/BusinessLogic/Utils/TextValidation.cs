
using System.Text.RegularExpressions;

namespace BusinessLogic.Utils
{
    public static class TextValidation
    {
        public static bool ContainsHtmlOrJavascript(string text)
        {
            // Check for HTML tags or attribute
            if (Regex.IsMatch(text, "<.*?>|<.*?\\s.*?>|&[a-z]*;|<script.*?>|</script>", RegexOptions.IgnoreCase))
            {
                return true;
            }

            // Check for JavaScript code
            if (Regex.IsMatch(text, @"(alert|onclick|onload)\s*\("))
            {
                return true;
            }

            return false;
        }

    }
}
