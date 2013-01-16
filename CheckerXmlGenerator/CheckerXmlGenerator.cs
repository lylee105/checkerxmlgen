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

        public CheckerXmlGenerator()
        {
            InitializeComponent();
            this.refTree = new TreeView();
        }

        private void ViewBut_Click(object sender, EventArgs e)
        {
            
        }

        private void refCreateBut_Click(object sender, EventArgs e)
        {
            popup = new PopupWindow();
            popup.Show();
        }

        private void setData()
        {

        }

        public void getData()
        {

        }
   }
}
