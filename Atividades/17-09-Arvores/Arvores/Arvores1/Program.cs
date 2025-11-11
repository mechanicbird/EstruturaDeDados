class Node
{
    public int Value;

    public Node Left;

    public Node Right;

    public Node(int value)
    {
        Value = balue;
        Left = null;
        Right = null;
    }
}


public BinaryTree()
{
    Root = null;
}

    public void Insert(int value)
    {
        Root = InsertRec(Root,value);
    }

private Node InsertRec(Node root, int value)
{
    if (root == null) return new Node(value)


    if(value < root.Value)
    root.Left = InsertRec(root.Left,value);
    else if(value > root.Value)
    root.Right = InsertRec(root.Right,value);


return root;

}

public bool SearchWithPath(int value)
{

    Console.Write($"Buscando {value}: caminho->");
    return SearchRec(Root,value);
}

private bool SearchRec(Node root, int value)
{
    if (root == null)
    {
        Console.WriteLine("não encontrado!");
        return false;
    }

    Console.Write(root.Value +" ");

    if (root.Value == value)
    {
        Console.WriteLine(" encontrado!");
        return true;
    }

    if (value <root.Value)
       return SearchRec(root.Left,value); 
    else
       return SearchRec(root.Right, value);
}

class Program
{
    static void Main(string[] args)
    {
        BinaryTree tree = new BinaryTree();

        int[] valores = {45,20,60,10,30,50,70};
        foreach (var v in valores)
            tree.Insert(v);

            tree.SearchWithPath(30);
            tree.SearchWithPath(70);
            tree.SearchWithPath(90);
    }
}

