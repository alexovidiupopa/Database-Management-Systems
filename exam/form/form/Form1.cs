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
        // necessary objects 
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
        private String getConnectionString()
        {
            //Simple connection string getter, initial catalog coresponds to our db name
            return "Data Source=DESKTOP-48S6415\\SQLEXPRESS;Initial Catalog=coffee;Integrated Security=true";
        }

        private void loadData()
        {
            // create connection
            this.sqlConn = new SqlConnection(getConnectionString());

            this.dataSet = new DataSet();

            //load parent table data (CoffeeShops) into the dataset, with the corresponding name 
            this.daParent = new SqlDataAdapter("SELECT * FROM CoffeeShops", sqlConn);
            SqlCommandBuilder cb = new SqlCommandBuilder(daParent);
            this.daParent.Fill(dataSet, "CoffeeShops");

            //load child table data (Reviews) into the dataset, with the corresponding name, default foreign key id being 1 
            this.daChild = new SqlDataAdapter("SELECT * FROM Reviews WHERE sid=1", sqlConn);
            cb = new SqlCommandBuilder(daChild);
            this.daChild.Fill(dataSet, "Reviews");

            //create a new relation representing the foreign key constraint of the 1:n relation, taking the two tables from the previously created dataSet
            DataRelation drel = new DataRelation("fk_reviews_shops", dataSet.Tables["CoffeeShops"].Columns["sid"],
                dataSet.Tables["Reviews"].Columns["sid"]);
            this.dataSet.Relations.Add(drel);

            //create the binding sources for the parent and child tables
            bsParent = new BindingSource();
            bsParent.DataSource = dataSet;
            bsParent.DataMember = "CoffeeShops";

            bsChild = new BindingSource();
            bsChild.DataSource = bsParent;
            bsChild.DataMember = "fk_reviews_shops";

            //fill the DataGridViews 
            this.dgvCoffeeShops.DataSource = bsParent;
            this.dgvReviews.DataSource = bsChild;
        }


        
        private void updateDB_Click(object sender, EventArgs e)
        {
            // save the changes in the db. 
            //this.daParent.Update(this.dataSet, "CoffeeShops"); - saving the parent table is not required since it is specified in the task only to save the reviews table
            this.daChild.Update(this.dataSet, "Reviews");
        }
    }
}
