class Exercise6
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

        nums = removeOdds(nums);

        Console.Write("\nYour list is: ");
        for (int i = 0; i < nums.Count; i++)
        {
            Console.Write($"[{nums[i]}]  ");
        }
    }

    static List<int> removeOdds(List<int> nums)
    {
        for (int i = 0; i < nums.Count; i++)
        {
            int count = 0;
            for (int j = 0; j < nums.Count; j++)
            {
                if (nums[i] == nums[j])
                {
                    count++;
                }
            }
            if (count % 2 != 0)
            {
                int removed = nums[i];
                for (int j = 0; j < nums.Count; j++)
                {
                    nums.Remove(removed);
                }
            }

        }
        return nums;

    }
}