using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace happy_little_trees_2
{
    class Tree
    {
        public int height_trunk;
        public int branch;
        public List<int> heightBranches;
        public List<int> posittions;

        public Tree()
        {
            height_trunk = 1;
            heightBranches = new List<int>();
            posittions = new List<int> ();

        }
        public void GrowTrunk()
        {
            height_trunk++;
        }
        public void NewBranch()
        {
            heightBranches.Add(1);
            posittions.Add(height_trunk);
        }
        public void GrowBranches()
        {
        for(int i = 0; i < heightBranches.Count; i++)
        {
                heightBranches[i] += 1;
        }
        }
        public void Ouch(int n)
        {
            heightBranches.RemoveAt(n);
            posittions.RemoveAt(n);
        }
        public string Description()
        {
           string rezult = "The tree trunk is " + height_trunk + " There are " + heightBranches.Count + " branch that have position: " +
                     string.Join( " , ", posittions) + " and length: " + string.Join( " , ", heightBranches) + "!";

            return rezult;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.GrowTrunk();
            tree.GrowTrunk();
            tree.GrowTrunk();
            
            tree.NewBranch();
            tree.NewBranch();

            tree.GrowTrunk();
            tree.NewBranch();
            tree.NewBranch();

            
            Console.WriteLine(tree.Description());

            Console.ReadLine();

        }
    }
}
