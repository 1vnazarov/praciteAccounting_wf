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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace praciteAccounting {
    public partial class DepartmentsForm : Form {
        public DepartmentsForm() {
            InitializeComponent();
        }
        private string[] keys = { "id_department", "name_department" };
        private void refresh() {
            DataTable dt = DataBaseConnection.dataAdapterSelect("SELECT * FROM departments");
            dataGridView1.Rows.Clear();
            foreach (DataRow dr in dt.Rows) {
                dataGridView1.Rows.Add(dr["id_department"], dr["name_department"]);
            }
        }
        private void DepartmentsForm_Load(object sender, EventArgs e) {
            refresh();
        }

        private void refresh_button_Click(object sender, EventArgs e) {
            refresh();
        }

        private void add_button_Click(object sender, EventArgs e) {
            new AddDepartment().Show();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            DataBaseConnection.sqlCommandQuery("UPDATE departments SET " + keys[e.ColumnIndex] + " =  '" + dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() + "' WHERE id_department = " + e.RowIndex + 1);
        }
    }
}
