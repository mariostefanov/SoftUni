using System;

class Program
{
    static void Main(string[] args)
    {
        AVL<int> tree = new AVL<int>();
        tree.Insert(1);
        tree.Insert(3);
        tree.Insert(2);

        Console.WriteLine();
    }
}
