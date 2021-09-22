using AgenciaBancaria.Dominio;
using System;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Endereco endereco = new Endereco("Rua teste", "0000-00", "Pederneiras", "SP");
                Cliente cliente = new Cliente("Carla", "23456789", "0000000", endereco);

                ContaCorrente conta = new ContaCorrente(cliente, 100);

                Console.WriteLine("Conta " + conta.Situacao + ": " + conta.NumeroConta + "-" + conta.DigitoVerificador);
                
                string senha = "abc123de";
                conta.Abrir(senha);
                
                Console.WriteLine("Conta " + conta.Situacao + ": " + conta.NumeroConta + "-" + conta.DigitoVerificador);

                conta.Sacar(10, senha);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
