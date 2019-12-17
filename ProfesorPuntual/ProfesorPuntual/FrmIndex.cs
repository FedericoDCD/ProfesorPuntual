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
    public partial class FrmIndex : Form
    {
        public FrmIndex()
        {
            InitializeComponent();
        }

        private void FrmIndex_Load(object sender, EventArgs e)
        {
            Cls.ClsProfesor ObjProfesor = new Cls.ClsProfesor();
            DataTable Teacher, Functionaries, Delegate, Receivers, Messages;
            Teacher = ObjProfesor.BuscarDocentes();
            Functionaries = ObjProfesor.BuscarFuncionario();
            Delegate = ObjProfesor.BuscarDelegados();
            Receivers = ObjProfesor.BuscarDestinatarios();
            Messages = ObjProfesor.BuscarMensajes();
            LblNom.Text = Teacher.Rows[0][1].ToString();//Muestro el docente logueado
            IndGVFunc.DataSource = Functionaries;//Cargo los datagridviews
            IndGVDel.DataSource = Delegate;
            DestGVDest.DataSource = Receivers;
            MensajesGMens.DataSource = Messages;

        }
        
        private void BttnIndex_Click(object sender, EventArgs e)
        {//oculto el resto de marcadores y muestro el seleccionado
            PBXInicio.Visible = true;
            PBXTo.Visible = false;
            PBXMessage.Visible = false;
            PnlIndex.Visible = true;
            PnlMessage.Visible = false;
            PnlTo.Visible = false;
        }

        private void BttnTo_Click(object sender, EventArgs e)
        {//oculto el resto de marcadores y muestro el seleccionado
            PBXInicio.Visible = false;
            PnlIndex.Visible = false;
            PBXTo.Visible = true;
            PBXMessage.Visible = false;
            PnlMessage.Visible = false;
            PnlTo.Visible = true;
        }

        private void BttnMessage_Click(object sender, EventArgs e)
        {//oculto el resto de marcadores y muestro el seleccionado
            PBXInicio.Visible = false;
            PBXTo.Visible = false;
            PBXMessage.Visible = true;
            PnlIndex.Visible = false;
            PnlTo.Visible = false;
            PnlMessage.Visible = true;
        }

        private void BttnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();//cierro el programa
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void PnlIndex_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PnlTo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
