using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aqua_AMS.Model;

namespace Aqua_AMS.View
{
    public partial class AddStudentUC : UserControl
    {
        IUserModel User;
        IStudentModel Student;
        IParentsModel ParentO;

        public AddStudentUC()
        {
            InitializeComponent();
            CLoad();
        }
        public void CLoad()
        {
            User = ModelFactory.CreateUser();
            ParentO = ModelFactory.CreateParent();
            Student = ModelFactory.CreateStudent();

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void PtnAddParent_Click(object sender, EventArgs e)
        {
            AddparentPanel.Visible = true;
        }

        private void BtnSaveParent_Click(object sender, EventArgs e)
        {
            ParentO.ParentName = txtparentName.Text;
            ParentO.ParentSSn = txtSsn.Text;
            ParentO.Phone = txtphone.Text;
            ParentO.address = txtaddress.Text;
            
            AddparentPanel.Visible = false;
        }

        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            DataPanel.Enabled = true;
            
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.s_ClassDataTableAdapter.Fill(this.aMS_DataDataSet.S_ClassData);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
