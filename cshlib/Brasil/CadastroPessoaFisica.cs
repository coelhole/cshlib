using System;

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

        public CadastroPessoaFisica(string numero)
        {
            //
            //
            //
        }

        public CadastroPessoaFisica(string numero, DateTime dataDeNascimento)
        {
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
    }
}
