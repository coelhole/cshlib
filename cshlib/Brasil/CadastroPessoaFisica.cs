using System;
using System.Linq;

namespace cshlib.Brasil
{
    public sealed class CadastroPessoaFisica : ICadastroReceitaFederal
    {
        public sealed class CPFException : Exception
        {
            public const int NumeroValido = 1;
            public const int ComprimentoInvalido = 3;
            public const int AlgarismoInvalido = 5;
            public const int PrimeiroDigitoInvalido = 7;
            public const int SegundoDigitoInvalido = 11;

            private static readonly int[] ExceptionCodes = new int[4] { ComprimentoInvalido, AlgarismoInvalido, PrimeiroDigitoInvalido, SegundoDigitoInvalido };

            public static int[] Codigos => (int[])ExceptionCodes.Clone();

            public int? Codigo { get; private set; }

            public CPFException() : base("CPF inválido") { }

            public CPFException(int codigo) : base(Mensagem(codigo))
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
                    ComprimentoInvalido => "CPF inválido: comprimento diferente de 11",
                    AlgarismoInvalido => "CPF inválido: algarismo/caractere inválido",
                    PrimeiroDigitoInvalido => "CPF inválido: primeiro dígito verificador inválido",
                    SegundoDigitoInvalido => "CPF inválido: segundo dígito verificador inválido",
                    _ => "CPF inválido",
                };
            }
        }

        private CadastroPessoaFisica() { }

        public CadastroPessoaFisica(string numero)
        {
            int codigoValidadeNumero = CheckCPF(numero);

            if (codigoValidadeNumero == CPFException.NumeroValido)
                Numero = numero;
            else
                throw new CPFException(codigoValidadeNumero);
        }

        public string Numero { get; private set; }
        public string NumeroComMascara => Numero.Substring(0, 3) + "." + Numero.Substring(3, 3) + "." + Numero.Substring(6, 3) + "-" + Numero.Substring(9, 2);
        public int AreaFiscal => Numero[8] == '0' ? 10 : Numero[8] - 48;

        public static int CheckCPF(string numero)
        {
            if (numero.Length != 11)
                return CPFException.ComprimentoInvalido;
            else
            if (!numero.All(char.IsDigit))
                return CPFException.AlgarismoInvalido;
            else
            {
                int[] digitos = new int[11];
                for(int i = 0; i < 11; i++)
                    digitos[i] = numero[i] - 48;
                int n = 0;
                for (int i = 0; i < 9; i++)
                    n += (10 - i) * digitos[i];
                n *= 10;
                n %= 11;
                n = n == 10 ? 0 : n;
                if (n != digitos[9])
                    return CPFException.PrimeiroDigitoInvalido;
                n = 0;
                for (int i = 0; i < 10; i++)
                    n += (11 - i) * digitos[i];
                n *= 10;
                n %= 11;
                n = n == 10 ? 0 : n;
                if (n != digitos[10])
                    return CPFException.SegundoDigitoInvalido;
            }

            return CPFException.NumeroValido;
        }

        public override string ToString()
        {
            return NumeroComMascara;
        }
    }
}
