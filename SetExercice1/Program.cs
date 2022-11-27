SortedSet<int> cursoA = new SortedSet<int>();
SortedSet<int> cursoB = new SortedSet<int>();
SortedSet<int> cursoC = new SortedSet<int>();

Console.Write("How many students for course A? ");
int quant = int.Parse(Console.ReadLine()!);
for(int i = 0; i < quant; i++)
{
    int codigo = int.Parse(Console.ReadLine()!);
    cursoA.Add(codigo);
}

Console.Write("How many students for course B? ");
quant = int.Parse(Console.ReadLine()!);
for (int i = 0; i < quant; i++)
{
    int codigo = int.Parse(Console.ReadLine()!);
    cursoB.Add(codigo);
}

Console.Write("How many students for course C? ");
quant = int.Parse(Console.ReadLine()!);
for (int i = 0; i < quant; i++)
{
    int codigo = int.Parse(Console.ReadLine()!);
    cursoC.Add(codigo);
}

SortedSet<int> todos = new SortedSet<int>(cursoA);
todos.UnionWith(cursoB);
todos.UnionWith(cursoC);
Console.WriteLine("Total students: " + todos.Count);