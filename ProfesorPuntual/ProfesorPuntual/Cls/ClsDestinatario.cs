using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfesorPuntual.Cls
{
    class ClsDestinatario
    {
        //ATRIBUTOS
        private int ID;
        private String Curso;
        private String Nombre;
        private String Mail;
        private String Numero;
        private int IDTipo;
        //GETTERS Y SETTERS
        public int GetID()
        {
            return ID;
        }
        public void SetID(int ID)
        {
            this.ID = ID;
        }
        public String GetCurso()
        {
            return Curso;
        }
        public void SetCurso(String Curso)
        {
            this.Curso = Curso;
        }
        public String GetNombre()
        {
            return Nombre;
        }
        public void SetNombre(String Nombre)
        {
            this.Nombre = Nombre;
        }
        public String GetMail()
        {
            return Mail;
        }
        public void SetMail(String Mail)
        {
            this.Mail = Mail;
        }
        public String GetNumero()
        {
            return Numero;
        }
        public void SetNumero(String Numero)
        {
            this.Numero = Numero;
        }
        public int GetIDTipo()
        {
            return IDTipo;
        }
        public void SetIDTipo(int IDTipo)
        {
            this.IDTipo = IDTipo;
        }
        //CONSTRUCTORES
        public ClsDestinatario(String Curso, String Nombre, String Mail,String Numero, int IDTipo) {
            this.Curso = Curso;
            this.Nombre = Nombre;
            this.Mail = Mail;
            this.Numero = Numero;
            this.IDTipo = IDTipo;
        }
        public ClsDestinatario() {
        }
    }
}
