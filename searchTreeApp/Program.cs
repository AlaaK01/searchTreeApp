using System;
using searchTreeApp;


namespace searchTreeApp
{
    class program
    {
        static void Main(string[] args)
        {
           

            var tree = new Tree<int>();
            tree.Insert(7);
            tree.Insert(4);
            tree.Insert(9);
            tree.Insert(1);
            tree.Insert(68);
            tree.Insert(8);
            tree.Insert(10);



            Console.WriteLine(tree.Exists(10));
            Console.WriteLine("------------");
            Console.WriteLine(tree.Count());

            Console.WriteLine("------Per------");
            tree.traversePerOrder();
            Console.WriteLine("-----In-------");
            tree.traverseInOrder();
            Console.WriteLine("-----Post-------");
            tree.traversePostOrder();
            Console.WriteLine("------height------");
            Console.WriteLine(tree.Height());


            Console.ReadKey();
        }
    }
}