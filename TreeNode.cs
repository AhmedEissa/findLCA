using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findLCA
{
    public class TreeNode
    {   
        private int data;
        public int Data
        {
            get { return data; }
        }

        private TreeNode rightNode;
        public TreeNode RightNode
        {
            get { return rightNode; }
            set { rightNode = value; }
        }

        private TreeNode leftNode;
        public TreeNode LeftNode
        {
            get { return leftNode; }
            set { leftNode = value; }
        }

        private bool isDeleted;
        public bool IsDeleted
        {
            get { return isDeleted; }
        }
        
        public TreeNode(int value)
        {
            data = value;
        }
        
        public void Delete()
        {
            isDeleted = true;
        }

        public TreeNode Find(int value)
        {
            TreeNode currentNode = this;

            while (currentNode != null)
            {
                if (value == currentNode.data && isDeleted == false)
                {
                    return currentNode;
                }
                else if (value > currentNode.data)
                {
                    currentNode = currentNode.rightNode;
                }
                else
                {
                    currentNode = currentNode.leftNode;
                }
            }            
            return null;
        }

        public TreeNode FindRecursive(int value)
        {
            if (value == data && isDeleted == false)
            {
                return this;
            }
            else if (value < data && leftNode != null)
            {
                return leftNode.FindRecursive(value);
            }
            else if (rightNode != null)
            {
                return rightNode.FindRecursive(value);
            }
            else
            {
                return null;
            }
        }

        public void Insert(int value)
        {
            if (value >= data)
            {   
                if (rightNode == null)
                {
                    rightNode = new TreeNode(value);
                }
                else
                {
                    rightNode.Insert(value);
                }
            }
            else
            {
                if (leftNode == null)
                {
                    leftNode = new TreeNode(value);
                }
                else
                {
                    leftNode.Insert(value);
                }
            }
        }

        public Nullable<int> SmallestValue()
        {            
            if (leftNode == null)
            {
                return data;
            }
            else
            {
                return leftNode.SmallestValue();
            }
        }

        internal Nullable<int> LargestValue()
        {   
            if (rightNode == null)
            {
                return data;
            }
            else
            {
                return rightNode.LargestValue();
            }
        }
        
        public void InOrderTraversal()
        {
            if (leftNode != null)
                leftNode.InOrderTraversal();
            if (rightNode != null)
                rightNode.InOrderTraversal();
        }

        public void PreOrderTraversal()
        {
            if (leftNode != null)
                leftNode.PreOrderTraversal();

            if (rightNode != null)
                rightNode.PreOrderTraversal();
        }

        public void PostorderTraversal()
        {
            if (leftNode != null)
                leftNode.PostorderTraversal();

            if (rightNode != null)
                rightNode.PostorderTraversal();
        }


        public int Height()
        {
            if (this.leftNode == null && this.rightNode == null)
            {
                return 1;
            }

            int left = 0;
            int right = 0;

            if (this.leftNode != null)
                left = this.leftNode.Height();
            if (this.rightNode != null)
                right = this.rightNode.Height();

            if (left > right)
            {
                return (left + 1);
            }
            else
            {
                return (right + 1);
            }

        }

        public int NumberOfLeafNodes()
        {
            if (this.leftNode == null && this.rightNode == null)
            {
                return 1; 
            }

            int leftLeaves = 0;
            int rightLeaves = 0;

            if (this.leftNode != null)
            {
                leftLeaves = leftNode.NumberOfLeafNodes();
            }
            if (this.rightNode != null)
            {
                rightLeaves = rightNode.NumberOfLeafNodes();
            }

            return leftLeaves + rightLeaves;
        }

        public bool IsBalanced()
        {
            int LeftHeight = LeftNode != null ? LeftNode.Height() : 0;
            int RightHeight = RightNode != null ? RightNode.Height() : 0;

            int heightDifference = LeftHeight - RightHeight;

            if (Math.Abs(heightDifference) > 1)
            {
                return false;
            }
            else
            {
                return ((LeftNode != null ? LeftNode.IsBalanced() : true) && (RightNode != null ? RightNode.IsBalanced() : true));
            }
        }
    }
}
