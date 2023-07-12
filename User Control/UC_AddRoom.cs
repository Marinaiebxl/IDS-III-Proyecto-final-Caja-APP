using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS_III_Proyecto_final_Caja_APP.Controllers
{
    public partial class UC_AddRoom : UserControl
    {
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void btnaddroom_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text != "" && guna2ComboBox1.Text != "" && guna2TextBox2.Text != "" && guna2ComboBox2.Text != "")
            {
                string roomnumber = guna2TextBox1.Text;
                string type = guna2ComboBox1.Text;
                string bed = guna2TextBox2.Text;
                Int64 price = Int64.Parse(guna2ComboBox2.Text);

                UC_AddRoom_Load(this, null);
            }
            else
            {
                MessageBox.Show("LLene todos los campos.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {

        }
    }
}
