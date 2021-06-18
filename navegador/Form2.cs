using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace navegador
{
    public partial class navegador1 : Form
    {
        public navegador1()
        {
            InitializeComponent();
            navegador.GoHome();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
           navegador.Navigate(urltext.Text);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            navegador.GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            navegador.GoForward();

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            navegador.Stop();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            navegador.Refresh();

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            navegador.GoHome();
        }

        private void urltext_Click(object sender, EventArgs e)
        {
            //referencia a la propiedad AcceptButton

            

             
            
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton7_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripButton6_ButtonClick(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
