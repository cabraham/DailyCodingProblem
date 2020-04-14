using System;
using System.Collections.Generic;
using System.Text;

namespace DCP.Exercises.Problem_003
{
    public class Problem
    {
        private readonly Node tree;

        public Problem(Node tree)
        {
            this.tree = tree;
        }

        public string Serialize()
        {
            var stack = new Stack<Node>();
            stack.Push(tree);
            var s = "";
            while (stack.Count > 0)
            {
                var node = stack.Pop();
                if (node == null)
                    s += "-|";
                else
                {
                    s += node.Value + "|";
                    stack.Push(node.Right);
                    stack.Push(node.Left);
                }
            }

            return s;
        }

        public Node Deserialize(string input)
        {
            var arr = input.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            var queue = new Queue<string>(arr);

            var node = DeserializeNode(queue);
            return node;
        }

        private Node DeserializeNode(Queue<string> queue)
        {
            if (queue.Peek() != null)
            {
                var val = queue.Dequeue();
                if (val == "-")
                    return null;

                var node = new Node(val);
                node.Left = DeserializeNode(queue);
                node.Right = DeserializeNode(queue);

                return node;
            }

            return null;
        }
    }

    public class Node
    {
        public Node(string value, Node left = null, Node right = null)
        {
            Value = value;
            Left = left;
            Right = right;
        }

        public string Value { get; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }
}
