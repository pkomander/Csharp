//quando utilizamos uma classe de fora e necessario importar utilizando using o nome do namespace.
//com o namespace passado na criação da classe não se faz necessario importar utiizando o using
//using _05_ByteBank;

namespace _07_ByteBank
{
    public class ContaCorrente
    {
        //titular faz referencia a instancia do objeto cliente.
        //private Cliente _titular;

        //o compilador entende que no momento não há logica envolvida e cria automaticamente os campos get e set
        //para serem preenchidos
        public Cliente Titular { get; set;}

        //static diz que esta e uma propriedade que faz parte desta classe
        public static int TotalDeContasCriadas { get; private set; }



        //validando a agencia
        private int _agencia;
        public int Agencia { 
            get 
            {
                return _agencia;
            }
            set 
            {
                if(value <= 0)
                {
                    return;
                }

                _agencia = value;
            }

        }
        public int Numero {get; set;}
        private double _saldo = 100;



        //o saldo do this faz referencia ao saldo da conta que receberar um valor do atributo externo
        //quando temos um return em um metodo void nos paramos a condição automaticamente
        /*public void SetSaldo(double saldo)
        {
            if(saldo < 0)
            {
                return;
            }
            this.saldo = saldo;
            
        }

        public double GetSaldo()
        {
            return saldo;
        }*/
        //outra forma de fazer o get and set, value faz referencia ao valor que vem de fora pelo usuario (value)
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }

        //criando um constructor, sendo necessario passar o numero da agencia e da conta
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }


        //criando o metodo Sacar
        //this faz referencia aos atributos da classe
        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                return true;
            }
        }


        //quando um metodo não possui retorno nos colocamos void
        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        //retirando o valor da conta que esta chamando o metodo é transferindo para conta de destino
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }

    }
}
