using System.IO;

namespace TastaturSpiel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            string text = File.ReadAllText("C:\\VS\\50 DE Wörter.txt");
            string[] s = text.Split(',');

            for (int i = 0; i < 25; i++)
            {
                int randomNumber = random.Next(0, 51);
                label1.Text = label1.Text + s[randomNumber] + " ";
            }
        }

        public Random random = new Random();

    }
}