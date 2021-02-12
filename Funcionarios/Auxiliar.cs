﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Auxiliar : Funcionario
    {
        // constructor herdando do constructor base
        public Auxiliar(string cpf) : base(2000, cpf)
        {
            Console.WriteLine("Criando diretor.");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }


        // override diz que esse metodo sobrepoem o metodo da classe Funcionario
        public override double GetBonificacao()
        {
            return Salario * 0.2;
        }
    }
}
