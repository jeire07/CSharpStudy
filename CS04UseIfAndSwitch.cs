using static System.Console;

namespace CSharpStudy
{
    public class CS04UseIfAndSwitch
    {
        /// <summary>
        /// If you want to use all methods in class CS04UseIfAndSwitch
        /// </summary>
        public void UseAllMethod()
        {
            int userPoint = 0;
            int guessNum = 1;
            int userNum = 0;
            string userChoice = "";

            IntroduceGuessNumber();
            guessNum = CreateRandom(4);
            userNum = GetNumber();
            CheckNumber(userPoint, guessNum, userNum);

            IntroduceOddOrEven();
            guessNum = CreateRandom(6);
            userChoice = GetUserString();
            OddOrEven(userPoint, guessNum, userChoice);

            UseLoopExpressions(userPoint);
        }

        /// <summary>
        /// This method provides an introduction to the GuessNumber game for the user.
        /// </summary>
        public void IntroduceGuessNumber()
        {
            WriteLine("Guess which number I have.");
            WriteLine("I have a random number between 0 to 4");
            WriteLine("You can try just one times");
            WriteLine("Than I'll let you know greater or lesser than my number");
            WriteLine();
        }

        /// <summary>
        /// This method generates a random number between 0 and 4,
        /// and returns the result as an integer.
        /// </summary>
        /// <param name="NumRange">Maximum range of randomly generated number</param>
        /// <returns>An integer representing the generated number.</returns>
        public int CreateRandom(int NumRange)
        {
            Random randNum = new Random();
            int guessNum = randNum.Next(NumRange);

            return guessNum;
        }

        /// <summary>
        /// This method takes user input,
        /// converts it to an integer, and returns the result.
        /// </summary>
        /// <returns>An integer representing the user input.</returns>
        public int GetNumber()
        {
            Write("Input your number: ");

            string userInput = ReadLine();
            int userNum = int.Parse(userInput);

            return userNum;
        }

        /// <summary>
        /// This method compares the number entered by the user
        /// with a randomly generated number,
        /// indicating whether it is greater, smaller, or equal.
        /// </summary>
        /// <param name="userPoint">The number count for total points</param>
        /// <param name="guessNum">The randomly generated number</param>
        /// <param name="userNum">The number entered by the user</param>
        public void CheckNumber(int userPoint, int guessNum, int userNum)
        {
            //if, else if, else expression
            if (guessNum == userNum)
            {
                WriteLine("correct!");
                WriteLine("you got 500 points!");
                userPoint += 500;
            }
            else if (guessNum > userNum)
            {
                WriteLine("the number is greater than " + userNum);
            }
            else
            {
                WriteLine("the number is lesser than " + userNum);
            }
        }

        /// <summary>
        /// This method provides an introduction to the even-odd game for the user.
        /// </summary>
        public void IntroduceOddOrEven()
        {
            WriteLine("guess the dice's number game.");
            WriteLine("you can choose even or odd");
            WriteLine("if your answer is correct, you'll get points");
            WriteLine("else, you lost points");
            WriteLine();
        }

        /// <summary>
        /// This method takes user input "even" or "odd"
        /// and returns user input.
        /// </summary>
        /// <returns>The string entered by the user.</returns>
        public string GetUserString()
        {
            Write("Input your guess (even / odd): ");
            string userInput = ReadLine();
            WriteLine();
            return userInput;
        }

        /// <summary>
        /// This method determines if the generated number is odd or even,
        /// and checks if the user has guessed the correct answer to assign a score.
        /// </summary>
        /// <param name="userPoint">The number count for total points</param>
        /// <param name="guessNum">The randomly generated number</param>
        /// <param name="userInput">The string entered by the user</param>
        public void OddOrEven(int userPoint, int guessNum, string userInput)
        {
            string evenOrOdd;

            switch (guessNum % 2)
            {
                case 0:
                    evenOrOdd = "even";
                    WriteLine("even!");
                    break;
                case 1:
                    evenOrOdd = "odd";
                    WriteLine("odd!");
                    break;
                default:  // this case will not happens
                    evenOrOdd = "error";
                    WriteLine("error?!");
                    break;
            }

            //gives score based on result.
            if (userInput == evenOrOdd)
            {
                userPoint += 500;
            }
            else
            {
                userPoint -= 500;
            }
            WriteLine();
        }

        /// <summary>
        /// This method shows the usage of various types of loops,
        /// including for, while, do-while, and foreach.
        /// </summary>
        /// <param name="userPoint">The number count for total points</param>
        public void UseLoopExpressions(int userPoint)
        {
            WriteLine("dice rolling game");
            WriteLine("you will get points " +
                "total sum of your dice's numbers");
            WriteLine("input how many times do you want.");

            Write("Input your number: ");
            string userInput = ReadLine();
            int userNum = int.Parse(userInput);

            int diceNum = 0;

            //for loop expression
            for (int retry = 0; retry < userNum; retry++)
            {
                Random randNum = new Random();
                diceNum = randNum.Next(6) + 1;
                userPoint += diceNum;
                WriteLine("your score is " + userPoint);
            }

            /******************************/
            //while loop expression
            /******************************/
            int whileCount = 0;

            while (whileCount < 4)
            {
                WriteLine(whileCount);
                whileCount++;
            }

            /******************************/
            //do while loop expression
            /******************************/
            int doCount = 0;

            do
            {
                WriteLine(doCount);
                doCount++;
            }
            while (doCount < 4);

            /******************************/
            //foreach loop expression
            /******************************/
            string[] fruits = { "apple", "grape", "orange" };

            foreach (string fruit in fruits)
            {
                WriteLine(fruit);
            }

            /******************************/
            //break, continue
            /******************************/
            int forCount = 0;

            for (; forCount < 10; forCount++)
            {
                if (forCount == 4)
                {
                    break;
                }
                WriteLine(forCount);
            }

            WriteLine();

            for (forCount = 0; forCount < 10; forCount++)
            {
                if (forCount == 4)
                {
                    continue;
                }
                WriteLine(forCount);
            }
        }
    }
}
