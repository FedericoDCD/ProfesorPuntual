using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfesorPuntual.Cls
{
    class ClsProfesor
    {
        //ATRIBUTOS
        private int NroFuncionario;
        private String Nombre;
        private String Mail;
        private String Numero;
        //GETTERS Y SETTERS
        public int GetNroFuncionario() {
            return NroFuncionario;
        }
        public void SetNroFuncionario(int NroFuncionario) {
            this.NroFuncionario = NroFuncionario;
        }
        public string GetNombre()
        {
            return Nombre;
        }
        public void SetNombre(String Nombre)
        {
            this.Nombre = Nombre;
        }
        public string GetMail()
        {
            return Mail;
        }
        public void SetMail(String Mail)
        {
            this.Mail = Mail;
        }
        public string GetNumero()
        {
            return Nombre;
        }
        public void SetNumero(String Numero)
        {
            this.Numero = Numero;
        }
    }
}
