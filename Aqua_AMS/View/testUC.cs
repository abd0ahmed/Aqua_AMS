using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aqua_AMS.Database;
using Aqua_AMS.Model;

namespace Aqua_AMS.View
{
    public partial class testUC : UserControl
    {
        public testUC()
        {
            InitializeComponent();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void test_Load(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.DataSource = DataAccess.selectAllParents();
        }
    }
}
