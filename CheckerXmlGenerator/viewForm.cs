using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheckerXmlGenerator
{
    public partial class ViewForm : Form
    {
        public ViewForm(CheckerXmlGenerator gen)
        {
            InitializeComponent();
            SetTree(gen.getTreeData());
            
        }

        private void generateBut_Click(object sender, EventArgs e)
        {
          
        }

        private void SetTree(TreeView tr)
        {
            refTreeView.Nodes.Clear();
            foreach (TreeNode originalNode in tr.Nodes)
            {
                TreeNode newNode = new TreeNode(originalNode.Text);
                newNode.Tag = originalNode.Tag;
                refTreeView.Nodes.Add(newNode);
                IterateTreeNodes(originalNode, newNode);
            }
        }

        private void IterateTreeNodes(TreeNode originNode, TreeNode rootNode)
        {
            foreach (TreeNode childNode in originNode.Nodes)
            {
                TreeNode newNode = new TreeNode(childNode.Text);
                newNode.Tag = childNode.Tag;
                refTreeView.SelectedNode = rootNode;
                refTreeView.SelectedNode.Nodes.Add(newNode);
                IterateTreeNodes(childNode, newNode);
            }
        }
    }
}
