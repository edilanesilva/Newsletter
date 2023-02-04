using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cadastro_usuario_newsletter.Models
{
    public static class BaseDados
    {
       private static List<Usuario> usuarios = new List<Usuario>();

        public static void Incluir(Usuario u)
        {
            usuarios.Add(u);
        }
        
        public static List<Usuario> Listar()
        {
            return usuarios;
        }
    }
}