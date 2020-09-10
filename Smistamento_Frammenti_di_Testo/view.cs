using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smistamento_Frammenti_di_Testo
{
    public partial class view : Form
    {
        private Controller controller;

        public view()
        {
            
            InitializeComponent();
            
        }

        private void esegui_Click(object sender, EventArgs e)
        {
                controller = new Controller(textBox1.Text, textBox2.Text);
                MessageBox.Show(controller.esegui(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
