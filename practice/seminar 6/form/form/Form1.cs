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

namespace form
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

            //load parent table data into the dataset
            this.daParent = new SqlDataAdapter("SELECT * FROM Users", sqlConn);
            SqlCommandBuilder cb = new SqlCommandBuilder(daParent);
            this.daParent.Fill(dataSet, "Users");

            //load child table data into the dataset, default player_id being 1
            this.daChild = new SqlDataAdapter("SELECT * FROM Posts WHERE uid=1", sqlConn);
            cb = new SqlCommandBuilder(daChild);
            this.daChild.Fill(dataSet, "Posts");

            //create a new relation representing the foreign key constraint of the 1:n relation
            DataRelation drel = new DataRelation("fk_posts_users", dataSet.Tables["Users"].Columns["id"],
                dataSet.Tables["Posts"].Columns["uid"]);
            this.dataSet.Relations.Add(drel);

            //create the binding sources for the parent and child tables
            bsParent = new BindingSource();
            bsParent.DataSource = dataSet;
            bsParent.DataMember = "Users";

            bsChild = new BindingSource();
            bsChild.DataSource = bsParent;
            bsChild.DataMember = "fk_posts_users";

            //fill the tableGridViews 
            this.dgvParent.DataSource = bsParent;
            this.dgvChild.DataSource = bsChild;
        }

        private string getConnectionString()
        {
            return "Data Source=DESKTOP-48S6415\\SQLEXPRESS;Initial Catalog=seminar6;Integrated Security=true";
        }
        private void updateDb_Click(object sender, EventArgs e)
        {
            this.daChild.Update(this.dataSet, "Posts");
            this.daParent.Update(this.dataSet, "Users");
        }
    }
}
