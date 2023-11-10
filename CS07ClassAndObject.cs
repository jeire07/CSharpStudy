using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    internal class CS07ClassAndObject
    {
        static void TodayIndex()
        {
            Console.WriteLine();

            DowJones dow = new DowJones();
            dow.Name = "Dow";
            dow.Change = 59.66f;
            dow.Point = 18036.7f;
            dow.rate = 0.33f;

            Nasdaq nasdaq = new Nasdaq();
            nasdaq.Name = "Nasdaq";
            nasdaq.Change = -10.96f;
            nasdaq.Point = 4977.29f;

            dow.ShowIndex();
            nasdaq.ShowIndex();
        }
    }

    public class Index
    {
        public string Name { get; set; }
        public float Change { get; set; }
        public float Point { get; set; }

        public virtual void ShowIndex()
        {
            if (Change > 0)
            {
                Console.WriteLine($" The {Name} closed {Change} points up");
            }
            else if (Change < 0)
            {
                float absChange = Change * (-1);
                Console.WriteLine($" The {Name} closed {absChange} points fell");
            }
            else
            {
                Console.WriteLine($" The {Name} closed {Change} without change");
            }
        }
    }

    public class Nasdaq : Index
    {

    }

    public class DowJones : Index
    {
        public float rate;

        public override void ShowIndex()
        {
            if (rate > 0)
            {
                Console.WriteLine($" The {Name} closed {rate} points up");
            }
            else if (rate < 0)
            {
                float absRate = rate * (-1);
                Console.WriteLine($" The {Name} closed {absRate} points fell");
            }
            else
            {
                Console.WriteLine($" The {Name} closed {rate} without change");
            }
        }
    }

    abstract class Index2
    {
        public abstract void ShowIndex();
    }

    class KOSPI : Index2
    {
        public string Name { get; set; }
        public float Change { get; set; }
        public float Point { get; set; }

        public override void ShowIndex()
        {
            if (Change > 0)
            {
                Console.WriteLine($" The {Name} closed {Change} points up");
            }
            else if (Change < 0)
            {
                float absChange = Change * (-1);
                Console.WriteLine($" The {Name} closed {absChange} points fell");
            }
            else
            {
                Console.WriteLine($" The {Name} closed {Change} without change");
            }
        }
    }
}
