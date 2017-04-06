using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Models.Model;

namespace ProyectoParentesis.Validaciones
{
    public class Validacion
    {

        private Regex SoloLetras = new Regex(@"^[A-Za-z\s]+$"); // no numeros y no caracteres especiales         
        private Regex SoloNumeros = new Regex(@"^\d$"); // no numeros 
        private Match match;

        public bool ValidarTexto(String valor, String error)
        {
            if (String.IsNullOrEmpty(valor))
            {
                MessageBox.Show(error);

                return false;
            }

            return true;
        }


        public bool ValidarSoloLetras(String valor, String error)
        {            
            bool sw = this.SoloLetras.IsMatch(valor);
            if (!this.SoloLetras.IsMatch(valor))
            {
                MessageBox.Show(error);

                return false;
            }

            return true;
        }


        public bool ValidarSoloNumero(String valor, String error)
        {

            if (!this.SoloNumeros.IsMatch(valor))
            {
                MessageBox.Show(error);

                return false;

            }
            
            return true;
        }

        public bool ValidarFechaIngreso(DateTime date, String error)
        {

            if (date > DateTime.Now)
            {
                MessageBox.Show(error);

                return false;

           }
            return true;

        }

        public bool ClienteSinRepetir(String DNI, String error)
        {

            Cliente clientesinrepetir = new Cliente();

             clientesinrepetir.DNI = DNI;

             List<Cliente> clientes = ClienteRepository.Instance.getData(clientesinrepetir, false);

             if (clientes.Count > 0)
             {
                 MessageBox.Show(error);

                 return false;

             }
             return  true;

        }



    }
}
