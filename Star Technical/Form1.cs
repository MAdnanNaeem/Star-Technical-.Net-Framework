using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Star_Technical
{
    public partial class Form1 : Form
    {

        private Button currentButton;
        private Random random;
        private int colorindex;
        private Form activeForm;




        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        private Color RandomColors()
        {

            int index = random.Next(Colors.ColorList.Count);

            while(colorindex == index)
            {
                index = random.Next(Colors.ColorList.Count);
            }
            colorindex = index;
            string color = Colors.ColorList[index];
            return ColorTranslator.FromHtml(color);

        }

        private void ActiveButton(object btnSender)
        {

            if(btnSender != null)
            {

                if(currentButton != (Button)btnSender)
                {
                    Disable_btn_Highlight();
                    Color color = RandomColors();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panel_title.BackColor = color;
                    panel_logo.BackColor = Colors.ChangeColorBrightness(color, -0.3);
                }
            }


        }


        private void OpenChildForm(Form childForm, object btnsender)
        {

            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActiveButton(btnsender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_dashbord.Controls.Add(childForm);
            this.panel_dashbord.Tag = childForm;
            childForm.BringToFront();
            childForm.Show(); 
            label_title.Text = childForm.Text;

        }

       

        private void Disable_btn_Highlight()
        {
            foreach(Control previousBtn in panel_menu.Controls)
            {
                if(previousBtn.GetType()== typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDashboard(), sender);
        }
       
        private void btn_employee_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEmployee(), sender);
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAdmin(), sender);
        }

        private void btn_task_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormTask(), sender);
        }

        private void btn_finance_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormFinance(), sender);
        }

        private void btn_docu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDocument(), sender);
        }


    }
}
