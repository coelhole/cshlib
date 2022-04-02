namespace cshlib.Brasil
{
    public enum TipoPessoa
    {
        Fisica,
        Juridica
    }
    interface ICadastroReceitaFederal
    {
        public TipoPessoa TipoPessoa { get; }
        public string Numero { get; }
        public string NumeroComMascara { get; }
    }
}
