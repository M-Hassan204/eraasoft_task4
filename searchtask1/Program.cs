namespace searchtask1
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int>();

            Console.Write("How many numbers? ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (numbers.Contains(num))//هنا بنستخدم ال Contains method عشان نعرف اذا الرقم موجود قبل كده ولا لا
                {
                    Console.WriteLine("Duplicate number found!");
                    return;
                }

                numbers.Add(num);
            }

            Console.WriteLine("No duplicate numbers.");
        }
    }
}
