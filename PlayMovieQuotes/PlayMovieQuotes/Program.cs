using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

/* Using the SoundPLayer() class, create a console application that randomly plays one of four soundclips.
 * Use the website www.wavsource.com*/


namespace PlayMovieQuotes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create variables that stores the URLs of the .wav files.
            var fargoYah = "http://www.wavsource.com/snds_2015-07-05_1837925197659629/movies/misc/fargo_yah.wav";
            var montyPython = "http://www.wavsource.com/snds_2015-07-05_1837925197659629/movies/monty_python_hg/wipers.wav";
            var montyPython2 = "http://www.wavsource.com/snds_2015-07-05_1837925197659629/movies/monty_python_hg/now_stand_aside.wav";
            var wizardOz = "http://www.wavsource.com/snds_2015-07-05_1837925197659629/movies/wizard/goin_in_there.wav";

            // Create an array to store the string variables that contain the URLs of the .wav files.
            var stringArray = new string [] { fargoYah, montyPython, montyPython2, wizardOz };

            // Create a new instance of the Random() object
            var rand = new Random();

            // Use the .Next method which returns a non-negative random integer that is less than the specified maximum. AKA n-1. 
            // Use .Next on the rand object, passing as a parameter the length of stringArray using .Length
            var i = rand.Next(stringArray.Length);

            // Create a new object of the SoundPlayer class.
            // The using statement syntax is implemented to ensure correct resource acquisition.
            // Create a new object of the class SoundPlayer(). 
            // The arguement passed to the object is the URL of the .wav file, which is stored in the array stringArray.
            // The variable 'i' stands for both a randomly generated number, and a reference to an index in the array.
            var player = new SoundPlayer(stringArray[i]);  
            
            player.PlaySync(); // Plays the .wav file and loads the .wav file first if it has not been loaded.
            
        }
    }
}
