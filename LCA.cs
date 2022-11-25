using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findLCA
{
    public class LCA
    {
        private int index1;
        private int index2;
        private int index_common_ancestor;
        BinaryTree binaryTree;

        public LCA()
        {
            this.index1 = 0;
            this.index2 = 0;
            this.index_common_ancestor = 0;
        }

        public LCA(int val1, int val2)
        {
            this.index1 = val1;
            this.index2 = val2;
            this.index_common_ancestor = 0;
        }

        public int RunLCA()
        {
            binaryTree = new BinaryTree();
            fillTree(binaryTree);
            this.index_common_ancestor = binaryTree.calcLCA(this.index1, this.index2);
            return this.index_common_ancestor;
        }
        
        private static void fillTree(BinaryTree btree)
        {            
            for (int i = 1; i <= 100; i++)
            {
                btree.Insert(i);
            }
        }
    }
}
