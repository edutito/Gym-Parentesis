using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoParentesis.Validaciones;
using Models.Model;


namespace ProyectoParentesis.Contenedor
{
    public static class Contenedor
    {
         private static Validacion validacion;
         private static Usuario usuario { get; set; }


         private static List<Usuario_Permisos> permitir { get; set; }

         static Contenedor( )
        {
            validacion   = new Validacion();
        }

        public static Validacion getValidacion()
        {
            return validacion;
        }

        public static Usuario getUsuario()
        {


            return usuario;
                
        }

        public static void setUsuario(Usuario u)
        {
            usuario = u;
            setPermitir(u.getUsuariosPermisos());

        }
        public static List<Usuario_Permisos> getPermitir()
        {
            
            return permitir ;

        }
        public static void setPermitir(List<Usuario_Permisos> per)
        {
            permitir = per;

        }

    }
}
