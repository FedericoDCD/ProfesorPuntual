using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfesorPuntual.Cls
{
    class MensajeDestinatario
    {
        //ATRIBUTOS
        private int ID;
        private int IDMensaje;
        private int IDDestinatario;
        //GETTERS Y SETTERS
        public int GetID()
        {
            return ID;
        }
        public void SetID(int ID)
        {
            this.ID = ID;
        }
        public int GetIDMensaje()
        {
            return IDMensaje;
        }
        public void SetIDMensaje(int IDMensaje)
        {
            this.IDMensaje = IDMensaje;
        }
        public int GetIDDestinatario()
        {
            return IDDestinatario;
        }
        public void SetIDDestinatario(int IDDestinatario)
        {
            this.IDDestinatario = IDDestinatario;
        }
    }
}
