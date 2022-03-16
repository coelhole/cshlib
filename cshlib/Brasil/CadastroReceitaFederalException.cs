using System;
using System.Linq;

namespace cshlib.Brasil
{
    public sealed class CadastroReceitaFederalException : Exception
    {
        public const int NumeroValido = 1;
        public const int ComprimentoInvalido = 3;
        public const int AlgarismoInvalido = 5;
        public const int PrimeiroDigitoInvalido = 7;
        public const int SegundoDigitoInvalido = 11;

        private static readonly int[] ExceptionCodes = new int[4] { ComprimentoInvalido, AlgarismoInvalido, PrimeiroDigitoInvalido, SegundoDigitoInvalido };

        public static int[] Codigos() => (int[])ExceptionCodes.Clone();

        public int? Codigo { get; private set; }

        public CadastroReceitaFederalException() : base("Número de cadastro inválido") { }

        public CadastroReceitaFederalException(int codigo) : base(Mensagem(codigo))
        {
            if (ExceptionCodes.Contains(codigo))
                Codigo = codigo;
            else
                throw new ArgumentException("Código de exceção inválido: " + codigo);
        }

        public static string Mensagem(int codigo)
        {
            return codigo switch
            {
                ComprimentoInvalido => "Número de cadastro inválido: comprimento da string diferente de 11",
                AlgarismoInvalido => "Número de cadastro inválido: algarismo/caractere inválido",
                PrimeiroDigitoInvalido => "Número de cadastro inválido: primeiro dígito verificador inválido",
                SegundoDigitoInvalido => "Número de cadastro inválido: segundo dígito verificador inválido",
                _ => "Número de cadastro inválido",
            };
        }
    }
}
