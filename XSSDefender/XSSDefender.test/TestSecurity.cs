using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace XSSDefender.test
{
    [TestClass]
    public class TestSecurity
    {
        [TestMethod]
        public void SanitizeHTMLTest()
        {
            // Arrange - Create an instance of any class that you need to test
            var htmlSanitizer = new Security();

            // Act - Use this section to perform the action that you are testing. Typically, you call a method in this section.
            
            var htmlStr = "<b>hello</b><Script>evil</Script>"; // Initialize string variable with string content
            var result = htmlSanitizer.SanitizeHTML(htmlStr); // Run test method to ensure proper functioning
            
            // Assert - Use this section to assert that a certain condition is true.

            // Assert.AreNotEqual(result, "<b>hello</b>&lt;script&gt;evil&lt/script&gt;");
            // Assert.AreEqual(result, "<b>hello</b>&lt;script&gt;evil&lt/script&gt;");


        }
    }
}
