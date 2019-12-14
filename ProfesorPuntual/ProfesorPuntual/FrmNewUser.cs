using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfesorPuntual
{
    public partial class FrmNewUser : Form
    {
        public FrmNewUser()
        {
            InitializeComponent();
        }

        private void BttnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();//Cierro el programa
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmIndex ObjForm = new FrmIndex();
            ObjForm.Show();
            Close();
        }
    }
}
