using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO_ESTRUCTURA.Entities;

namespace POO_ESTRUCTURA.Servicios
{
    public class AlumnoServicio
    {
        public Alumnos Agregar()
        {
            try
            {

                Alumnos alumnos2 = new Alumnos()
                {
                    Nombre = "Majo",
                    Apellido = "Sosa",
                    FechaIngreso = DateTime.Now,
                    Grado = 3,
                    Promedio = 0
                };
                return alumnos2;
            }
            catch(Exception ex)
            {
                throw new Exception ("Succedio un error" +ex.Message);

            }

           
        }
        public void Imprimir (Alumnos request)
        {
            try
            {

                Console.WriteLine("El nombre es:"+request.Nombre);
                Console.WriteLine("El apellido es:"+request.Apellido);
                Console.WriteLine("Ingreso el dia:"+request.FechaIngreso);
                Console.WriteLine("Esta en el grado"+request.Grado);

            }
            catch(Exception ex)
            {
                throw new Exception ("Succedio un error"+ex.Message);
            }
        }
        #region ----ValidarAprobacion
        public bool ValidarProm(double num1)
        {
            if (num1 >= 7)
            {
                validar = true;

            }
            return ValidarProm();
           
        }
        #endregion


    }
}
