using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    // aplicando a herança com os dois pontos : (diretor herda de funcionario)
    public class Diretor : FuncionarioAutenticavel
    {

        // constructor herdando do constructor base
        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando diretor.");
        }


        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }


        // override diz que esse metodo sobrepoem o metodo da classe Funcionario
        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }
    }
}
