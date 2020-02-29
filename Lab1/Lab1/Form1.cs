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

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void deleteRecords_Click(object sender, EventArgs e)
        {
            String selectedId = view.SelectedCells[0].Value.ToString();
            SqlConnection conn = new SqlConnection
            {
                ConnectionString = "Data Source=ALEX-PC\\SQLEXPRESS01;Initial Catalog=Chess;Integrated Security=true"
            };
            
            try
            {
                conn.Open();
                SqlCommand firstDelete = new SqlCommand("DELETE FROM TournamentParticipantsHistory WHERE player_id IN (SELECT player_id FROM ChessPlayer WHERE club_id=" + selectedId + ")", conn);
                firstDelete.ExecuteNonQuery();
                SqlCommand cmd = new SqlCommand("DELETE FROM ChessPlayer WHERE club_id=" + selectedId, conn);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void updateRecord_Click(object sender, EventArgs e)
        {
            
            int playerId = int.Parse(textBox1.Text);
            String playerName = textBox2.Text.ToString();
            int rating = int.Parse(textBox3.Text);
            int titleId = int.Parse(textBox4.Text);
            int selectedId = int.Parse(view.SelectedCells[0].Value.ToString());
            SqlConnection conn = new SqlConnection
            {
                ConnectionString = "Data Source=ALEX-PC\\SQLEXPRESS01;Initial Catalog=Chess;Integrated Security=true"
            };
            try
            {    
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE ChessPlayer\nSET player_name = '" + playerName + "', rating = " + rating + ", title_id = " + titleId + "\nWHERE player_id=" + playerId + "AND club_id=" + selectedId + ";", conn);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException exc)
            {
                Console.WriteLine(exc.Message); 
            }
            finally
            {
                conn.Close();
            }
        }

        private void displayParent_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=ALEX-PC\\SQLEXPRESS01;Initial Catalog=Chess;Integrated Security=true";
            conn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ChessClub", conn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Fill(ds, "ChessClub");
            view.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void displayChild_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=ALEX-PC\\SQLEXPRESS01;Initial Catalog=Chess;Integrated Security=true";
            conn.Open();
            DataSet ds = new DataSet();
            String selectedId = view.SelectedCells[0].Value.ToString();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ChessPlayer WHERE club_id=" + selectedId, conn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Fill(ds, "ChessPlayer");
            view.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void addRecord_Click(object sender, EventArgs e)
        {
            int playerId = int.Parse(textBox1.Text);
            String playerName = textBox2.Text.ToString();
            int rating = int.Parse(textBox3.Text);
            int titleId = int.Parse(textBox4.Text);
            int selectedId = int.Parse(view.SelectedCells[0].Value.ToString());
            SqlConnection conn = new SqlConnection
            {
                ConnectionString = "Data Source=ALEX-PC\\SQLEXPRESS01;Initial Catalog=Chess;Integrated Security=true"
            };
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO ChessPlayer (player_id, player_name, rating, title_id, club_id) VALUES (" + playerId + ", '" + playerName + "', " + rating + ", " + titleId + ", " + selectedId + ");", conn);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
