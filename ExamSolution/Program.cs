namespace ExamSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //xndir 1

            int i = 100;
            int sum = 0;
            int v = Value(i, out sum);
            Console.WriteLine(v);

            //xndir 2

            //Console.WriteLine("Please write number ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //Happy happy = new Happy();
            //happy.Plural(number);

            //xndir 3 

            //int[] arr1 = { 1, 5, 7 };
            //IntToString intToString = new IntToString();
            //intToString.Method(arr1);
        }
        static int Value(int i, out int sum)
        {
            if (i == 1)
            {
                sum = 1;
                return sum;
            }
            else
            {
                sum = i + Value(i - 1, out int tempSum);
                return sum;
            }
        }


    }
}