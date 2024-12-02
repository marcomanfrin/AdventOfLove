using System;
using System.Linq;
using System.Windows.Forms;



namespace AdventOfLove
{
    public partial class FormCalendar : Form
    {
        //int today = DateTime.Now.Day;
        private int today = 25;
        public FormCalendar()
        {
            InitializeComponent();
            EnableButtons(today);
        }

        private void EnableButtons(int today)
        {

            for (int i = 1; i <= 25; i++)
            {
                if (i > today)
                    return;
                string buttonName = $"button{i}";
                Button bottone = this.Controls.Find(buttonName, true).FirstOrDefault() as Button;
                if (bottone != null)
                {
                    bottone.Enabled = (i <= today);
                    bottone.Visible = (i <= today);
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            FormCit formCit = new FormCit(5);
            formCit.Show();
        }
    }
}