using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Create Bitmap
            // Must add reference for assembly -- System.Drawing
            // When we create an object of anyt class that uses the IDisposable interface, we must use the using keyword
            // Within the using () we create our resource.
            // The Bitmap objet bitmap only works within the using {}. At the end of the {}'s the object will be disposed.

            // Usually, you allow the .Net Framework takes care of garbage collection.
            // The using(){} pretty much acts as an automatic garbage disposer in instances where you are depending on external resources.
            
            using (var bitmap = new Bitmap(500, 500))
            {

                // Randomly set 1000 pixels
                var rnd = new Random();
                for (var i = 0; i < 1000; i++)
                {
                    bitmap.SetPixel(rnd.Next(500), rnd.Next(500), Color.Red);
                }

                // Save bitmap to current directory (debug directory)
                var currentDirectory = Environment.CurrentDirectory;

                var path = Path.Combine(currentDirectory, "MyImage.png");

                bitmap.Save(path, ImageFormat.Png);
            }
        }
    }
}
