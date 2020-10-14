using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRegEdit
{
    public partial class Form1 : Form
    {
        TreeNode Node;
        OpenFileDialog openFileDialog = new OpenFileDialog();

        List<Directory> directories = new List<Directory>();
        public Form1()
        {
            InitializeComponent();
            treeView1.ContextMenuStrip = cms_tv;
            CreateNode();
        }
        void aboutItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("О программе");
        }
        private void CreateNode()
        {
            TreeNode rootNode = new TreeNode();
            TreeNode treeNode = new TreeNode();
            TreeNode treeNode1 = new TreeNode();
            TreeNode treeNode2 = new TreeNode();
            TreeNode treeNode3 = new TreeNode();
            for (int i = 0; i < 5; i++)
            {
                rootNode.Text = "New folder 1" + i;
                treeView1.Nodes.Add(rootNode);
                directories.Add(new Directory(rootNode));
                
                treeNode1.Text = "New folder 3" + i;
                treeNode.Nodes.Add(treeNode1);
                directories.Add(new Directory(treeNode1));
                
                treeNode2.Text = "New folder 4" + i;
                treeNode1.Nodes.Add(treeNode2);
                directories.Add(new Directory(treeNode2));
                
                treeNode3.Text = "New folder 5" + i;
                treeNode2.Nodes.Add(treeNode3);
                directories.Add(new Directory(treeNode3));
            }
            for (int i = 0; i < 10; i++)
            {
                treeNode.Text = "New folder 2" + i;
                rootNode.Nodes.Add(treeNode);
                directories.Add(new Directory(treeNode));
            }
        }

        private void tsm_add_tv_Click(object sender, EventArgs e)
        {
            Node = new TreeNode();
            Node = treeView1.SelectedNode;
            TreeNode newNode = new TreeNode();
            newNode.Text = "new";
            Node.Nodes.Add(newNode);
        }

        private void tsm_remove_tv_Click(object sender, EventArgs e)
        {
            Node = new TreeNode();
            Node = treeView1.SelectedNode;
            Node.Remove();
        }

        private void toolStripTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                foreach (Directory directory in directories)
                {
                    if (directory.name == treeView1.SelectedNode.Text)
                    {
                        directory.variables.Add(new Variable(toolStripTextBox1.Text, toolStripComboBox1.Text, toolStripTextBox2.Text));
                    }
                }
                ListViewItem listViewItem = new ListViewItem(toolStripTextBox1.Text);
                listViewItem.SubItems.Add(toolStripComboBox1.Text);
                listViewItem.SubItems.Add(toolStripTextBox2.Text);
                listView.Items.Add(listViewItem);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listView.Items.Clear();
            foreach (Directory directory in directories)
            {
                if (directory.name == treeView1.SelectedNode.Text)
                {
                    foreach (Variable variable in directory.variables)
                    {
                        ListViewItem listViewItem = new ListViewItem(variable.Name);
                        listViewItem.SubItems.Add(variable.Type);
                        listViewItem.SubItems.Add(variable.Value);
                        listView.Items.Add(listViewItem);
                    }
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream("save.dat", FileMode.Create))
            {
                formatter.Serialize(stream, directories);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = openFileDialog.FileName;
                treeView1.SelectedNode = treeView1.Nodes[0];
                treeView1.SelectedNode.Remove();
                listView.Items.Clear();
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fileStream = new FileStream("save.dat", FileMode.OpenOrCreate))
                {
                    directories = (List<Directory>)formatter.Deserialize(fileStream);
                }
                foreach (Directory directory in directories)
                {
                    treeView1.Nodes.Add(directory.treeNode);
                }
            }
            catch
            {

            }
        }
    }
}
