using System.Runtime.ConstrainedExecution;

namespace Aula02_Exercicio.Dominio
{
    //2)	Escreva um programa para ler o salário bruto de um 
    //    funcionário e calcular o desconto dos impostos.Considere 
    //    que é descontado o INSS de 8% e o vale transporte no valor 
    //    de R$ 60,00. Ao final o programa deve exibir 
    //    “O funcionário receberá R$ <valor_calculado> ”. 
    internal class Funcionario
    {
        private double? _salarioBruto;

        public double SalarioBruto
        {
            get {
                _validarSalarioBruto("Valor ainda não informado");
                return _salarioBruto??0; 
            }
            set {
                _validarSalarioBruto($"{value} inválido", 
                    valorParaValidar: value);
                _salarioBruto = value;
            }
        }

        public double DescontoINSS { get
            {
                _validarSalarioBruto("Salário Bruto ainda não informado");
                
                return (_salarioBruto??0) * 0.08;
            }
        }

        private void _validarSalarioBruto(string mensagem, 
            double? valorParaValidar = null
           )
        {
            valorParaValidar = valorParaValidar ?? _salarioBruto;
            if (valorParaValidar == null || valorParaValidar <= 0)
            {
                throw new ArgumentException(mensagem);
            }
        }
    }
}
