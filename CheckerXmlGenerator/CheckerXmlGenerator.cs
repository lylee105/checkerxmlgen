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
    public partial class CheckerXmlGenerator : Form
    {
        PopupWindow popup = null;
        TreeView refTree = null;
        ViewForm view = null;

        public CheckerXmlGenerator()
        {
            InitializeComponent();
            refTree = new TreeView();
        }

        public string[] getExamData()
        {
            string[] examData = examTextBox.Text.Split('\n');

            return examData;
        }

        public TreeView getTreeData()
        {
            return this.refTree;
        }

        private void refCreateBut_Click(object sender, EventArgs e)
        {
            popup = new PopupWindow(this.refTree);
            popup.Show();
        }

        private void viewBut_Click(object sender, EventArgs e)
        {
            view = new ViewForm(this);
            view.Show();
        }
   }
}
