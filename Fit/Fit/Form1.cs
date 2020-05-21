using Business_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fit
{
    public partial class Form1 : Form
    {
        List<Category> categories;
        TreeNode rootNode = new TreeNode("Категории");
        TreeNode catNode;
        TreeNode prodNode;
        User user = new User();
        public Form1()
        {
            InitializeComponent();
            treeView1.ImageList = imageList1;
            treeView1.Nodes.Add(rootNode);
            for (int i = 0; i < categories.Count; i++)
            {
                catNode = new TreeNode(categories[i].name);
                catNode.ImageIndex = i + 1;
                catNode.SelectedImageIndex = i + 1;
                rootNode.Nodes.Add(catNode);
                for (int j = 0; j < categories[i].products.Count; j++)
                {
                    prodNode = new TreeNode(categories[i].products[j].name);
                    prodNode.ImageIndex = i + 1;
                    prodNode.SelectedImageIndex = i + 1;
                    catNode.Nodes.Add(prodNode);
                }
            }
        }
    }
}
