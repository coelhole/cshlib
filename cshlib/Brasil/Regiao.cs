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



            Itens = new Regiao[5] { N, NE, SE, S, CO };
        }

        public Enum ToEnum()
        {
            return (Enum)Id;
        }

        public static Regiao EnumToRegiao(Enum en)
        {
            foreach (Regiao i in Itens)
                if (i.Id == (int)en)
                    return i;
            return null;
        }

        public static bool Existe(int id)
        {
            foreach (Regiao i in Itens)
                if (i.Id == id)
                    return true;
            return false;
        }

        public override string ToString()
        {
            return "{\"id\":" + Id + ",\"nome\":\"" + Nome + "\",\"sigla\":\"" + Sigla + "\"}";
        }
    }
}
