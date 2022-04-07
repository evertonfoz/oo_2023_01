namespace POO.Validadores
{
    public class Strings
    {
        public static bool LengthEquals(string texto, int length)
        {
            return texto.Length == length;
        }

        public static bool LengthLessEquals(string texto, int length)
        {
            return texto.Length <= length;
        }
    }
}
