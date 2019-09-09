using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_instrutor
{
    static class Autenticação
    {
        static string login;
        static string senha;
        static int nivel;

        public static void logar(string login1, string senha1, int nivel1)
        {
            login = login1;
            senha = senha1;
            nivel = nivel1;
        }

        public static void logaut()
        {
            login = null;
            senha = null;
            nivel = 0;
        }
        public static String getUsuario()
        {
            return "Nome: " + login + "\nSenha: " + senha + "\nNivel: " + nivel;

        }

        internal static void logar(object v)
        {
            throw new NotImplementedException();
        }
    }
}
