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
        private SqlConnection sqlConn;
        private DataSet dataSet;
        private SqlDataAdapter daParent, daChild;
        private DataRelation dataRelation;
        private BindingSource bsParent, bsChild;

        public Form1()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            this.sqlConn = new SqlConnection(getConnectionString());

            this.dataSet = new DataSet();

            this.daParent = new SqlDataAdapter("SELECT * FROM ChessPlayer", sqlConn);
            SqlCommandBuilder cb = new SqlCommandBuilder(daParent);
            this.daParent.Fill(dataSet, "ChessPlayer");
            this.daChild = new SqlDataAdapter("SELECT * FROM FideStandings WHERE player_id=1", sqlConn);
            cb = new SqlCommandBuilder(daChild);
            this.daChild.Fill(dataSet, "FideStandings");

            DataRelation drel = new DataRelation("fk_standings_players", dataSet.Tables["ChessPlayer"].Columns["player_id"],
                dataSet.Tables["FideStandings"].Columns["player_id"]);
            this.dataSet.Relations.Add(drel);
            bsParent = new BindingSource();
            bsParent.DataSource = dataSet;
            bsParent.DataMember = "ChessPlayer";

            bsChild = new BindingSource();
            bsChild.DataSource = bsParent;
            bsChild.DataMember = "fk_standings_players";

            this.view.DataSource = bsParent;
            this.viewChildren.DataSource = bsChild;
        }
        

        private void updateDb_Click(object sender, EventArgs e)
        {
            this.daChild.Update(this.dataSet, "FideStandings");
        }

       
        private String getConnectionString()
        {
            return "Data Source=DESKTOP-48S6415\\SQLEXPRESS;Initial Catalog=Chess4;Integrated Security=true";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
