using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    // a classe funcionario e uma abstração do conceito
    public abstract class Funcionario
    {
        //propriedade
        public static int TotalDeFuncionarios { get; private set; }

        //propriedade
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        
        

        //constructor para incrementar a cada funcionario criado
        // CPF - propriedade, cpf - argumento
        public Funcionario(double salario ,string cpf)
        {
            Console.WriteLine("Criando Funcionario");
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }


        public abstract void AumentarSalario();

        // quando metodos repetidos por herança forem marcados de verde e necessario que permita uma sobre-escrita do metodo
        // transformando em metodo virtual

        //metodos abstratos não devem ter corpo de codigo no metodo, sendo necessaria que as classes derivadas as
        //sobrescrevam os metodos
        public abstract double GetBonificacao();
        
    }
}
