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
            if (txtRoomNumber.Text != "" && cbroomtype.Text != "" && txtPrice.Text != "" && cbBed.Text != "")
            {
                string roomnumber = txtRoomNumber.Text;
                string type = cbroomtype.Text;
                string bed = txtPrice.Text;
                Int64 price = Int64.Parse(cbBed.Text);

                UC_AddRoom_Load(this, null);
                clearALL();
            }
            else
            {
                MessageBox.Show("LLene todos los campos.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public void clearALL()
        {
            txtRoomNumber.Clear();
            cbroomtype.SelectedIndex = -1;
            cbBed.SelectedIndex = -1;
            txtPrice.Clear();

        }    

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {

        }

        private void UC_AddRoom_Leave(object sender, EventArgs e)
        {
            clearALL();
        }

        private void UC_AddRoom_Enter(object sender, EventArgs e)
        {
            UC_AddRoom_Load(this, null);
        }
    }
}
