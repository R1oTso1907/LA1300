using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class startMenu : Form
    {
        public startMenu()
        {
            InitializeComponent();
        }

        private void LoadGame(object sender, EventArgs e)
        {
            this.Hide();   

            VegeterianRun gamewindow = new VegeterianRun();
            gamewindow.ShowDialog();

            this.Close();
               
        }

        private void Help_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Helpwindow helpwindow = new Helpwindow(); 
            helpwindow.ShowDialog();
            this.Close();
        }
    }
}
