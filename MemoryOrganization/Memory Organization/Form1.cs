using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Memory_Organization.Allocation;
using Memory_Organization.Memory;

namespace Memory_Organization
{
    public partial class Form1 : Form
    {
        Manager manager = new Manager();
        public Form1()
        {
            InitializeComponent();                        
        }
        private void InitializeDump()
        {
            richTextBox1.Text = DumpToString();
            dump_lbl.Text = string.Format("Memory Dump {0} kB", manager.Segmenter.Capacity);
            UpdateNodeList();
            UpdateTaskList();
            RemoveTaskButton.Enabled = false;
            ChangeGroup.Enabled = false;
        }

        private string DumpToString()
        {
            StringBuilder builder = new StringBuilder();

            foreach (var segment in manager.Segmenter.Segments)
            {
                builder.Append(segment.ToString()).Append('\n');
            }

            return builder.ToString();
        }

        /*private byte[] ToBytes(int[] mas)
        {
            return mas.Select(x => (byte)x).ToArray();
        }
        private byte[] ToBytes(float[] mas)
        {
            return mas.Select(x => (byte)x).ToArray();
        }
        private byte[] ToBytes(char[] mas)
        {
            return mas.Select(x => (byte)x).ToArray();
        }*/
        private void UpdateNodeList()
        {
            NodeList.Items.Clear();

            foreach (var node in manager.Allocator.Nodes.Reverse())
            {
                NodeList.Items.Add(string.Format("{0}\t{1}\t{2} segments", node.IsFree, Segment.AddressFormat(node.Address), node.CountSegments));
            }
        }

        private void UpdateTaskList()
        {
            TaskList.Items.Clear();

            foreach (var task in manager.Tasks.Reverse())
            {
                TaskList.Items.Add(task);
            }
        }

        private void AddSegment_btn_Click(object sender, EventArgs e)
        {
            if (segmentSize2_rb.Checked) Segment.size = 2;
            else if (segmentSize4_rb.Checked) Segment.size = 4;
            else if (segmentSize8_rb.Checked) Segment.size = 8;
            else if (segmentSize16_rb.Checked) Segment.size = 16;
            else if (segmentSize32_rb.Checked) Segment.size = 32;

            segment_groupBox.Enabled = false;
            capacity_groupBox.Enabled = true;
            task_groupBox.Enabled = true;
        }

        private void Capacity_btn_Click(object sender, EventArgs e)
        {
            if (capacitySize16_gb.Checked) { manager.ResetMemory(16); }
            else if (capacitySize32_gb.Checked) { manager.ResetMemory(32); }
            else if (capacitySize64_gb.Checked) { manager.ResetMemory(64); }
            else if (capacitySize128_gb.Checked) { manager.ResetMemory(128); }
            else if (capacitySize256_gb.Checked) { manager.ResetMemory(256); }
            else if (capacitySize512_gb.Checked) { manager.ResetMemory(512); }

            InitializeDump();

            segment_groupBox.Enabled = true;
            capacity_groupBox.Enabled = false;
        }

        private void AddTask_btn_Click(object sender, EventArgs e)
        {
            if (manager.AddTask((int)taskSize_numUpDown.Value))
            {
                InitializeDump();
                UpdateTaskList();
                UpdateNodeList();
            }
        }

        private void TaskList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveTaskButton.Enabled = true;
            ChangeGroup.Enabled = true;
        }

        private void RemoveTaskButton_Click(object sender, EventArgs e)
        {
            int index = manager.Tasks.Count() - TaskList.SelectedIndex - 1;

            if (manager.RemoveTask(index))
            {
                InitializeDump();
            }
        }

        private void CopyByteButton_Click(object sender, EventArgs e)
        {
            int index = manager.Tasks.Count() - TaskList.SelectedIndex - 1;

            if (manager.CloneByte(index, (uint)FromNumeric.Value, (uint)ToNumeric.Value))
            {
                InitializeDump();
            }
        }
    }
}
