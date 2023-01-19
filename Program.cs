
//Queue();

//Stack();

//Dictionary();

//HashSet();

//uppgift1();

uppgift2();

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
    string input = "[()]{}{[()()]()}";

    Stack<char> st = new Stack<char>();

    foreach(char c in input){
        if(c == '{' || c == '(' || c == '[') st.Push(c);
    else{
        if(st.Count == 0){
            Console.WriteLine("Obalancerad");
            return;
        }
        char stackChar = st.Pop();
        bool b = false;
        if (c == ')' && stackChar == '(')
            b = true;
        else if (c == '}' && stackChar == '{')
            b = true;
        else if (c == ']' && stackChar == '[')
            b = true;
        
        if(!b){
            Console.WriteLine("Obalanserad");
            return;
        }
    }
}
if(st.Count == 0)
    Console.WriteLine("Balanserad");
else
    Console.WriteLine("Obalanserad");
}

void uppgift2()
{
    string input = "*+12-34";
    Stack<char> math = new Stack<char>();

    for (char c = "*"; c = )
    {
        
    }
}