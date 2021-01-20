

//criando uma classe para criação de um objeto
public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100;

    //criando a função(metodo) sacar
    //this faz referencia ao objeto que esta chamanda a função
    public bool Sacar(double valor)
    {
        if(this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            return true;
        }
    }

    //quando a função(metodo) não retorna nenhum valor e utilizado o void
    public void Depositar(double valor)
    {
        this.saldo += valor;
    }

    //para transferencia passamos um valor e uma referencia a conta para deposito
    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if(this.saldo < valor)
        {
            return false;
        }

        //aplicando o early return
        this.saldo -= valor;
        contaDestino.Depositar(valor);
        return true;
    }
}



