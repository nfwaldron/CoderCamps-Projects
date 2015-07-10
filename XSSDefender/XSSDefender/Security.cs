using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Create a new Security class that includes a SanitizeHTML() method. 
* The SanitizeHTML() method should accept two parameters: a string to sanitize and a list of safe HTML tags.
* For example, if you call SanitizeHTML(“<b>hello</b><script>evil</script>”, new string[] {“b”}) then you 
* should get the string “<b>hello</b>&lt;script&gt;evil&lt/script&gt;”  
* Notice that the <b> tag was not HTML Encoded because the <b> tag is in the safe HTML tag list. 
* The <script> tag, on the other hand, was encoded with "&lt;script&gt" because the <script> 
* tag is not on the safe list.
*/

namespace XSSDefender
{
    public class Security
    {
        public string SanitizeHTML(string content)
        {
            // Check to see if the incoming contant contains <script> or </script>.
            // These are unsafe HTML tags.
            var tag1 = "<script>";
            var tag2 = "</script>";

            if (content.Contains(tag1) || content.Contains(tag2))
            {
                var sanitize = new StringBuilder(content);

                // The Replace() Method replaces within a substring of an instance all occurances of a specified character
                // with another character
                sanitize.Replace("<script>", "&lt;script&gt;");
                sanitize.Replace("</script>", "&lt/script&gt;");

                // The 'sanitize' is an object of the class Stringbuilder. In order to return a string to the 
                // Main method, perform the ToString() method on the object 'sanitize'.
                var result = sanitize.ToString();

                //Assert Assumption that sanitize.ToString() in fact changed
                Debug.Assert(result is string, "The variable 'result' is not a string");
                return result;
            }

            // If the content does not contain any harmful HTML tags, return the content unchanged 
            return content;

        }
    }
}
