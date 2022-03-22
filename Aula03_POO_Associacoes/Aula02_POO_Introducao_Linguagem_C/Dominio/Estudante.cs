using Aula02_POO_Introducao_Linguagem_C.Validadores;
using System.Text.RegularExpressions;

namespace Aula02_POO_Introducao_Linguagem_C.Dominio
{
    internal class Estudante
    {
        #region Construtores
        public Estudante(string registroAcademico)
        {
            RegistroAcademico = registroAcademico;
        }
        #endregion

        #region Propriedades
        private string _registroAcademico;
        public string RegistroAcademico
        {
            get => _registroAcademico;
            set
            {
                //var validador = new ValidadoresNumericos();
                //_registroAcademico =
                //    validador.EhNumerico(value) ? value : null;

                //            _registroAcademico =
                //ValidadoresNumericos.EhNumerico(value) ? value : null;

                _registroAcademico = _validarRegistroAcademico(value) ? value : null;


                //"abc3def".Any(c => char.IsDigit(c));

                //// Or to make it shorter:
                //"abc3def".Any(char.IsDigit);

                //_registroAcademico = value.Length == 7 ? value : null;

                //Regex regex = new Regex(@"^-?[0-9][0-9,\.]+$");
                //var res = regex.IsMatch(num);

                //Regex regex = new Regex(@"^-?[0-9][0-9,\.]+$");
                //Console.WriteLine(regex.IsMatch(value));

                //_registroAcademico =
                //    regex.IsMatch(value) ? value : null;

                //string num = "123AA";
                //Regex regex = new Regex(@"^-?[0-9][0-9,\.]+$");
                //var res = regex.IsMatch(num);
                //System.Console.WriteLine($"==> {res}");

                //_registroAcademico = 
                //    value.Any(char.IsLetter) ? null : value;
                //if (value.Length == 7)
                //{
                //    _registroAcademico = value;
                //}
            }
        }
        #endregion
       
        #region Métodos de Predicado
        public bool EhValido()
        {
            return (RegistroAcademico != null);
        }
        #endregion

        #region Métodos validarores
        private bool _validarRegistroAcademico(string registroAcademico)
        {
            if (!ValidadoresNumericos.EhNumerico(registroAcademico))
            {
                return false;
            }
            if (!Validadores.Strings.LengthEquals(registroAcademico, 7))
            {
                return false;
            }
            return true;
        }
        #endregion

        #region Testes comentados para exemplos didático
        //private string _registroAcademico;

        //public string RegistroAcademico
        //{
        //    get { return _registroAcademico; }
        //    set { _registroAcademico = value; }
        //}

        //2255357 

        //private  string _ra;

        //public void AtribuirValorARA(string ra)
        //{
        //    _ra = ra;
        //}

        //public String ObterRA()
        //{
        //    return _ra;
        //}

        //ra,nome,nascimento,renda familiar
        #endregion

    }
}
