using System;
using cshlib.Brasil;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            CadastroPessoaFisica cpf = new CadastroPessoaFisica("");
            if (cpf.Fetched)
                Console.WriteLine("Fetched!");


            Console.WriteLine("It's over!");
        }
    }
}
