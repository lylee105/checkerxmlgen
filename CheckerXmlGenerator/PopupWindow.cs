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
    public partial class PopupWindow : Form
    {
        TreeView checker = null;
        public PopupWindow(TreeView gen)
        {
            InitializeComponent();
            this.checker = gen;
        }

        private void AddBut_Click(object sender, EventArgs e)
        {
            string refKind = refKindtextBox.Text;
            TreeNode node = new TreeNode(refKind);
            
            for (int i = 0; i < dataGridView.Rows.Count; i++ )
            {
                string refName = (string)dataGridView["refName", i].Value;
                string refLink = (string)dataGridView["refLink", i].Value;
                if (refName != null && refLink != null)
                {
                    TreeNode tn = node.Nodes.Add(refName);
                    tn.Nodes.Add(refLink);
                }
            }
            checker.Nodes.Add(node);

            this.Dispose();
            this.Close();

        }
    }
}
