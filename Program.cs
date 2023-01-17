
//Queue();

//Stack();

//Dictionary();

//HashSet();

uppgift1();

void Queue()
{
    Queue<int> queue = new Queue<int>();

    queue.Enqueue(3);
    queue.Enqueue(4);
    queue.Enqueue(2);
    int num = queue.Dequeue();
    Console.WriteLine(num);
    foreach(int i in queue)
    {
        Console.WriteLine(i);
    }
}

void Stack()
{
    Stack<int> stack = new Stack<int>();

    stack.Push(2);
    stack.Push(4);
    stack.Push(3);
    int num = stack.Pop();
    Console.WriteLine(num);
    foreach(int i in stack)
    {
        Console.WriteLine(i);
    }
}

void Dictionary()
{
    Dictionary<string, int> dictionary = new Dictionary<string, int>();

    dictionary.Add("fyra", 4);
    dictionary.Add("två", 2);
    dictionary.Add("tre", 3);
    Console.WriteLine(dictionary["fyra"]);
    dictionary.Remove("tre");
    Console.WriteLine(dictionary.ContainsKey("tre"));

    foreach(KeyValuePair<string, int> keyValue in dictionary)
    {
        Console.WriteLine(keyValue);
    }
}

void HashSet()
{
    HashSet<int> set = new HashSet<int>();
    set.Add(0);
    set.Add(1);
    set.Add(0);
    set.Remove(1);
    foreach (var item in set)
    {
        Console.WriteLine(item);
    }
}

void uppgift1()
{
    static Boolean isMatchingPair(char characther1, char characther2)
    {
        if (characther1 == '(' && characther2 == ')')
            return true;
        else if (characther1 == '{' && characther2 == '}')
            return true;
        else if (characther1 == '[' && characther2 == ']')
            return true;
        else
            return false;
    }

    static Boolean areBracketsBalanced(char[] input)
    {
        Stack<char> st = new Stack<char>();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '{' || input[i] == '(' || input[i] == '[') st.Push(input[i]);

            if (input[i] == '}' || input[i] == ')' || input[i] == ']')
            {
                if (st.Count == 0) {
                    return false;
                }

                else if (!isMatchingPair(st.Pop(), input[i]))
                {
                    return false;
                }
            }
        }
    }
}