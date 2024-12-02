using System;
using System.Linq;
using System.Windows.Forms;

namespace AdventOfLove
{
    public partial class Form1 : Form
    {
        int today = DateTime.Now.Day;
        public Form1()
        {
            InitializeComponent();
            enabeButtons(today);
        }

        private void enabeButtons(int today)
        {
            int giornoCorrente = DateTime.Now.Day;

            for (int i = 1; i <= 25; i++)
            {
                if (i > today)
                    return;
                string buttonName = $"button{i}";
                Button bottone = this.Controls.Find(buttonName, true).FirstOrDefault() as Button;
                if (bottone != null)
                {
                    bottone.Enabled = (i <= giornoCorrente);
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            FormCit formCit = new FormCit(today);
            formCit.Show();
        }
    }
}