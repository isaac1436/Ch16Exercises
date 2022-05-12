class Exercise3
{
    static void Main()
    {
        List<int> nums = new List<int>();

        Console.WriteLine("Please enter some integers: ");

        for (int i = 0; ; i++)
        {
            string ts = Console.ReadLine();

            if (ts == "")
            {
                break;
            }

            nums.Add(int.Parse(ts));

        }

        nums.Sort();

        Console.Write("\n\nThe sorted list is: ");
        for (int i = 0; i < nums.Count; i++)
        {
            Console.Write($"[{nums[i]}]  ");
        }
    }
}