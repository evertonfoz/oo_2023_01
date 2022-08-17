using System.Text.RegularExpressions;

namespace POO.Validadores
{
    public class Numericos
    {
        public static bool EhNumerico(string valor)
        {
            Regex regex = new Regex(@"^-?[0-9][0-9,\.]+$");
                return regex.IsMatch(valor);
        }

        public static bool EhNumerico(char valor)
        {
            return !("0123456789".IndexOf(valor) == -1
                && !Char.IsControl(valor)); 
        }
    }
}
