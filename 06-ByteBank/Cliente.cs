using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    public class Cliente
    {
        //quando for necessario validar uma propriedade podemos alterar os metodos com as condições
        private string _cpf;

        public string Nome { get; set; }
        public string CPF {
            get 
            {
                return _cpf;
            }
            set
            {
                //escrevo minha logica de validação
                _cpf = value;
            }
        }
        public string Profissao { get; set; }
    }
}
