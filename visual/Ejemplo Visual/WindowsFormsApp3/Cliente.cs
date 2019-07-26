using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace WindowsFormsApp3
{
    class Cliente
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }

        public Cliente() { }

        public Cliente(int pId, string pNombre, string pApellido, string pDireccion, string pTelefono)
        {
            this.id = pId;
            this.nombre = pNombre;
            this.apellido = pApellido;
            this.direccion = pDireccion;
            this.telefono = pTelefono;
        }




    }
}
