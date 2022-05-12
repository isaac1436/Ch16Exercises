class Exercise4
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

        Console.Write("\n\nThe longest subsequence is: ");
        List<int> subseq = SubSeq(nums);
        for (int i = 0; i < subseq.Count; i++)
        {
            Console.Write($"[{subseq[i]}]  ");
        }

    }

    static List<int> SubSeq(List<int> nums)
    {
        List<int> subseq=new List<int>();
        int maxCount = 1;

        for(int i = 0; i < nums.Count; i++)
        {
            int count = 0;

            for(int j=i; j < nums.Count; j++)
            {
                if(nums[j] == nums[i])
                {
                    count++;
                }

                else { break; }
            }

            if (count > maxCount)
            {
                maxCount = count;
                subseq.Clear();
                for(int j=0; j < count; j++)
                {
                    subseq.Add(nums[i]);
                }
                i += count;
            }
        }

        return subseq;
    }
}