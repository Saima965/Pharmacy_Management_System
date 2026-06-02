using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.CustomerUC
{
    public partial class UC_C_ViewMedicine : UserControl
    {
        function fn = new function();
        String query;

        public UC_C_ViewMedicine()
        {
            InitializeComponent();
        }

        private void setDataGridView(String query)
        {
            DataSet dataSet = fn.getData(query);
            guna2DataGridView1.DataSource = dataSet.Tables[0];
        }

        private void UC_C_ViewMedicine_Load(object sender, EventArgs e)
        {
            query = "select * from medic";
            setDataGridView(query);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from medic where mname like'" + txtSearch.Text + "%'";
            setDataGridView(query);
        }

        String medicineId;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                medicineId = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
