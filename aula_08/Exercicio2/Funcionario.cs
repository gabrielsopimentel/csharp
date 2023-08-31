using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Funcionario
    {
        private string matricula;
        private string nome;
        private string telefone;
        private string email;
        private string nascimento;

        public Funcionario(string matricula, string nome, string telefone, string email, string nascimento)
        {
            this.matricula = matricula;
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
            this.nascimento = nascimento;
        }

        public string GetMatricula()
        {
            return matricula;
        }

        public void SetMatricula(string matricula)
        {
            this.matricula = matricula;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetTelefone()
        {
            return telefone;
        }

        public void SetTelefone(string telefone)
        {
            this.telefone = telefone;
        }

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public string GetNascimento()
        {
            return nascimento;
        }

        public void SetNascimento(string nascimento)
        {
            this.nascimento = nascimento;
        }

        public void Visualizar()
        {

            Console.WriteLine("**************");
            Console.WriteLine("Dados do funcionário");
            Console.WriteLine("**************");
            Console.WriteLine($"Número da matricula: {this.matricula}");
            Console.WriteLine($"Nome: {this.nome}");
            Console.WriteLine($"Telefone: {this.telefone}");
            Console.WriteLine($"Email: {this.email}");
            Console.WriteLine($"Data de nascimento: {this.nascimento}");
        }
    }
}
