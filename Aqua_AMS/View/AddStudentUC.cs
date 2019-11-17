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
using Aqua_AMS.Database;

namespace Aqua_AMS.View
{
    public partial class AddStudentUC : UserControl
    {
#region Models
        IUserModel User;
        IStudentModel Student;
        IParentsModel ParentO;
        IGradesModel Grade;
        IClassModel Class;
        IShiftModel shift;
#endregion
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
        public void Dload()
        {
            Grade = ModelFactory.Creategrade();
            Class = ModelFactory.CreateClass();
            shift = ModelFactory.CreateShift();
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
            string ID=  DataAccess.InsertParent(ParentO).ToString();
            if (!string.IsNullOrEmpty(ID))
            {
                AddparentPanel.Visible = false;
                label2.Visible = true;
                txtsubmitSsn.Enabled = false;
                label2.Text = ID;
                txParentName.Text= txtparentName.Text;
                txtsubmitSsn.Text = txtSsn.Text;
                
            }
            
        }
        private void ResetUC()
        {
            txtstuName.Text = "";
            txtaddress.Text = "";
            txtphone.Text = "";
            txtSsn.Text = "";
            txtsubmitSsn.Text ="" ;
            txParentName.Text = "";
        }
        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            
            DataPanel.Enabled = true;
            
        }
        private void txtsubmitSsn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData==Keys.Enter || e.KeyData==Keys.Return)
            {
                ParentO = ModelFactory.CreateParent();
                ParentO = DataAccess.SelectParentBySSn(txtsubmitSsn.Text).FirstOrDefault();
                txParentName.Text = ParentO.ParentName;
                label2.Text = ParentO.ParentID.ToString() ;
                label2.Visible = true;
                
            }
        }
        public void LoadDDGrades()
        {
            List<GradesModel> Grades = DataAccess.SelectAllGrids();
            ComboBox com = (ComboBox)DDGrade.Controls.Find("Collections", true).First();
            com.DataSource = Grades;
            com.DisplayMember = "GradeName";
            com.ValueMember = "GradeID";
        }
        public void LoadDDClasses()
        {
            List<ClassModel> Classses = DataAccess.SelectAllClasses();
            ComboBox com = (ComboBox)DDclass.Controls.Find("Collections", true).First();
            com.DataSource = Classses;
            com.DisplayMember = "ClassName";
            com.ValueMember = "ClassID";
        }
        public void LoadDDShifts()
        {
            List<ShiftModel> shifts = DataAccess.SelectAllShifts();
            ComboBox com = (ComboBox)DDtimeP.Controls.Find("Collections", true).First();
            com.DataSource = shifts;
            com.DisplayMember = "ShiftName";
            com.ValueMember = "ShiftId";
        }
        public void LoadDatatable()
        {
            datagrid1.DataSource = DataAccess.selectClassesWithCount();
        }
        private void AddStudentUC_Load(object sender, EventArgs e)
        {
            LoadDDGrades();
            LoadDDClasses();
            LoadDDShifts();
            LoadDatatable();
        }
        private void AddStudentUC_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
        public void collectData()
        {
            Dload();
           
            ComboBox com1 = (ComboBox)DDtimeP.Controls.Find("Collections", true).First();
            shift = com1.SelectedItem as ShiftModel;
            ComboBox com = (ComboBox)DDclass.Controls.Find("Collections", true).First();
            Class = com.SelectedItem as ClassModel;
            ComboBox com2 = (ComboBox)DDGrade.Controls.Find("Collections", true).First();
            Grade = com2.SelectedItem as GradesModel;
            Student.StudentName = txtstuName.Text;
            Student.DOP = DpDop.Value.Date;
            Student.dataAdded = DateTime.Now;
            Student.ParentID = ParentO.ParentID;
            Student.ShiftID = shift.ShiftID;
            Student.StudentClass = Class.ClassID;
            Student.StudentGrid = Grade.GradeID;

        }
        public void SaveNewStudent()
        {

            collectData();
            DataAccess.InsertNewStudent(Student);
            DataPanel.Enabled = false;
            MessageBox.Show("Saved");


        }
        private void BtnSaveStudent_Click(object sender, EventArgs e)
        {
            SaveNewStudent();
            LoadDatatable();
            ResetUC();
        }
    }
}
