using System;
using System.Linq;
using System.Windows.Forms;

namespace AdventOfLove
{
    public partial class FormCalendar : Form
    {
        private int today = DateTime.Now.Day;
        //private int today = 25;
        public FormCalendar()
        {
            InitializeComponent();
            AssignButtonsTags();
            EnableButtons(today);
        }
        private void AssignButtonsTags()
        {
            for (int i = 1; i <= 25; i++)
            {
                Button button = this.Controls.Find($"button{i}", true).FirstOrDefault() as Button;

                if (button != null)
                {
                    button.Tag = i;
                }
                else
                {
                    Console.WriteLine($"Bottone con nome button{i} non trovato.");
                }
            }
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
            Button button = sender as Button;

            if (button != null)
            {
                int buttonId = (int)button.Tag;
                FormCit formCit = new FormCit(buttonId);
                formCit.Show();
            }
            else
            {
                FormCit formCit = new FormCit(0);
                formCit.Show();
            }
        }
    }
}