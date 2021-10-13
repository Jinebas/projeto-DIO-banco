using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DioBank
{
    class Conta
    {
        /* Inserido novo atributo "Id" para a classe. Foram realizadas as devidas adequações no construtor e nos 
        métodos relacionados */
        public int Id { get; private set; }
        public TipoConta TipoConta { get; private set; }

        public string Nome{ get; private set; }
        public double Saldo { get; private set; }
        public double Credito{ get; private set; }

        public Conta(int id, TipoConta tipoConta, string nome, double saldo, double credito)
        {
            this.Id = id;
            this.TipoConta = tipoConta;
            this.Nome = nome;
            this.Saldo = saldo;
            this.Credito = credito;
        }

        public bool Sacar(double valorSaque)
        {
            if (Saldo + Credito < valorSaque)
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }

            this.Saldo -= valorSaque;
            Console.WriteLine("Saldo atual da conta de {0} é R${1}.", Nome, Saldo);
            return true;
        }

        public void Depositar(double valorDeposito)
        {
            Saldo += valorDeposito;

            Console.WriteLine("Saldo atual da conta de {0} é de R${1}.", Nome, Saldo);
        }

        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if (Sacar(valorTransferencia))
                contaDestino.Depositar(valorTransferencia);
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "TipoConta " + this.TipoConta + " | ";
            retorno += "Nome " + this.Nome + " | ";
            retorno += "saldo " + this.Saldo + " | ";
            retorno += "Credito " + this.Credito;
            return retorno;
            
        }

    }
}
