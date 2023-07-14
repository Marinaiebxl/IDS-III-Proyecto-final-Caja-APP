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
        Function fn = new Function();
        string query;

        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void btnaddroom_Click(object sender, EventArgs e)
        {
            if ( txtroomtype.Text != "" && txtPrice.Text != "" && txtlimit.Text != "")
            {
                string type = txtroomtype.Text;
                Int64 limit = Int64.Parse(txtlimit.Text);
                Int64 price = Int64.Parse(txtPrice.Text);

                query = "INSERT INTO Habitaciones (Descripcion, Limite, precio_por_noche) values ('" + type + "', '" + limit + "', '" + price + "')";
                fn.setData(query, "Habitación añadida.");

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
            txtroomtype.Clear();
            txtlimit.Clear();
            txtPrice.Clear();

        }    

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            query = "select * from Habitaciones";
            DataSet ds = fn.GetData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }

        private void UC_AddRoom_Leave(object sender, EventArgs e)
        {
            clearALL();
        }

        private void UC_AddRoom_Enter(object sender, EventArgs e)
        {
            UC_AddRoom_Load(this, null);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtroomtype_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlimit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
