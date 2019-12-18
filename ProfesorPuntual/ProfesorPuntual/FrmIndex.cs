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
            DataTable Results;
            Results = ObjProfesor.BuscarTipoDestinatario();
            for (int i = 0; i < Results.Rows.Count; i++)
            {
                DestCBTipo.AddItem(Results.Rows[i][1].ToString());
            }
        }
        private void SetMaxTextBox() {

            //Destinatarios
            SetMaximumLength(DestTxtCurso, 100);
            SetMaximumLength(DestTxtNom, 50);
            SetMaximumLength(DestTxtMail, 150);
            SetMaximumLength(DestTxtNum, 50);

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

        private void DestBttnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidateFormDest()) {//Si supera el filto de la validación agrego el destinatario
               AddTo();
            }
        }
        private void AddTo() {
            Cls.ClsDestinatario ObjDestinatario;
            Cls.ClsProfesor ObjProfesor = new Cls.ClsProfesor();
            String Curso;
            String Nombre;
            String Mail;
            String Celular;
            DataTable Receivers;
            int IDTipo;
            Curso = DestTxtCurso.Text;
            Nombre = DestTxtNom.Text;
            Mail = DestTxtMail.Text;
            Celular = DestTxtNum.Text;
            IDTipo = (DestCBTipo.selectedIndex + 1);
            ObjDestinatario = new Cls.ClsDestinatario(Curso, Nombre, Mail, Celular, IDTipo);//Guardi el Destinatario
            ObjProfesor.ADestinatario(ObjDestinatario);//Inserto el destinatario
            Receivers = ObjProfesor.BuscarDestinatarios();
            DestGVDest.DataSource = Receivers;//Cargo el gridview con los nuevos datos
        }
        private void SetMaximumLength(Bunifu.Framework.UI.BunifuMaterialTextbox MaterialTextbox, int maximumLength)//Setea el largo de los datos ingresados en un material textbox
        {
            foreach (Control ctl in MaterialTextbox.Controls)
            {
                if (ctl.GetType() == typeof(TextBox))
                {
                    var txt = (TextBox)ctl;
                    txt.MaxLength = maximumLength;

                    // Set other properties & events here...
                }
            }
        }
        private bool ValidateFormDest() {//Corrobora que los datos necesarios hayan sido ingresados y si lo son retorna true
            bool CanAdd = true;
            if (DestTxtCurso.Text == "")
            {
                DestLblVCurso.Visible = true;
                CanAdd = false;
            }
            if (DestTxtMail.Text == "")
            {
                DestLblVMail.Visible = true;
                CanAdd = false;
            }
            if (DestTxtNom.Text == "") {
                DestLblVNom.Visible = true;
                CanAdd = false;
            }
            if (DestCBTipo.selectedIndex == -1){
                DestLbVTipo.Visible = true;
                CanAdd = false;
            }
            return CanAdd;
        }
        private void DestCBTipo_onItemSelected(object sender, EventArgs e)
        {
            DestLbVTipo.Visible = false;//si hay algo seleccionado oculto el label de error 
        }

        private void DestTxtCurso_Enter(object sender, EventArgs e)
        {
            DestLblVCurso.Visible = false;
        }

        private void DestTxtNom_Enter(object sender, EventArgs e)
        {
            DestLblVNom.Visible = false;
        }

        private void DestTxtMail_Enter(object sender, EventArgs e)
        {
            DestLblVMail.Visible = false;
        }
    }
}
