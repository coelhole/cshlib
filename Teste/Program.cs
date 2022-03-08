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


            CadastroPessoaFisica.CPFException exc = new CadastroPessoaFisica.CPFException(0);

            Console.WriteLine(exc.Codigo);


            Console.WriteLine("It's over!");
        }
    }
}
