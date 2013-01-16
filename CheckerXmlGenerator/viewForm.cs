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
        CheckerXmlGenerator checker = null;

        public ViewForm(CheckerXmlGenerator gen)
        {
            InitializeComponent();
            this.checker = gen;
            checker.
            refTreeView
        }

        private void generateBut_Click(object sender, EventArgs e)
        {
          
        }

    }
}
