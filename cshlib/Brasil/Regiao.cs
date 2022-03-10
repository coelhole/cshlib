namespace cshlib.Brasil
{
    public sealed class Regiao
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

        private static readonly Regiao[] Regioes;

        public static Regiao[] Itens() => (Regiao[])Regioes.Clone();

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Sigla { get; private set; }

        private Regiao() { }

        static Regiao()
        {
            N = new Regiao
            {
                Id = 1,
                Nome = "Norte",
                Sigla = "N"
            };

            NE = new Regiao
            {
                Id = 2,
                Nome = "Nordeste",
                Sigla = "NE"
            };

            SE = new Regiao
            {
                Id = 3,
                Nome = "Sudeste",
                Sigla = "SE"
            };

            S = new Regiao
            {
                Id = 4,
                Nome = "Sul",
                Sigla = "S"
            };

            CO = new Regiao
            {
                Id = 5,
                Nome = "Centro-Oeste",
                Sigla = "CO"
            };



            Regioes = new Regiao[5] { N, NE, SE, S, CO };
        }

        public static implicit operator Regiao(Enum en)
        {
            foreach (Regiao i in Regioes)
                if (i.Id == (int)en)
                    return i;
            return null;
        }

        public static implicit operator Enum(Regiao r)
        {
            return (Enum)r.Id;
        }

        public static bool Existe(int id)
        {
            foreach (Regiao i in Regioes)
                if (i.Id == id)
                    return true;
            return false;
        }

        public static Regiao Get(int id)
        {
            foreach (Regiao i in Regioes)
                if (i.Id == id)
                    return i;
            return null;
        }

        public override string ToString()
        {
            return "{\"id\":" + Id + ",\"nome\":\"" + Nome + "\",\"sigla\":\"" + Sigla + "\"}";
        }
    }
}
