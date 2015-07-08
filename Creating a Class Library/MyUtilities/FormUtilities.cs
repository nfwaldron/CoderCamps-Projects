using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUtilities
{
    public class FormUtilities
    {
            public string CleanInput(string input)
            {
                return input.Trim().ToLowerInvariant();
            }
        
    }
}
