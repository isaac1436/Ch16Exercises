// See https://aka.ms/new-console-template for more information

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

for(int i = 0; i < nums.Count; i++)
{
    if(nums[i] < 0)
    {
        nums.RemoveAt(i);
    }
}

Console.Write("Your list without any added negative numbers is: ");

for(int i=0; i < nums.Count; i++)
{
    Console.Write($"[{nums[i]}]  ");
}
