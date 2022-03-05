using System;
using System.Collections.Generic;

namespace AgendaList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contato contato = new Contato();
            List<Telefone> telefone = new List<Telefone>();
            List<Contato> listcontato = new List<Contato>();
            int opc;

            do
            {
                Console.Clear();
                Menu();
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        listcontato.Add(contato.InserirContato());
                        break;
                    case 2:
                        Console.Clear();
                        listcontato.ForEach(i => Console.WriteLine(i.ToString()));
                        Console.ReadKey();
                        break;
                    case 3:
                        listcontato.Remove();
                        break;
                    default:
                        break;
                }
            } while (opc != 0);
        }

        public static void Menu()
        {
            Console.WriteLine("\n\t[1] - Adicionar Contato" +
                              "\n\t[2] - Ver contatos" +
                              "\n\t[3] - Remover" +
                              "\n\t---------------------------");
            Console.Write("\tOpção: ");
        }

    }
}
