using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class GerenteDeConta : FuncionarioAutenticavel
    {
        // constructor herdando do constructor base
        public GerenteDeConta(string cpf) : base(5000, cpf)
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
            return Salario * 0.25;
        }
    }
}
