using System.Linq;

namespace cshlib.Brasil
{
    public sealed class CadastroNacionalPessoaJuridica : ICadastroReceitaFederal
    {
        private CadastroNacionalPessoaJuridica() { }

        public CadastroNacionalPessoaJuridica(string numero)
        {
            int codigoValidadeNumero = Check(numero);

            if (codigoValidadeNumero == CadastroReceitaFederalException.NumeroValido)
                Numero = numero;
            else
                throw new CadastroReceitaFederalException(codigoValidadeNumero);
        }

        public TipoPessoa TipoPessoa => TipoPessoa.Juridica;
        public string Numero { get; private set; }
        public string NumeroComMascara => Numero.Substring(0, 2) + "." + Numero.Substring(2, 3) + "." + Numero.Substring(5, 3) + "/" + Numero.Substring(8, 4) + "-" + Numero.Substring(12, 2);

        public static int Check(string numero)
        {
            if (numero.Length != 14)
                return CadastroReceitaFederalException.ComprimentoInvalido;
            else
            if (!numero.All(char.IsDigit))
                return CadastroReceitaFederalException.AlgarismoInvalido;
            else
            {
                int[] digitos = new int[14];
                for (int i = 0; i < 14; i++)
                    digitos[i] = numero[i] - 48;

                int n;

                n = 5 * digitos[1] + 4 * digitos[2] + 3 * digitos[3] + 2 * digitos[4];
                n += 9 * digitos[5] + 8 * digitos[6] + 7 * digitos[7] + 6 * digitos[8];
                n += 5 * digitos[9] + 4 * digitos[10] + 3 * digitos[11] + 2 * digitos[12];
                n = 11 - (n % 11);
                n = n >= 10 ? 0 : n;
                if (n != digitos[12])
                    return CadastroReceitaFederalException.PrimeiroDigitoInvalido;

                n = 6 * digitos[1] + 5 * digitos[2] + 4 * digitos[3] + 3 * digitos[4];
                n += 2 * digitos[5] + 9 * digitos[6] + 8 * digitos[7] + 7 * digitos[8];
                n += 6 * digitos[9] + 5 * digitos[10] + 4 * digitos[11] + 3 * digitos[12];
                n += 2 * digitos[13];
                n = 11 - (n % 11);
                n = n >= 10 ? 0 : n;
                if (n != digitos[13])
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
