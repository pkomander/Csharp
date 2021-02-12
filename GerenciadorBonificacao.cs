using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class GerenciadorBonificacao
    {

        private double _totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        /*// sobrecarga = podemos ter mais de um metodo com o mesmo nome, porem o tipo destes metodos devem ser diferentes
        public void Registrar(Diretor diretor)
        {
            _totalBonificacao += diretor.GetBonificacao();
        }*/

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
