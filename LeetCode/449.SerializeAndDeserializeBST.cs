using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //Serialization is the process of converting a data structure or object into a sequence of bits so that it can be stored in a file or memory buffer, or transmitted across a network connection link to be reconstructed later in the same or another computer environment.
    //Design an algorithm to serialize and deserialize a binary search tree. There is no restriction on how your serialization/deserialization algorithm should work. You just need to ensure that a binary search tree can be serialized to a string and this string can be deserialized to the original tree structure.
    //The encoded string should be as compact as possible.
    //Note: Do not use class member/global/static variables to store states.Your serialize and deserialize algorithms should be stateless.

    public class TreeNode
    {
         public int val;
         public TreeNode left;
         public TreeNode right;
         public TreeNode(int x) { val = x; }
     }

    public class Codec
    {
        public string serialize(TreeNode root)
        {
            if (root == null)
            {
                return "#!";
            }

            string res = root.val + "!";
            res += serialize(root.left);
            res += serialize(root.right);
            return res;
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            var nodeData = data.Split(new string[] { "!" }, StringSplitOptions.RemoveEmptyEntries);

            var queue = new Queue<string>();

            foreach (var node in nodeData)
            {
                queue.Enqueue(node);
            }

            return RebuildNode(queue);
        }

        private TreeNode RebuildNode(Queue<string> queue)
        {
            var Value = queue.Dequeue();

            if (Value == "#")
            {
                return null;
            }

            TreeNode node = new TreeNode(int.Parse(Value));

            node.left = RebuildNode(queue);
            node.right = RebuildNode(queue);

            return node;
        }
    }
}
