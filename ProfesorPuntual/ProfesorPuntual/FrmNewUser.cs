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

        private void BttnSave_Click(object sender, EventArgs e)
        {
            //Asigno valores a las variables correspondientes y las utilizo para llenar un objeto profesor
            if (ValidateForm()) {
            Cls.ClsProfesor ObjProfesor;
            String NroFuncionario;
            String Nombre;
            String Mail;
            String Celular;
            NroFuncionario = TxtNroFuncionario.Text;
            Nombre = TxtNom.Text;
            Mail = TxtMail.Text;
            Celular = TxtCel.Text;
            ObjProfesor = new Cls.ClsProfesor(NroFuncionario, Nombre, Mail, Celular);
            ObjProfesor.ADocente(ObjProfesor);//Doy de alta el profesor
            }
        }
        private bool ValidateForm() {
            if (TxtNroFuncionario.Text == "") {
                LblVNro.Visible = true;
            }
            if (TxtNom.Text == "") {
                LblVNom.Visible = true;
            }
            if (TxtMail.Text == "") {
                LblVMail.Visible = true;
            }
            if (TxtCel.Text == "") {
                LblVCel.Visible = true;
            }
            if (!LblVNro.Visible || !LblVNom.Visible || !LblVMail.Visible || !LblVCel.Visible)
            {
                return true;
            }
            else {
                return false;
            }
        }
        private void TxtNroFuncionario_OnValueChanged(object sender, EventArgs e)
        {
        }

        private void TxtNroFuncionario_Enter(object sender, EventArgs e)
        {
            if (LblVNro.Visible) {//Si su label de advertencia está visible lo oculto
            LblVNro.Visible = false;
            }
        }

        private void TxtNom_Enter(object sender, EventArgs e)
        {
            if (LblVNom.Visible)
            {//Si su label de advertencia está visible lo oculto
                LblVNom.Visible = false;
            }
        }

        private void TxtMail_Enter(object sender, EventArgs e)
        {
            if (LblVMail.Visible)
            {//Si su label de advertencia está visible lo oculto
                LblVMail.Visible = false;
            }
        }

        private void TxtCel_Enter(object sender, EventArgs e)
        {
            if (LblVCel.Visible)
            {//Si su label de advertencia está visible lo oculto
                LblVCel.Visible = false;
            }
        }

        private void TxtNroFuncionario_Leave(object sender, EventArgs e)
        {
            if (TxtNroFuncionario.Text== "")
            {//Si un campo no tiene contenido lo advierto
                LblVNro.Visible = true;
            }
        }

        private void TxtNom_Leave(object sender, EventArgs e)
        {
            if (TxtNom.Text == "")
            {//Si un campo no tiene contenido lo advierto
                LblVNom.Visible = true;
            }
        }

        private void TxtMail_Leave(object sender, EventArgs e)
        {
            if (TxtMail.Text == "")
            {//Si un campo no tiene contenido lo advierto
                LblVMail.Visible = true;
            }
        }

        private void TxtCel_Leave(object sender, EventArgs e)
        {
            if (TxtCel.Text == "")
            {//Si un campo no tiene contenido lo advierto
                LblVCel.Visible = true;
            }
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
        private void TxtCel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))//Controlo que sólo se ingresen números
            {
                e.Handled = true;
            }
        }

        private void FrmNewUser_Load(object sender, EventArgs e)
        {
            //Modifico la cantidad de caracteres que pueden ser escritos en cada textbox
            SetMaximumLength(TxtNroFuncionario, 50);
            SetMaximumLength(TxtNom, 50);
            SetMaximumLength(TxtMail, 150);
            SetMaximumLength(TxtCel, 9);
        }
    }
}
