using POO.Validadores;

namespace Aula03_POO_Associações_Windows_Forms.Controladores
{
    internal class EstudanteController
    {
        public static bool 
            RegistroAcademicoEhValido(string registroAcademico)
        {
            return Strings.LengthEquals(
                    registroAcademico, 7);
        }
        //public static bool
        //    RegistroAcademicoEhValido(string registroAcademico,
        //    char caractereInformado)
        //{
        //    return Numericos.EhNumerico(caractereInformado) ||
        //        Strings.LengthEquals(
        //            registroAcademico, 7);
        //}
    }
}
