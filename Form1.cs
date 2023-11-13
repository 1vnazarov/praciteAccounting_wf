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

namespace praciteAccounting {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void отделенияToolStripMenuItem_Click(object sender, EventArgs e) {
            new DepartmentsForm().Show();
        }

        private void department_button_Click(object sender, EventArgs e) {
            new DepartmentsForm().Show();
        }
    }
}
