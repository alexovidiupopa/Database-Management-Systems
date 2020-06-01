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

namespace solution
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
            this.daParent = new SqlDataAdapter("SELECT * FROM Publishers", sqlConn);
            SqlCommandBuilder cb = new SqlCommandBuilder(daParent);
            this.daParent.Fill(dataSet, "Publishers");

            //load child table data into the dataset, default player_id being 1
            this.daChild = new SqlDataAdapter("SELECT * FROM Books WHERE pid=1", sqlConn);
            cb = new SqlCommandBuilder(daChild);
            this.daChild.Fill(dataSet, "Books");

            //create a new relation representing the foreign key constraint of the 1:n relation
            DataRelation drel = new DataRelation("fk_books_publishers", dataSet.Tables["Publishers"].Columns["id"],
                dataSet.Tables["Books"].Columns["pid"]);
            this.dataSet.Relations.Add(drel);

            //create the binding sources for the parent and child tables
            bsParent = new BindingSource();
            bsParent.DataSource = dataSet;
            bsParent.DataMember = "Publishers";

            bsChild = new BindingSource();
            bsChild.DataSource = bsParent;
            bsChild.DataMember = "fk_books_publishers";

            //fill the tableGridViews 
            this.dgvParent.DataSource = bsParent;
            this.dgvChild.DataSource = bsChild;

        }

        private string getConnectionString()
        {
            return "Data Source=DESKTOP-48S6415\\SQLEXPRESS;Initial Catalog=library;Integrated Security=true";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.daChild.Update(this.dataSet, "Books");
            this.daParent.Update(this.dataSet, "Publishers");
        }
    }
}
