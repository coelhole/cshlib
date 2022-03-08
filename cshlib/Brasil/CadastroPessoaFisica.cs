using System;
using System.Linq;

namespace cshlib.Brasil
{
    public sealed class CadastroPessoaFisica
    {
        public enum SituacaoCadastral
        {
            Regular = 1,
            PendenteDeRegularizacao,
            Suspensa,
            Cancelada,
            Nula
        }

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

        public CadastroPessoaFisica(string numero)
        {
            int codigoValidadeNumero = CheckCPF(numero);

            if (codigoValidadeNumero == CPFException.NumeroValido)
                Numero = numero;
            else
                throw new CPFException(codigoValidadeNumero);
        }

        public CadastroPessoaFisica(string numero, DateTime dataDeNascimento) : this(numero)
        {
            DataDeNascimento = dataDeNascimento;
            //
            //
            //
        }

        public bool Fetched { get; private set; }
        public string Numero { get; private set; }
        public string NumeroComMascara => Numero.Substring(0, 3) + "." + Numero.Substring(3, 3) + "." + Numero.Substring(6, 3) + "-" + Numero.Substring(9, 2);
        public int AreaFiscal => Numero[8] == '0' ? 10 : Numero[8] - 48;
        public string Nome { get; private set; }
        public SituacaoCadastral? Situacao { get; private set; }
        public int? DigitoVerificador { get; private set; }
        public DateTime? DataDeNascimento { get; private set; }
        public DateTime? DataDeInscricao { get; private set; }
        public DateTime? HorarioConsulta { get; private set; }
        public string CodigoControle { get; private set; }
        public string QRCode /*base64*/ { get; private set; }

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
                //
                //
            }

            return CPFException.NumeroValido;
        }

        public override string ToString()
        {
            return "{\"numero\":\"" + Numero + "\",\"data_nascimento\":\"" + DataDeNascimento + "\"}";
        }
    }
}
