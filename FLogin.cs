using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS_III_Proyecto_final_Caja_APP
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FLogin_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "Usuario1" && guna2TextBox2.Text == "12345")
            {
                FMain fmain  = new FMain();
                fmain.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Contraseña o nombre de usuario incorrectas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //label1.Visible = true;
                guna2TextBox2.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
