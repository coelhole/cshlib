namespace cshlib.Brasil
{
    public sealed class CadastroNacionalPessoaJuridica : ICadastroReceitaFederal
    {
        private CadastroNacionalPessoaJuridica() { }

        public CadastroNacionalPessoaJuridica(string numero)
        {
            int codigoValidadeNumero = CheckCNPJ(numero);

            if (codigoValidadeNumero == CadastroReceitaFederalException.NumeroValido)
                Numero = numero;
            else
                throw new CadastroReceitaFederalException(codigoValidadeNumero);
        }

        public string Numero { get; private set; }
        public string NumeroComMascara => string.Empty;

        public static int CheckCNPJ(string numero)
        {
            //
            //
            //

            return CadastroReceitaFederalException.NumeroValido;
        }

        public override string ToString()
        {
            return NumeroComMascara;
        }
    }
}
