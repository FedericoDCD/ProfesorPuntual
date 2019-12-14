using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfesorPuntual.Cls
{
    class ClsMensaje
    {
        //ATRIBUTOS
        private int ID;
        private String Asunto;
        private String Contenido;
        private DateTime Fecha;
        private int IDCausal;
        //GETTERS Y SETTERS
        public int GetID()
        {
            return ID;
        }
        public void SetID(int ID)
        {
            this.ID = ID;
        }
        public String GetAsunto()
        {
            return Asunto;
        }
        public void SetAsunto(String Asunto)
        {
            this.Asunto = Asunto;
        }
        public string GetContenido()
        {
            return Contenido;
        }
        public void SetContenido(String Contenido)
        {
            this.Contenido = Contenido;
        }
        public DateTime GetFecha()
        {
            return Fecha;
        }
        public void SetFecha(DateTime Fecha)
        {
            this.Fecha = Fecha;
        }
        public int GetIDCausal()
        {
            return IDCausal;
        }
        public void SetIDCausal(int IDCausal)
        {
            this.IDCausal = IDCausal;
        }
    }
}
