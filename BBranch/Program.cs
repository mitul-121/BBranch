using System;
using System.Xml.Linq;

class BBranch
{  
    public class Branch
    {
        //Class for the Branch of the tree
        public List<Branch> branches = new List<Branch>();        
    };

    // calculate the maximum depth
    public static int Depth(Branch root, int depth)
    {
        int result = depth + 1;

        foreach (var node in root.branches)
            result = Math.Max(result, Depth(node, depth + 1));

        return result;
    }

   
    public static void Main()
    {
        Branch root = new Branch();
        (root.branches).Add(new Branch());
        (root.branches).Add(new Branch());
        (root.branches[0].branches).Add(new Branch());
        (root.branches[1].branches).Add(new Branch());
        (root.branches[1].branches).Add(new Branch());
        (root.branches[1].branches).Add(new Branch());
        (root.branches[1].branches[0].branches).Add(new Branch());
        (root.branches[1].branches[1].branches).Add(new Branch());
        (root.branches[1].branches[1].branches).Add(new Branch());
        (root.branches[1].branches[2].branches).Add(new Branch());
        (root.branches[1].branches[1].branches[0].branches).Add(new Branch());


        int result = Depth(root,0);
        Console.WriteLine(result);
        Console.ReadLine();
    }
}

