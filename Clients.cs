using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Data;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VeloMax
{
    public partial class Clients :Form
    {
        public Clients()
        {
            InitializeCompenent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=NiluNilesh;Integrated Security=True");  
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;User Instance=True");
            SqlCommand cmd = new SqlCommand("sp_insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nom", textBox1.Text);
            cmd.Parameters.AddWithValue("@prenom", textBox2.Text);
            cmd.Parameters.AddWithValue("@adresse", textBox3.Text);
            cmd.Parameters.AddWithValue("@tel", textBox4.Text);
            cmd.Parameters.AddWithValue("@CP", textBox5.Text);
            cmd.Parameters.AddWithValue("@ville", textBox6.Text);
            cmd.Parameters.AddWithValue("@tel", textBox7.Text);
            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                MessageBox.Show(i + "Data Saved");
            }




        }

    }
}
