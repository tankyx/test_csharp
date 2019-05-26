// C# program for different tree traversals 
using System;

/* Class containing left and right child of current 
node and key value*/
public class Node
{
    public int key;
    public Node left, right;

    public Node(int item)
    {
        key = item;
        left = right = null;
    }
}

public class BinaryTree
{
    // Root of Binary Tree 
    Node root;
    Node _result;

    BinaryTree()
    {
        root = null;
        _result = null;
    }

    /* Given a binary tree, print its nodes in preorder*/
    void getNodeFromValue(Node node, int value)
    {
        if (node == null)
            return;
        else if (node.key == value)
        {
            _result = node;
            Console.Write("\nFound key : " + node.key + "\n");
            return;
        }
        else
        {
            Console.Write(node.key + " ");
            if (_result == null)
                getNodeFromValue(node.left, value);
            if (_result == null)
                getNodeFromValue(node.right, value);
        }
    }

    // Wrappers over above recursive functions 
    void getNodeFromValue(int value)
    {
        getNodeFromValue(root, value);
    }

    // Driver method 
    public static void Main()
    {
        BinaryTree tree = new BinaryTree();
        tree.root = new Node(1);
        tree.root.left = new Node(2);
        tree.root.right = new Node(3);
        tree.root.left.left = new Node(4);
        tree.root.left.right = new Node(5);

        tree.getNodeFromValue(4);
    }
}