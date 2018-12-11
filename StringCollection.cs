using System.Collections.Generic;
using System.Linq;

namespace Assessment.StringAssessment
{
    public class StringCollection : IStringCollection
    {
        internal List<string> StringList = new List<string>();

        public void AddString(string s)
        {
            StringList.Add(s);
        }

        public override string ToString()
        {
             string concatenatedString = "";

             concatenatedString = StringList.Aggregate((s, i) => s + ", " + i);

             //Or loop through the list to concatenate its properties

             //foreach (var item in StringList)
             //{
             //    //concatenatedString += item + ", ";
             //}

            return concatenatedString;
        }
    }
}