using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praciteAccounting {
    public partial class AddDepartment : Form {
        public AddDepartment() {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e) {
            DataBaseConnection.sqlCommandQuery("INSERT INTO departments (name_department) VALUES ('" + textBox1.Text + "')");
            MessageBox.Show("Отделение успешно добавлено", "Добавление отделения", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
