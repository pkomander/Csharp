using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    // interfaces so podem instaciar metodos não podendo ter implementação de codigo
    // interfaces podem ser usadas no lugar de classes abstract para implementar herança multiplas
    // uma interface tem todos os seus membros publicos
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
