using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    public class Persona
    {
        private string _Nombre, _Apellido;
        private DateTime _FechaNac;
        public string Nombre
        {
            set
            {
                _Nombre = value;
            }
            get
            {
                return _Nombre;
            }
        }
        public string Apellido
        {
            set
            {
                _Apellido = value;
            }
            get
            {
                return _Apellido;
            }
        }
        public DateTime FechaNac
        {
            set
            {
                _FechaNac = value;
            }
            get
            {
                return _FechaNac;
            }
        }
        public Persona (string nombre, string apellido, DateTime fechaNac)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNac = fechaNac;
        }
        public int GetEdad()
        {
            int edad = DateTime.Today.AddTicks(-FechaNac.Ticks).Year - 1;

            ///double dias = (DateTime.Today - FechaNac).TotalDays;
            Console.WriteLine(edad);
            return edad;
        }



    }

    
}
