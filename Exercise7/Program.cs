class Exercise7
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

        counter(nums);
    }

    static void counter(List<int> nums)
    {
        nums.Sort();

        for (int i = 0; i < nums.Count; i++)
        {
            int count = 0;
            for (int j = i; j < nums.Count; j++)
            {
                if (nums[i] == nums[j])
                {
                    count++;
                }
            }

            if (count != 1) { Console.WriteLine($"[{nums[i]}] appeared {count} times"); }
            else { Console.WriteLine($"[{nums[i]}] appeared {count} time"); }
            i += count-1;
            
        }
    }
}