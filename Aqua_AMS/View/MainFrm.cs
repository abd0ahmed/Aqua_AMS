using System;
using System.Windows.Forms;

namespace Aqua_AMS.View
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }
        private void showSubmenue(Panel Menu)
        {
            if (!Menu.Visible)
            {
                Menu.Visible = true;
            }
            else Menu.Visible = false;



        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnFullscreen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnNormalScreen.Visible = true;
            
            BtnFullscreen.Visible = false;
        }

        private void BtnNormalScreen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnFullscreen.Visible = true;
            BtnNormalScreen.Visible = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sidepanel.Width == 194)
            {
                sidepanel.Width = 42;
                btnInfo.Visible = false;
                pictureBox1.Visible = true;

            }
            else
            {
                sidepanel.Width = 194;
                btnInfo.Visible = true;
                pictureBox1.Visible = false;
            }
               
                
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MainFrm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void MainFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control&&e.KeyCode==Keys.X)
            {
                this.Hide();
                LoginFrm frm = new LoginFrm();
                frm.Show();


            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            showSubmenue(StudentsPanel);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            showSubmenue(AdminPanel);
        }

        private void BtnClasses_Click(object sender, EventArgs e)
        {
            ClassesUC uc = new ClassesUC();
            showUC(uc);
        }
        public void showUC(UserControl UC)
        {
            UC.Dock = DockStyle.Fill;
            BodyPanel.Controls.Add(UC);
            UC.BringToFront();


        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {

            ShiftUC uc = new ShiftUC();
            showUC(uc);
        }

        private void BtnGrades_Click(object sender, EventArgs e)
        {
            GradesUC uc = new GradesUC();
            showUC(uc);
        }

        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentUC uc = new AddStudentUC();
            showUC(uc);
        }
    }
}
