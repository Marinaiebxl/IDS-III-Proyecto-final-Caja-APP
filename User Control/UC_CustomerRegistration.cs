using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS_III_Proyecto_final_Caja_APP.User_Control
{
    public partial class UC_CustomerRegistration : UserControl

    {
        Function fn = new Function();
        string query;
        public UC_CustomerRegistration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void UC_CustomerRegistration_Load(object sender, EventArgs e)
        {

        }
        public void setComboBox(string query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query);
         // el while es para que lea los datos linea tras linea 
            while(sdr.Read())
            { 
                for (int i = 0; i< sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));  
                }
            }
            sdr.Close();

        } 

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Roomtypecmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select ID_Habitacion from Habitaciones where Bed limt = '" + Bedlimtcmbx.Text + "'and Room Type = '" + Roomtypecmbx.Text + "";
            setComboBox(query, RoomNocmbx);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bedlimtcmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Roomtypecmbx.SelectedIndex = -1;
        }

        private void RoomNocmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select price, ID_Habitacion from Habitaciones where ID_Habitacion = '" + RoomNocmbx.Text + "'  ";
            DataSet ds = fn.GetData(query);
            txtroomPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            // no se que esw rid y me dio erorr sin l 'int'
            int rid = int.Parse(ds.Tables[0].Rows[0][1].ToString());


        }

        private void AlloeRoombtn_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txtapellidos.Text != "" && txttelefono.Text != "" && txtcorreo.Text != "" && txtcorreo.Text != "")
            {
                String name = txtname.Text;
                String apellido = txtapellidos.Text;
                String Correo = txtcorreo.Text;
                String Checkin = checkin.Text;
                String Telefono = txttelefono.Text;

                // poner los campos de la tabla Huespedes
                query = "insert into Huespedes() values ('" +name+"', "+apellido+", '" +Correo+", '" +Checkin+", '" +Telefono+" )";
            }
            else
            {
                MessageBox.Show("los campos son mandatorios", "Informacion !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
