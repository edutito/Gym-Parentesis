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
        private Regex SoloNumeros = new Regex(@"^[0-9]*$"); // no numeros 
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

        public bool ClienteYaPago(
            DateTime Fecha_Inicio,
            DateTime Fecha_Final,
            int Cliente_id, String Error)
        {
            if (PagoRepository.Instance.ClienteYaPagado(
             Fecha_Inicio,
             Fecha_Final,
             Cliente_id))
            {
                MessageBox.Show(Error);
                return false;
            }
            return true;
        }

        public bool solounpermisoporusuario(int usuario, int permiso)
        {

            Usuario_Permisos usupe = new Usuario_Permisos();

                usupe.Usuario_id = usuario;
                usupe.Permiso_id = permiso;

                if (Usuario_PermisosRepository.Instance.getData(usupe).Count > 0)
            {
                MessageBox.Show("Usuario ya posee permisos");

                return false;

            }
            return true;

        }

        public bool ContrasennaActual(String Contrasenna)
        {

            Usuario convrscon = Contenedor.Contenedor.getUsuario();


            if (Contrasenna != convrscon.Contrasena )
            {
                MessageBox.Show("Contraseña Actual no coincide");

                return false;

            }
            return true;

        }



        public bool ContrasennaNueva(String NuevaContrasenna, String ConfirmacionContrasenna)
        {

            if (NuevaContrasenna != ConfirmacionContrasenna)
            {
                MessageBox.Show("Contraseña Nueva No coincide con la de Confirmacion");

                return false;

            }
            return true;

        }




    }
}
