using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExampleApplication
{
    public class StringUtilities
    {
        public string combineArrayStringWithDelimiter(string[] stringArray, string delimiter)
        {
            string str = default(string);
            foreach (string item in stringArray)
            {
                str += item + delimiter;
          
           
            }
            return str.TrimEnd();
        }
        
        public string replaceSpacesInStringByHyphens(string aString)
        {
            string[] stringArray = aString.Split(null);
            return combineArrayStringWithDelimiter(stringArray, "-").TrimEnd('-');
        } 
    }

}
