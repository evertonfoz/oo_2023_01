using System.Text.RegularExpressions;

namespace Aula02_POO_Introducao_Linguagem_C.Validadores
{
    internal class ValidadoresNumericos
    {
        public static bool EhNumerico(string valor)
        {
            Regex regex = new Regex(@"^-?[0-9][0-9,\.]+$");
                return regex.IsMatch(valor);
        }
    }
}
