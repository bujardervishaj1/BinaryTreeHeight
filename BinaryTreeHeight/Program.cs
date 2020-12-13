using System;

namespace BinaryTreeHeight
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new BinaryTree
            {
                root = new Node(4)
            };
            tree.root.left = new Node(3);
            tree.root.right = new Node(6);
            tree.root.left.left = new Node(2);
            tree.root.left.right = new Node(5);

            Console.WriteLine("Lartesia e pemes eshte: " + tree.MaxDepth(tree.root));
        }
    }
}
