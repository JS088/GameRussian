using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameRussian
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
            //by clicking the  start button the  home page will display
        {
            (new gamkke()).Show();
            this.Hide();
        }
    }
}
