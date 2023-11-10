using static System.Console;

namespace CSharpStudy
{
    public class CS06MethodAndStruct
    {
        //2 input method
        static int AddNum(int num1, int num2)
        {
            int sum1 = num1 + num2;
            return sum1;
        }

        //same method, but 3 input method
        static int AddNum(int num1, int num2, int num3)
        {
            int sum1 = num1 + num2 + num3;
            return sum1;
        }

        //method for call Addnum method
        static void TryOverload()
        {
            int num1 = 10;
            int num2 = 20;
            int num3 = 30;

            int sum1 = AddNum(num1, num2);
            int sum2 = AddNum(num1, num2, num3);
        }

        public struct PersonalInfo
        {
            public string Name;
            public int age;
            public float weight;
            public float height;

            public float CalcBMI(float height, float weight)
            {
                float yourBMI = height * height / weight;
                return yourBMI;
            }
        }

        static void MyBMI()
        {
            PersonalInfo human1;
            human1.Name = "jeire";
            human1.age = 30;
            human1.height = 176.5f;
            human1.weight = 89.0f;
            float myBMI = human1.CalcBMI(human1.height, human1.weight);
        }
    }
}
