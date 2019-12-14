using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfesorPuntual.Cls
{
    class Causal
    {
        //ATRIBUTOS
        private int ID;
        private String Nombre;
        //GETTERS Y SETTERS
        public int GetID()
        {
            return ID;
        }
        public void SetID(int ID)
        {
            this.ID = ID;
        }
        public String GetNombre()
        {
            return Nombre;
        }
        public void SetNombre(String Nombre)
        {
            this.Nombre = Nombre;
        }
    }
}
