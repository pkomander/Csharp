



public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100;


    //criando o metodo Sacar
    //this faz referencia aos atributos da classe
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
    

    //quando um metodo não possui retorno nos colocamos void
    public void Depositar(double valor)
    {
        this.saldo += valor;
    }

    //retirando o valor da conta que esta chamando o metodo é transferindo para conta de destino
    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if(this.saldo < valor)
        {
            return false;
        }
        else{
            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }

}