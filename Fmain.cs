using DS_III_Proyecto_final_Caja_APP.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;



namespace DS_III_Proyecto_final_Caja_APP
{
    public partial class FMain : Form
    {
        Function fn = new Function();
        public FMain()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /////
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FMain_Load(object sender, EventArgs e)
        {
            uC_CustomerRegistration1.Visible = false;
            uC_RoomRegistration1.Visible = false;
            uC_CreditCard1.Visible = false;
            uC_Services1.Visible = false;
            uC_Factura1.Visible = false;
            btnAddCustomers.PerformClick();

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uC_Services1.Visible = true;
            uC_Services1.BringToFront();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            uC_RoomRegistration1.Visible = true;
            //button2.PerformClick();
            uC_RoomRegistration1.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            uC_CustomerRegistration1.Visible = true;
            uC_CustomerRegistration1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            uC_Factura1.Visible = true;
            uC_Factura1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            uC_CreditCard1.Visible = true;
            uC_CreditCard1.BringToFront();
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void uC_CustomerRegistration1_Load(object sender, EventArgs e)
        {

        }
    }
}
