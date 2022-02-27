using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversCenter.PL
{
    public partial class Eleves_From : Form
    {
        public Eleves_From()
        {
            InitializeComponent();
        }

        private void Eleves_From_Load(object sender, EventArgs e)
        {
            DGV_Eleve.Rows.Add("12345","Mohamed");
        }
        

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void btn_AjouterEleve_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
