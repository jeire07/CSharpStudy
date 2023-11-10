using static System.Console;

namespace CSharpStudy
{
    /// <summary>
    /// This Class shows the basic of C#
    /// </summary>
    public class CS01HelloWorld
    {
        /// <summary>
        /// If you want to use all methods in class CS01HelloWorld
        /// </summary>
        public void UseAllMethod()
        {
            WriteHello();
            UseEscapeSequence();
            UseEscapeSequence();
            UseVariables();
            UseTypeCasting();
            UseReadLine();
        }

        /// <summary>
        /// this methods shows
        /// how to show string on Console.
        /// </summary>
        public void WriteHello()
        {
            //WriteLine adds \n automatically
            //so you don't have to add \n, if you want to start new line
            WriteLine("Hello, C# World! with WriteLine");

            //Write does not add \n
            //so if you want to start new line, add \n
            Write("Hello, C# World! with write & newline character\n");
            Write("\n");
        }

        /// <summary>
        /// how to use escape sequences.
        /// </summary>
        public void UseEscapeSequence()
        {
            //backslash character \ example
            Write("escape sequence의 사용법\n");
            Write("역슬래시(\\)를 특수문자 앞에 붙여 사용한다.\n");
            Write("\n");

            //newline character \n example
            Write("줄넘김 기호는 역슬래시(\\)에 Newline의 첫글자 n를 붙인다.\n");
            Write("줄넘김 기호는 \\n이다.\n줄이 넘어간 문장이다.\n");
            Write("\n");

            //quatation mark ", ' example
            Write("따옴표(\", \')를 출력하고 싶은가?\n");
            Write("역슬래시(\\)를 붙이면 된다.\n");
            Write("\n");

            //tab example
            Write("탭(tab\t)을 출력하고 싶은가?\n");
            Write("역슬래시(\\)를 붙이면 된다.\n");
            Write("\t 탭은 8칸의 크기를 가진다.\n");
            Write("12345678\n");
            Write("\n");

            //backspace example
            Write("출력 문장의 마지막 글자를 지우고 싶은가?\n");
            Write("역슬래시(\\)에 backspace의 첫글자 b를 붙이면 된다.\n");
            Write("첫번째 문장이다\b");
            Write("첫번째 문장의 \'다\'글자가 지워졌을 것이다.\n");
            Write("\n");
        }

        /// <summary>
        /// this method shows
        /// how to declare and initialize variables.
        /// </summary>
        public void UseVariables()
        {
            //declared but not initialized
            int intNum1;
            float floatNum1;
            double doubleNum1;
            string name1;

            // Uncomment below line, than you can see the error [not assiged]
            // WriteLine("intNum1" + intNum1.ToString());

            //declared and initialized
            int intNum2 = 10;
            float floatNum2 = 3.14159f;
            double doubleNum2 = 3.14159265358979d;
            string name2 = "jeire";
        }

        // How To Use Comment
        // this is single line comment

        /*
         * this is multi line comment
         * if you use multi line comments, than use this style
         * this comment starts with /* and ends with next line character
         */

        /// <summary>
        /// this method shows how to use Casting
        /// </summary>
        public void UseTypeCasting()
        {
            //casting (can see in code)
            int num1 = 10;
            long num2 = (long)num1;

            //casting (cannot see in code)
            int num3 = 20;
            long num4 = num3;

            num3 = 40;
            num4 = num3;

            WriteLine("num3's type is " + num3.GetType().Name);
            WriteLine("num4's type is " + num4.GetType().Name);
            Write("\n");

            //casting (large size data type to small size data type
            float float1 = 10.61f;
            int num5 = (int)float1;

            WriteLine("num5 is " + num5);
            WriteLine("num5's type is " + num5.GetType().Name);
            Write("\n");

            Write("\n");
        }

        /// <summary>
        /// this methods shows how to use ReadLine() method.
        /// ReadLine() returns string, so if you want integer input,
        /// you must use type conversion
        /// </summary>
        public void UseReadLine()
        {
            WriteLine("please input any string or number: ");
            string userData = ReadLine();
            WriteLine("your input is " + userData);
            Write("\n");

            //input multi 
            WriteLine("please input two numbers, split with space ' ' : ");
            string numInputs = ReadLine();
            string[] numbers = numInputs.Split(' ');

            int add1 = int.Parse(numbers[0]);
            int add2 = int.Parse(numbers[1]);
            int sum1 = add1 + add2;

            WriteLine("your input is " + add1 + " & " + add2 + ",");
            WriteLine(add1 + " + " + add2 + " = " + sum1);
        }
    }
}
