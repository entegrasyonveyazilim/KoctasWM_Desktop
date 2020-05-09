using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Koctas_VM_Desktop
{
    public partial class Popupform : Form
    {
        public string ReturnValue1 { get; set; }
        public Popupform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReturnValue1 = textBox1.Text;
            this.Close();
        }
    }


}
