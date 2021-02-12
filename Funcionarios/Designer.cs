using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Designer : Funcionario
    {
        // constructor herdando do constructor base
        public Designer(string cpf) : base(3000, cpf)
        {
            Console.WriteLine("Criando diretor.");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }


        // override diz que esse metodo sobrepoem o metodo da classe Funcionario
        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }
    }
}
