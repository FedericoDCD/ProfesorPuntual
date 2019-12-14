using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace ProfesorPuntual
{
    
    public partial class FrmBienvenido : Form
    {
        private static Form MyForm;
        public FrmBienvenido()
        {
            InitializeComponent();
        }

        private void BttnCLose_Click(object sender, EventArgs e)
        {
            Close();//Cierro el programa
        }

        private void FrmBienvenido_Load(object sender, EventArgs e)
        {//Creo un hilo con el método que carga el formulario de nuevos usuarios
            MyForm = new FrmBienvenido();
            Thread Tr = new Thread(LoadFormNewUsers);
            Tr.Start();
        }


        private void LoadFormNewUsers() {//Cargo el formulario de registro
            Thread.Sleep(5000);
            FrmNewUser ObjNewUser = new FrmNewUser();
            this.Invoke(new MethodInvoker(Close));//Invoco por separado el close del formulario para poder cerrarlo
            ObjNewUser.Show();
            Application.Run();//Permite que la app siga ejecutandose en el hilo
        }
    }
}
