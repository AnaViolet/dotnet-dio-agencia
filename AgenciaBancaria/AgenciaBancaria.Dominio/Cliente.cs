using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class Cliente
    {
        public Cliente(String nome, string cpf, string rg, Endereco endereco)
        {
            //Aqui garantimos que nosso objeto será válido
            //ValidaStringVazia chama o método como se fosse da classe String
            Nome = nome.ValidaStringVazia();
            CPF = cpf.ValidaStringVazia();
            RG = rg.ValidaStringVazia();

            // Null-coalescing operator (??): retorna endereco se não for null,
            // mas se for kança a exceção.
            Endereco = endereco ?? throw new Exception("Endereço deve ser informado.");
        }

        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string RG { get; private set; }
        public Endereco Endereco { get; private set; }
    }
}
