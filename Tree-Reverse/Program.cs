using System;


namespace Tree_Reverse
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Node tree = new Node(0);
            tree.left = new Node(1);
            tree.right = new Node(4);
            tree.right.right = new Node(5);
            tree.left.right = new Node(3);
            tree.left.left = new Node(2);
          
            ReverseTree(tree);
            
            Console.WriteLine("Hello World!");
        }

        static Node ReverseTree(Node node)
        {
            if (node == null)
                return null;

            Node tmp = node.right;
            node.right = node.left;
            node.left = tmp;
          
            ReverseTree(node.left);
            
            ReverseTree(node.right);

            return node;
        }
    }
}
