namespace cshlib.Brasil
{
    public class Regiao
    {
        public enum Enum
        {
            N = 1,
            NE,
            SE,
            S,
            CO
        }

        public static readonly Regiao N;
        public static readonly Regiao NE;
        public static readonly Regiao SE;
        public static readonly Regiao S;
        public static readonly Regiao CO;

        public static readonly Regiao[] Itens;

        public int CodigoIBGE { get; private set; }
        public string Nome { get; private set; }
        public string Sigla { get; private set; }

        private Regiao() { }

        static Regiao()
        {
            N = new Regiao
            {
                CodigoIBGE = 1,
                Nome = "Norte",
                Sigla = "N"
            };

            NE = new Regiao
            {
                CodigoIBGE = 2,
                Nome = "Nordeste",
                Sigla = "NE"
            };

            SE = new Regiao
            {
                CodigoIBGE = 3,
                Nome = "Sudeste",
                Sigla = "SE"
            };

            S = new Regiao
            {
                CodigoIBGE = 4,
                Nome = "Sul",
                Sigla = "S"
            };

            CO = new Regiao
            {
                CodigoIBGE = 5,
                Nome = "Centro-Oeste",
                Sigla = "CO"
            };



            Itens = new Regiao[5] { N, NE, SE, S, CO };
        }

        public Enum ToEnum()
        {
            return (Enum)CodigoIBGE;
        }

        public static Regiao EnumToRegiao(Enum en)
        {
            foreach (Regiao i in Itens)
                if (i.CodigoIBGE == (int)en)
                    return i;
            return null;
        }

        public static bool Existe(int cod)
        {
            foreach (Regiao i in Itens)
                if (i.CodigoIBGE == cod)
                    return true;
            return false;
        }

        public override string ToString()
        {
            return "{\"codigo_ibge\":" + CodigoIBGE + ",\"nome\":\"" + Nome + "\",\"sigla\":\"" + Sigla + "\"}";
        }
    }
}
