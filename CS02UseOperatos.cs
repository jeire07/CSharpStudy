using static System.Console;

namespace CSharpStudy
{
    /// <summary>
    /// How to user Operators in C#
    /// </summary>
    public class CS02UseOperators
    {
        private int num1 = 4;
        private int num2 = 3;

        /// <summary>
        /// If you want to use all methods in class CS02UseOperators
        /// </summary>
        public void UseAllMethod()
        {
            ArithmeticOps();
            ComparisonOps();
            LogicalOps();
            BitwiseOps();
            AssignmentOps();
            IncreAndDecre();
        }

        /// <summary>
        /// How to use +, -, *, /, %
        /// </summary>
        public void ArithmeticOps()
        {
            WriteLine();

            //Arithmetic Operators
            //add
            WriteLine(" num1 + num2 = " + (num1 + num2));

            //subtract
            WriteLine(" num1 - num2 = " + (num1 - num2));

            //multiply
            WriteLine(" num1 * num2 = " + (num1 * num2));

            //divide, but two numbers are int, so result is int
            WriteLine(" num1 / num2 = " + (num1 / num2));

            //divide, but two numbers are int, so we can check the remainder
            WriteLine(" num1 % num2 = " + (num1 % num2));

            WriteLine();
        }

        /// <summary>
        /// How to use ==, !=, >, <, >=, <=
        /// </summary>
        public void ComparisonOps()
        {
            //Comparison Operators
            //eqaul
            Write("Is num1 and num2 are eqaul?\t");
            WriteLine(num1 == num2);

            //not eqaul
            Write("Is num1 and num2 are not eqaul?\t");
            WriteLine(num1 != num2);

            //greater than, less than
            Write("Is num1 greater than num2?\t");
            WriteLine(num1 > num2);

            Write("Is num1 less than num2?\t\t");
            WriteLine(num1 < num2);

            //greater-than or equal to, less-than or equal to
            Write("Is num1 greater-than or equal to num2?\t");
            WriteLine(num1 >= num2);
            Write("Is num1 less-than or equal to num2?\t");
            WriteLine(num1 <= num2);

            WriteLine();
        }

        /// <summary>
        /// How to use &&, ||, !
        /// </summary>
        public void LogicalOps()
        {
            //Logical Operator
            //AND
            Write("Is num1 included between 0 and 20?\t");
            WriteLine((num1 > 0) && (num1 < 20));

            //OR
            Write("Is num1 greater than 0 or 20?\t");
            WriteLine((num1 > 0) || (num1 > 20));

            //NOT
            Write("Is num1 greater than num2?\t");
            WriteLine(!(num1 <= num2));

            WriteLine();
        }

        /// <summary>
        /// How to use &, |, ^, ~, <<, >>
        /// </summary>
        public void BitwiseOps()
        {
            int num3 = 0b00000110; //6 in decimal
            int num4 = 0b00001100; //12 in decimal

            //Bitwise Operator
            //AND
            WriteLine(Convert.ToString(num3 & num4, 2));

            //OR
            WriteLine(Convert.ToString(num3 | num4, 2));

            //XOR
            WriteLine(Convert.ToString(num3 ^ num4, 2));

            //NOT
            WriteLine(Convert.ToString(~num3, 2));

            //left-shift & right-shift
            WriteLine(Convert.ToString(num3 << 3, 2));
            WriteLine(Convert.ToString(num4 >> 3, 2));

            WriteLine();
        }

        /// <summary>
        /// How to use +=, -=, *=, /=, %=
        /// </summary>
        public void AssignmentOps()
        {
            //Assignment Operator
            //These operators performs similarly to arithmetic operators,
            //but with the additional distinction
            //that it also assigns the result.
            num1 += num2;
            WriteLine(" num1 + num2 = " + num1);
            num1 -= num2;
            WriteLine(" num1 - num2 = " + num1);
            num1 *= num2;
            WriteLine(" num1 * num2 = " + num1);
            num1 /= num2;
            WriteLine(" num1 / num2 = " + num1);
            num1 %= num2;
            WriteLine(" num1 % num2 = " + num1);

            WriteLine();
        }

        /// <summary>
        /// How to use ++, --
        /// </summary>
        public void IncreAndDecre()
        {
            //Increment
            num1++;
            Console.WriteLine(" num1 = " + num1);
            //Decrement
            num1--;
            Console.WriteLine(" num1 = " + num1);

            Console.WriteLine();
        }
    }
}
