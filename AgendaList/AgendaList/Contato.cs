using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaList
{
    internal class Contato
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public Telefone Telefone { get; set; }

        public Contato(string nome, string email, Telefone telefone)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
        }

        public Contato()
        {

        }

        public void BuscarContato()
        {
/*            Console.WriteLine("Digite o nome do Contato: ");
            string busca = Console.ReadLine();
            do
            {
                foreach (var lista in )
                {

                }
            } while ();*/
        }

        public Contato InserirContato()
        {
            Console.Clear();

            Console.WriteLine("# # # # ADICIONANDO CONTATO # # # #");

            Console.Write("\n\tNome do Contato: ");
            string nome = Console.ReadLine();
            Console.Write("\n\tNome do Email: ");
            string email = Console.ReadLine();
            Console.Write("\n\tTipo telefone: ");
            string tipo = Console.ReadLine();
            Console.Write("\n\tDDD do telefone: ");
            int ddd = int.Parse(Console.ReadLine());
            Console.Write("\n\tNúmero telefone: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("\t\tContato Adicionado com Sucesso");
            Console.ReadKey();
            Console.Clear();
            return new Contato(nome, email, new Telefone(tipo, ddd, numero));

        }

        public override string ToString()
        {
            return $"\nNome: {Nome}" +
                   $"\nEmail: {Email}" +
                   $"\nTelefone: {Telefone.ToString()}";
        }

    }
}
