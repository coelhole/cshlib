namespace cshlib.Brasil
{
    public sealed class UnidadeFederativa
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
            //GB,
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

        private static readonly UnidadeFederativa[] UFs;

        public static UnidadeFederativa[] Itens() => (UnidadeFederativa[])UFs.Clone();

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Sigla { get; private set; }
        public int AreaFiscal { get; private set; }
        public Regiao Regiao { get; private set; }

        private UnidadeFederativa() { }

        static UnidadeFederativa()
        {
            RO = new UnidadeFederativa
            {
                Id = 11,
                Nome = "Rondônia",
                Sigla = "RO",
                AreaFiscal = 2,
                Regiao = Regiao.N
            };

            AC = new UnidadeFederativa
            {
                Id = 12,
                Nome = "Acre",
                Sigla = "AC",
                AreaFiscal = 2,
                Regiao = Regiao.N
            };

            AM = new UnidadeFederativa
            {
                Id = 13,
                Nome = "Amazonas",
                Sigla = "AM",
                AreaFiscal = 2,
                Regiao = Regiao.N
            };

            RR = new UnidadeFederativa
            {
                Id = 14,
                Nome = "Roraima",
                Sigla = "RR",
                AreaFiscal = 2,
                Regiao = Regiao.N
            };

            PA = new UnidadeFederativa
            {
                Id = 15,
                Nome = "Pará",
                Sigla = "PA",
                AreaFiscal = 2,
                Regiao = Regiao.N
            };

            AP = new UnidadeFederativa
            {
                Id = 16,
                Nome = "Amapá",
                Sigla = "AP",
                AreaFiscal = 2,
                Regiao = Regiao.N
            };

            TO = new UnidadeFederativa
            {
                Id = 17,
                Nome = "Tocantins",
                Sigla = "TO",
                AreaFiscal = 1,
                Regiao = Regiao.N
            };


            MA = new UnidadeFederativa
            {
                Id = 21,
                Nome = "Maranhão",
                Sigla = "MA",
                AreaFiscal = 3,
                Regiao = Regiao.NE
            };

            PI = new UnidadeFederativa
            {
                Id = 22,
                Nome = "Piauí",
                Sigla = "PI",
                AreaFiscal = 3,
                Regiao = Regiao.NE
            };

            CE = new UnidadeFederativa
            {
                Id = 23,
                Nome = "Ceará",
                Sigla = "CE",
                AreaFiscal = 3,
                Regiao = Regiao.NE
            };

            RN = new UnidadeFederativa
            {
                Id = 24,
                Nome = "Rio Grande do Norte",
                Sigla = "RN",
                AreaFiscal = 4,
                Regiao = Regiao.NE
            };

            PB = new UnidadeFederativa
            {
                Id = 25,
                Nome = "Paraíba",
                Sigla = "PB",
                AreaFiscal = 4,
                Regiao = Regiao.NE
            };

            PE = new UnidadeFederativa
            {
                Id = 26,
                Nome = "Pernambuco",
                Sigla = "PE",
                AreaFiscal = 4,
                Regiao = Regiao.NE
            };

            AL = new UnidadeFederativa
            {
                Id = 27,
                Nome = "Alagoas",
                Sigla = "AL",
                AreaFiscal = 4,
                Regiao = Regiao.NE
            };

            SE = new UnidadeFederativa
            {
                Id = 28,
                Nome = "Sergipe",
                Sigla = "SE",
                AreaFiscal = 5,
                Regiao = Regiao.NE
            };

            BA = new UnidadeFederativa
            {
                Id = 29,
                Nome = "Bahia",
                Sigla = "BA",
                AreaFiscal = 5,
                Regiao = Regiao.NE
            };


            MG = new UnidadeFederativa
            {
                Id = 31,
                Nome = "Minas Gerais",
                Sigla = "MG",
                AreaFiscal = 6,
                Regiao = Regiao.SE
            };

            ES = new UnidadeFederativa
            {
                Id = 32,
                Nome = "Espírito Santo",
                Sigla = "ES",
                AreaFiscal = 7,
                Regiao = Regiao.SE
            };

            RJ = new UnidadeFederativa
            {
                Id = 33,
                Nome = "Rio de Janeiro",
                Sigla = "RJ",
                AreaFiscal = 7,
                Regiao = Regiao.SE
            };

            /*
            GB = new UnidadeFederativa
            {
                CodigoIBGE = 34,
                Nome = "Guanabara",
                Sigla = "GB",
                AreaFiscal = 7,
                Regiao = Regiao.SE
            };
            */

            SP = new UnidadeFederativa
            {
                Id = 35,
                Nome = "São Paulo",
                Sigla = "SP",
                AreaFiscal = 8,
                Regiao = Regiao.SE
            };


            PR = new UnidadeFederativa
            {
                Id = 41,
                Nome = "Paraná",
                Sigla = "PR",
                AreaFiscal = 9,
                Regiao = Regiao.S
            };

            SC = new UnidadeFederativa
            {
                Id = 42,
                Nome = "Santa Catarina",
                Sigla = "SC",
                AreaFiscal = 9,
                Regiao = Regiao.S
            };

            RS = new UnidadeFederativa
            {
                Id = 43,
                Nome = "Rio Grande do Sul",
                Sigla = "RS",
                AreaFiscal = 10,
                Regiao = Regiao.S
            };


            MS = new UnidadeFederativa
            {
                Id = 50,
                Nome = "Mato Grosso do Sul",
                Sigla = "MS",
                AreaFiscal = 1,
                Regiao = Regiao.CO
            };

            MT = new UnidadeFederativa
            {
                Id = 51,
                Nome = "Mato Grosso",
                Sigla = "MT",
                AreaFiscal = 1,
                Regiao = Regiao.CO
            };

            GO = new UnidadeFederativa
            {
                Id = 52,
                Nome = "Goiás",
                Sigla = "GO",
                AreaFiscal = 1,
                Regiao = Regiao.CO
            };

            DF = new UnidadeFederativa
            {
                Id = 53,
                Nome = "Distrito Federal",
                Sigla = "DF",
                AreaFiscal = 1,
                Regiao = Regiao.CO
            };



            UFs = new UnidadeFederativa[27] { RO, AC, AM, RR, PA, AP, TO,
                MA, PI, CE, RN, PB, PE, AL, SE, BA,
                MG, ES, RJ, /*GB,*/ SP,
                PR, SC, RS,
                MS, MT, GO, DF
            };

        }

        public static implicit operator UnidadeFederativa(Enum en)
        {
            foreach (UnidadeFederativa i in UFs)
                if (i.Id == (int)en)
                    return i;
            return null;
        }

        public static implicit operator Enum(UnidadeFederativa uf)
        {
            return (Enum)uf.Id;
        }

        public static bool Existe(int id)
        {
            foreach (UnidadeFederativa i in UFs)
                if (i.Id == id)
                    return true;
            return false;
        }

        public static UnidadeFederativa Get(int id)
        {
            foreach (UnidadeFederativa i in UFs)
                if (i.Id == id)
                    return i;
            return null;
        }

        public override string ToString() => "{\"id\":" + Id + ",\"nome\":\"" + Nome + "\",\"sigla\":\"" + Sigla + "\",\"area_fiscal\":" + AreaFiscal + ",\"regiao\":" + Regiao + "}";
    }
}
