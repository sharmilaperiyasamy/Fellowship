using System;

namespace LineComparison
{
    class Program
    {
        public static int x1, x2, y1, y2;
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter value for coordinate\"x1\" ");
                x1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter value for coordinate\"y1\" ");
                y1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter value for coordinate\"x2\" ");
                x2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter value for coordinate\"y2\" ");
                y2 = Convert.ToInt32(Console.ReadLine());

                FindingLength obj = new FindingLength();
                obj.LineLength(x1, y1, x2, y2, i);
            }
            CheckEquality obj1 = new CheckEquality();
            obj1.ComputeEquals();
            Console.ReadLine();
        }
    }
    public class FindingLength
    {
        public void LineLength(int x1, int y1, int x2, int y2, int i)
        {
            double sqrt = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            string val = Convert.ToString(Math.Round(sqrt, 2));
            Console.WriteLine("length of line is :" + val);
            InitializeArray.Data(val, i);
        }
    }
    public class CheckEquality
    {
        public void ComputeEquals()
        {
            if (InitializeArray.values[0].Equals(InitializeArray.values[1]) == true)
            {
                Console.WriteLine("Both lines are same");
            }
            else
            {
                Console.WriteLine("Both lines are different");
                string comparing = ((InitializeArray.values[0]).CompareTo(InitializeArray.values[1]) > 0) ? "Line1 is greater than line2" : "Line2 is greater than line1";
                Console.WriteLine(comparing);
            }
        }
    }
    public static class InitializeArray
    {
        public static string[] values = new string[2];
        public static void Data(string val, int index)
        {
            values[index] = val;
        }
    }
}
