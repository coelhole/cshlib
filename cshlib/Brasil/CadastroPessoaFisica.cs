using System.Linq;

namespace cshlib.Brasil
{
    public sealed class CadastroPessoaFisica : ICadastroReceitaFederal
    {
        private CadastroPessoaFisica() { }

        public CadastroPessoaFisica(string numero)
        {
            int codigoValidadeNumero = Check(numero);

            if (codigoValidadeNumero == CadastroReceitaFederalException.NumeroValido)
                Numero = numero;
            else
                throw new CadastroReceitaFederalException(codigoValidadeNumero);
        }

        public string Numero { get; private set; }
        public string NumeroComMascara => Numero.Substring(0, 3) + "." + Numero.Substring(3, 3) + "." + Numero.Substring(6, 3) + "-" + Numero.Substring(9, 2);
        public int AreaFiscal => Numero[8] == '0' ? 10 : Numero[8] - 48;

        public static int Check(string numero)
        {
            if (numero.Length != 11)
                return CadastroReceitaFederalException.ComprimentoInvalido;
            else
            if (!numero.All(char.IsDigit))
                return CadastroReceitaFederalException.AlgarismoInvalido;
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
                    return CadastroReceitaFederalException.PrimeiroDigitoInvalido;

                n = 0;
                for (int i = 0; i < 10; i++)
                    n += (11 - i) * digitos[i];
                n *= 10;
                n %= 11;
                n = n == 10 ? 0 : n;
                if (n != digitos[10])
                    return CadastroReceitaFederalException.SegundoDigitoInvalido;
            }

            return CadastroReceitaFederalException.NumeroValido;
        }

        public override string ToString()
        {
            return NumeroComMascara;
        }
    }
}
