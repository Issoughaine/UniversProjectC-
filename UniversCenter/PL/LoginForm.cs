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
    public partial class LoginForm : Form
    {
        BL.loginCls login = new BL.loginCls();
        public LoginForm()
        {
            InitializeComponent();
        }

        PL.msgBox MessageShow;
        private void btnConnecte_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = login.Login(TB_username.Text, TB_password.Text);
                if (dt.Rows.Count > 0)
                {
                    formChoix fc = new formChoix();
                    fc.Show();
                    this.Hide();
                }
                else
                {
                    MessageShow = new PL.msgBox();
                    MessageShow.lbl_Titre.Text = "Erreur de connection";
                    MessageShow.lbl_Message.Text = "Le nom d'utilisateur ou le mot de pass est incorrect";
                    MessageShow.btnOk.Click += delegate
                    {
                        MessageShow.Close();
                    };
                    MessageShow.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
