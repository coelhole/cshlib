namespace cshlib.Brasil
{
    public class UnidadeFederativa
    {
        public enum Enum
        {
            RO = 11,
            AC,
            AM,
            RR,
            PA,
            AP,
            TO,
            MA = 21,
            PI,
            CE,
            RN,
            PB,
            PE,
            AL,
            SE,
            BA,
            MG = 31,
            ES,
            RJ,
            SP = 35,
            PR = 41,
            SC,
            RS,
            MS = 50,
            MT,
            GO,
            DF
        };

        public static readonly UnidadeFederativa RO;
        public static readonly UnidadeFederativa AC;
        public static readonly UnidadeFederativa AM;
        public static readonly UnidadeFederativa RR;
        public static readonly UnidadeFederativa PA;
        public static readonly UnidadeFederativa AP;
        public static readonly UnidadeFederativa TO;

        public static readonly UnidadeFederativa MA;
        public static readonly UnidadeFederativa PI;
        public static readonly UnidadeFederativa CE;
        public static readonly UnidadeFederativa RN;
        public static readonly UnidadeFederativa PB;
        public static readonly UnidadeFederativa PE;
        public static readonly UnidadeFederativa AL;
        public static readonly UnidadeFederativa SE;
        public static readonly UnidadeFederativa BA;

        public static readonly UnidadeFederativa MG;
        public static readonly UnidadeFederativa ES;
        public static readonly UnidadeFederativa RJ;
        public static readonly UnidadeFederativa SP;

        public static readonly UnidadeFederativa PR;
        public static readonly UnidadeFederativa SC;
        public static readonly UnidadeFederativa RS;

        public static readonly UnidadeFederativa MS;
        public static readonly UnidadeFederativa MT;
        public static readonly UnidadeFederativa GO;
        public static readonly UnidadeFederativa DF;

        public static readonly UnidadeFederativa[] Itens;

        public Regiao Regiao { get; private set; }
        public int CodigoIBGE { get; private set; }
        public string Nome { get; private set; }
        public string Sigla { get; private set; }

        private UnidadeFederativa() { }

        static UnidadeFederativa()
        {
            RO = new UnidadeFederativa
            {
                CodigoIBGE = 11,
                Nome = "Rondônia",
                Sigla = "RO",
                Regiao = Regiao.N
            };

            AC = new UnidadeFederativa
            {
                CodigoIBGE = 12,
                Nome = "Acre",
                Sigla = "AC",
                Regiao = Regiao.N
            };

            AM = new UnidadeFederativa
            {
                CodigoIBGE = 13,
                Nome = "Amazonas",
                Sigla = "AM",
                Regiao = Regiao.N
            };

            RR = new UnidadeFederativa
            {
                CodigoIBGE = 14,
                Nome = "Roraima",
                Sigla = "RR",
                Regiao = Regiao.N
            };

            PA = new UnidadeFederativa
            {
                CodigoIBGE = 15,
                Nome = "Pará",
                Sigla = "PA",
                Regiao = Regiao.N
            };

            AP = new UnidadeFederativa
            {
                CodigoIBGE = 16,
                Nome = "Amapá",
                Sigla = "AP",
                Regiao = Regiao.N
            };

            TO = new UnidadeFederativa
            {
                CodigoIBGE = 17,
                Nome = "Tocantins",
                Sigla = "TO",
                Regiao = Regiao.N
            };


            MA = new UnidadeFederativa
            {
                CodigoIBGE = 21,
                Nome = "Maranhão",
                Sigla = "MA",
                Regiao = Regiao.NE
            };

            PI = new UnidadeFederativa
            {
                CodigoIBGE = 22,
                Nome = "Piauí",
                Sigla = "PI",
                Regiao = Regiao.NE
            };

            CE = new UnidadeFederativa
            {
                CodigoIBGE = 23,
                Nome = "Ceará",
                Sigla = "CE",
                Regiao = Regiao.NE
            };

            RN = new UnidadeFederativa
            {
                CodigoIBGE = 24,
                Nome = "Rio Grande do Norte",
                Sigla = "RN",
                Regiao = Regiao.NE
            };

            PB = new UnidadeFederativa
            {
                CodigoIBGE = 25,
                Nome = "Paraíba",
                Sigla = "PB",
                Regiao = Regiao.NE
            };

            PE = new UnidadeFederativa
            {
                CodigoIBGE = 26,
                Nome = "Pernambuco",
                Sigla = "PE",
                Regiao = Regiao.NE
            };

            AL = new UnidadeFederativa
            {
                CodigoIBGE = 27,
                Nome = "Alagoas",
                Sigla = "AL",
                Regiao = Regiao.NE
            };

            SE = new UnidadeFederativa
            {
                CodigoIBGE = 28,
                Nome = "Sergipe",
                Sigla = "SE",
                Regiao = Regiao.NE
            };

            BA = new UnidadeFederativa
            {
                CodigoIBGE = 29,
                Nome = "Bahia",
                Sigla = "BA",
                Regiao = Regiao.NE
            };


            MG = new UnidadeFederativa
            {
                CodigoIBGE = 31,
                Nome = "Minas Gerais",
                Sigla = "MG",
                Regiao = Regiao.SE
            };

            ES = new UnidadeFederativa
            {
                CodigoIBGE = 32,
                Nome = "Espírito Santo",
                Sigla = "ES",
                Regiao = Regiao.SE
            };

            RJ = new UnidadeFederativa
            {
                CodigoIBGE = 33,
                Nome = "Rio de Janeiro",
                Sigla = "RJ",
                Regiao = Regiao.SE
            };

            /*
            GB = new UnidadeFederativa
            {
                CodigoIBGE = 34,
                Nome = "Guanabara",
                Sigla = "GB",
                Regiao = Regiao.SE
            };
            */

            SP = new UnidadeFederativa
            {
                CodigoIBGE = 35,
                Nome = "São Paulo",
                Sigla = "SP",
                Regiao = Regiao.SE
            };


            PR = new UnidadeFederativa
            {
                CodigoIBGE = 41,
                Nome = "Paraná",
                Sigla = "PR",
                Regiao = Regiao.S
            };

            SC = new UnidadeFederativa
            {
                CodigoIBGE = 42,
                Nome = "Santa Catarina",
                Sigla = "SC",
                Regiao = Regiao.S
            };

            RS = new UnidadeFederativa
            {
                CodigoIBGE = 43,
                Nome = "Rio Grande do Sul",
                Sigla = "RS",
                Regiao = Regiao.S
            };


            MS = new UnidadeFederativa
            {
                CodigoIBGE = 50,
                Nome = "Mato Grosso do Sul",
                Sigla = "MS",
                Regiao = Regiao.CO
            };

            MT = new UnidadeFederativa
            {
                CodigoIBGE = 51,
                Nome = "Mato Grosso",
                Sigla = "MT",
                Regiao = Regiao.CO
            };

            GO = new UnidadeFederativa
            {
                CodigoIBGE = 52,
                Nome = "Goiás",
                Sigla = "GO",
                Regiao = Regiao.CO
            };

            DF = new UnidadeFederativa
            {
                CodigoIBGE = 53,
                Nome = "Distrito Federal",
                Sigla = "DF",
                Regiao = Regiao.CO
            };



            Itens = new UnidadeFederativa[27] { RO, AC, AM, RR, PA, AP, TO,
                MA, PI, CE, RN, PB, PE, AL, SE, BA,
                MG, ES, RJ, /*GB,*/ SP,
                PR, SC, RS,
                MS, MT, GO, DF
            };

        }

        public Enum ToEnum()
        {
            return (Enum)CodigoIBGE;
        }

        public static UnidadeFederativa EnumToUnidadeFederativa(Enum en)
        {
            foreach (UnidadeFederativa i in Itens)
                if (i.CodigoIBGE == (int)en)
                    return i;
            return null;
        }

        public static bool Existe(int cod)
        {
            foreach (UnidadeFederativa i in Itens)
                if (i.CodigoIBGE == cod)
                    return true;
            return false;
        }

        public override string ToString()
        {
            return "{\"codigo_ibge\":" + CodigoIBGE + ",\"nome\":\"" + Nome + "\",\"sigla\":\"" + Sigla + "\",\"regiao\":" + Regiao + "}";
        }
    }
}
