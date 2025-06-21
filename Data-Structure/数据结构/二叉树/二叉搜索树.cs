public class BinarySearchTree
{
    //节点类
    private class TreeNode
    {
        public int Data { get; set; } //数据
        public TreeNode Left { get; set; } //左子节点
        public TreeNode Right { get; set; } //右子节点

        public TreeNode(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }

    private TreeNode root; //根节点

    public BinarySearchTree()
    {
        root = null;
    }

    public void Insert(int data)
    {
        root = InsertNode(root, data);
    }

    private TreeNode InsertNode(TreeNode node, int data)
    {
        if (node == null) //如果根节点为空
        {
            node = new TreeNode(data); //初始化根节点
            return node;
        }

        if (data < node.Data) //比根节点的值小
        {
            node.Left = InsertNode(node.Left, data); //插入到左边
        }
        else if (data > node.Data) //比根节点的值大
        {
            node.Right = InsertNode(node.Right, data); //插入到右边
        }

        return node;
    }

    public bool Contains(int data)
    {
        return ContainsNode(root, data);
    }

    private bool ContainsNode(TreeNode node, int data)
    {
        if (node == null)
            return false;

        if (data < node.Data)
            return ContainsNode(node.Left, data);
        else if (data > node.Data)
            return ContainsNode(node.Right, data);
        else
            return true;
    }

    public void Delete(int data)
    {
        root = DeleteNode(root, data);
    }

    private TreeNode DeleteNode(TreeNode node, int data)
    {
        if (node == null)
            return node;

        if (data < node.Data)
        {
            node.Left = DeleteNode(node.Left, data);
        }
        else if (data > node.Data)
        {
            node.Right = DeleteNode(node.Right, data);
        }
        else
        {
            if (node.Left == null) //节点只有右节点
            {
                return node.Right;
            }
            else if (node.Right == null) //节点只有左节点
            {
                return node.Left;
            }

            // 节点有两个子节点：获取右子树的最小值
            node.Data = MinValue(node.Right);

            // 删除右子树的最小值
            node.Right = DeleteNode(node.Right, node.Data);
        }

        return node;
    }

    private int MinValue(TreeNode node)
    {
        int minValue = node.Data;
        while (node.Left != null)
        {
            minValue = node.Left.Data;
            node = node.Left;
        }
        return minValue;
    }

    public void PreOrder()
    {
        PreOrderNode(root);
    }

    private void PreOrderNode(TreeNode node)
    {
        if (node == null)
            return;
        Console.Write(node.Data + " ");
        PreOrderNode(node.Left);
        PreOrderNode(node.Right);
    }

    public void InOrder()
    {
        InOrderNode(root);
    }

    private void InOrderNode(TreeNode node)
    {
        if (node == null)
            return;
        InOrderNode(node.Left);
        Console.Write(node.Data + " ");
        InOrderNode(node.Right);
    }

    public void PostOrder()
    {
        PostOrderNode(root);
        Console.WriteLine();
    }

    private void PostOrderNode(TreeNode node)
    {
        if (node == null)
            return;
        PostOrderNode(node.Left);
        PostOrderNode(node.Right);
        Console.Write(node.Data + " ");
    }
}