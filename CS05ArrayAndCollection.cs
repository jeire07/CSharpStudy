using static System.Console;

namespace CSharpStudy
{
    public class CS05ArrayAndCollection
    {
        public void UseAllMethod()
        {
            ArrayExample();
            ListExample();
            DictionaryExample();
            StackExample();
            QueueExample();
            HashSetExample();
        }

        public void ArrayExample()
        {
            // declaration and initialization at same time
            int[] score = { 90, 89, 80, 43, 44, 45 };

            // declaration only
            string[] fruits = new string[5];

            // 2-dimensional array
            int[,] HeightAndWeight = { { 120, 22 }, { 130, 29 }, { 140, 45 } };
        }

        public void ListExample()
        {
            // declaration and initialization at same time
            List<int> primeNum = new() { 2, 3, 5, 7, 11 };

            // Create an empty list
            List<int> scores = new List<int>();

            // Adding elements to a list using .Add()
            scores.Add(90);
            scores.Add(89);
            scores.Add(80);
            Write(" " + string.Join(", ", scores));
            WriteLine("");

            // Removing elements from a list using .Remove()
            scores.Remove(89);
            Write(" " + string.Join(", ", scores));
            WriteLine("\n");
        }

        public void DictionaryExample()
        {
            Dictionary<string, int> cost = new() { { "apple", 100 } };
            cost.Add("grape", 200);
            cost.Add("orange", 300);
            cost.Remove("grape");

            foreach (KeyValuePair<string, int> pair in cost)
            {
                Console.WriteLine(pair.Key + ": " + pair.Value);
            }
        }

        public void StackExample()
        {
            Stack<int> stack1 = new Stack<int>();  // int형 Stack 선언

            // Stack에 요소 추가
            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);

            // Stack에서 요소 가져오기
            int value = stack1.Pop(); // value = 3 (마지막에 추가된 요소)
        }

        public void QueueExample()
        {
            Queue<int> queue1 = new Queue<int>(); // int형 Queue 선언

            // Queue에 요소 추가
            queue1.Enqueue(1);
            queue1.Enqueue(2);
            queue1.Enqueue(3);

            // Queue에서 요소 가져오기
            int qValue = queue1.Dequeue(); // value = 1 (가장 먼저 추가된 요소)
        }

        public void HashSetExample()
        {
            HashSet<int> set1 = new HashSet<int>();  // int형 HashSet 선언

            // HashSet에 요소 추가
            set1.Add(1);
            set1.Add(2);
            set1.Add(3);

            // HashSet에서 요소 가져오기
            foreach (int element in set1)
            {
                Console.WriteLine(element);
            }
        }
    }
}
