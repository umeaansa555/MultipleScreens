using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleScreens
{
    public partial class GameScreen : UserControl
    {
        public GameScreen()
        {
            InitializeComponent();

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);


            MenuScreen ms = new MenuScreen();
            f.Controls.Add(ms);
           
            ms.Focus();


            //Centre the screen on the Form
            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void returnButton_Enter(object sender, EventArgs e)
        {
            returnButton.BackColor = Color.Blue;
            exitButton.BackColor = Color.Gray;
        }

        private void exitButton_Enter(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.Blue;
            returnButton.BackColor = Color.Gray;
        }
    }
}
