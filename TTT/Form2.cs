using System;
using System.Media;
using System.Windows.Forms;

namespace TTT
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            if (PlXName.Text.Length == 0 && Pl0Name.Text.Length == 0)
            {
                MessageBox.Show(@"Enter players names!", @"Error");
                return;
            }
            var f = new Form1();
            f.PlayerXName = PlXName.Text;
            f.Player0Name = Pl0Name.Text;
            f.ShowDialog();
       }

    }
}
