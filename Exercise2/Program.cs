Stack<int> myStack=new Stack<int>();
int count = 0;

Console.WriteLine("Please enter some positive integers: ");

for (int i=0; ; i++)
{
    string ts = Console.ReadLine();

    if (ts == "")
    {
        break;
    }

    myStack.Push(int.Parse(ts));
    count++;
}

Console.Write("\nMy stack in reverse is: ");

for(int i=0;i<count ; i++)
{
    Console.Write($"[{myStack.Pop()}]  ");
}