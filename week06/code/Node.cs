public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value == Data)
        {

        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        // TODO Start Problem 2
        if (value == Data) return true;

        if (value > Data && Right is not null) return Right.Contains(value);
        else if (value < Data && Left is not null) return Left.Contains(value);

        return false;
    }

    public int GetHeight() {
        // TODO Start Problem 4
        var leftSubTree = Left?.GetHeight() ?? 0;
        var rightSubTree = Right?.GetHeight() ?? 0;
        return 1 + Math.Max(leftSubTree, rightSubTree);
    }
}