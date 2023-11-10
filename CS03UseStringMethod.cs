using static System.Console;

namespace CSharpStudy
{
    /// <summary>
    /// How to user String method in C#
    /// </summary>
    public class CS03UseStringMethod
    {
        
        //declare and initialize string
        private string text1 = "My nickname is jeire";
        private string text2 = new string('A', 3);

        /// <summary>
        /// If you want to use all methods in class CS03UseStringMethod
        /// </summary>
        public void UseAllMethod()
        {
            PrintString();
            Concatenate();
            SplitString();
            SearchString();
            ReplaceString();
            ConversionWithParse();
            IsEqualString();
            CompareTwoStrings();
            FormattingString();
        }

        /// <summary>
        /// How to display string on console with WriteLine()
        /// </summary>
        public void PrintString()
        {
            WriteLine(text1);
            WriteLine(text2);
        }

        /// <summary>
        /// How to combine two strings.
        /// </summary>
        public void Concatenate()
        {
            // concatenate
            string concatText1 = text1 + text2;

            // another concatenate
            string concatText2 = text1;
            concatText2 += text2;

            // the results are same
            WriteLine(concatText1);
            WriteLine(concatText2);
        }

        /// <summary>
        /// How to split a string using a specific character.
        /// </summary>
        public void SplitString()
        {
            string originText1 = "My nickname is jeire";

            //split with space, Split makes array or strings
            string[] words = originText1.Split(' ');

            for (int i = 0; i < (words.Length); i++)
            {
                Write(words[i] + ", ");
            }
            WriteLine();
        }

        /// <summary>
        /// How to locate a specific substring within a string.
        /// </summary>
        public void SearchString()
        {
            //search
            int index = text1.IndexOf("jeire");

            WriteLine(index);
            WriteLine();
        }

        /// <summary>
        /// How to modify a specific substring within a string.
        /// </summary>
        public void ReplaceString()
        {
            string text3 = "My nickname is jeire";

            //Replace
            text3 = text3.Replace("jeire", "KO5KI");
            WriteLine(text3);

            WriteLine();
        }

        /// <summary>
        /// How to use Parse() to convert string to int type.
        /// </summary>
        public void ConversionWithParse()
        {
            //type conversion with Parse
            string numText1 = "11235813";
            int numT = int.Parse(numText1);

            WriteLine(numT.GetType().Name);
            WriteLine(numT);
            WriteLine();
        }

        /// <summary>
        /// How to check if two strings are equal.
        /// </summary>
        public void IsEqualString()
        {
            bool isEqaulText = text1 == text2;

            if (isEqaulText)
            {
                WriteLine("True");
            }
            else
            {
                WriteLine("False");
            }
            WriteLine();
        }

        /// <summary>
        /// How to compare the priority or precedence of two strings.
        /// </summary>
        public void CompareTwoStrings()
        {
            //which one is greater?
            WriteLine(string.Compare("ABC", "ABD"));
            WriteLine(string.Compare("abc", "ABD"));
            WriteLine(string.Compare("ABC", "aBC"));

            WriteLine();
        }

        /// <summary>
        /// how to use Format() and Interpolation
        /// </summary>
        public void FormattingString()
        {
            //string format
            string name = "jeire";
            int year = 2023;
            string formT = string.Format("{0} is live in {1} year", name, year);
            WriteLine(formT);
            WriteLine();

            //string interpolation
            string interText = $"{name} is live in {year} year";
            WriteLine(interText);
        }
    }
}
