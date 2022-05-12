List<int> posvNums = new List<int>();

Console.WriteLine("Please enter some positive integers");
int sum = 0;

for(int i = 0; ; i++)
{
    string ts=Console.ReadLine();

    if (ts == "")
    {
        break;
    }

    posvNums.Add(int.Parse(ts));
    sum+=posvNums[i];
}

double avg=sum/posvNums.Count;

Console.WriteLine($"The sum of the numbers in the list is {sum} and the average is {avg}");
