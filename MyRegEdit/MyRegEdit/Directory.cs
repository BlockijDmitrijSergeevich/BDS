using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRegEdit
{
    [Serializable]
    class Directory
    {
        public TreeNode treeNode;
        public List<Variable> variables = new List<Variable>();
        public string name;
        public Directory(TreeNode treeNode)
        {
            name = treeNode.Text;
            this.treeNode = treeNode;
        }
    }
}
