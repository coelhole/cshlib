using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace cshlib.Brasil
{
    public sealed class Mesorregiao
    {
        private static readonly Mesorregiao[] Mesorregiaos;
        private static readonly Dictionary<int /*codigo_ibge*/, int /*indice*/> Indices;

        public static Mesorregiao[] Itens() => (Mesorregiao[])Mesorregiaos.Clone();
        public static int[] Codigos()
        {
            int[] keys = new int[Indices.Keys.Count];
            Indices.Keys.CopyTo(keys, 0);
            return keys;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public UnidadeFederativa UnidadeFederativa { get; private set; }

        private Mesorregiao() { }

        private struct Msreg
        {
            [JsonProperty("mesorregiao-id")]
            public int mesorregiao_id;
            [JsonProperty("mesorregiao-nome")]
            public string mesorregiao_nome;
            [JsonProperty("UF-id")]
            public int uf_id;
            [JsonProperty("UF-sigla")]
            public string uf_sigla;
            [JsonProperty("UF-nome")]
            public string uf_nome;
            [JsonProperty("regiao-id")]
            public int regiao_id;
            [JsonProperty("regiao-sigla")]
            public string regiao_sigla;
            [JsonProperty("regiao-nome")]
            public string regiao_nome;
        }

        static Mesorregiao()
        {
            string mesorregiaos;
            try
            {
                using var client = new HttpClient();
                mesorregiaos = client.GetStringAsync(Strings.API_LOCALIDADES + "mesorregioes?view=nivelado&orderBy=id").Result;
            }
            catch (Exception)
            {
                mesorregiaos = Strings.MESORREGIOES;
            }
            Msreg[] msregs = JsonConvert.DeserializeObject<Msreg[]>(mesorregiaos);
            Mesorregiaos = new Mesorregiao[msregs.Length];
            Indices = new Dictionary<int, int>(msregs.Length);
            for(int i = 0; i < Mesorregiaos.Length; i++)
            {
                Mesorregiaos[i] = new Mesorregiao
                {
                    Id = msregs[i].mesorregiao_id,
                    Nome = msregs[i].mesorregiao_nome,
                    UnidadeFederativa = (UnidadeFederativa.Enum)msregs[i].uf_id
                };
                Indices.Add(msregs[i].mesorregiao_id, i);
            }
        }

        public static bool Existe(int id) => Indices.ContainsKey(id);

        public static Mesorregiao Get(int id) => Indices.ContainsKey(id) ? Mesorregiaos[Indices.GetValueOrDefault(id)] : null;

        public static Mesorregiao[] Get(UnidadeFederativa unidade)
        {
            List<Mesorregiao> ufmsrgs = new();
            foreach(Mesorregiao msrg in Mesorregiaos)
                if (msrg.UnidadeFederativa == unidade)
                    ufmsrgs.Add(msrg);
            return ufmsrgs.ToArray();
        }

        public static Mesorregiao[] Get(Regiao regiao)
        {
            List<Mesorregiao> rgmsrgs = new();
            foreach (Mesorregiao msrg in Mesorregiaos)
                if (msrg.UnidadeFederativa.Regiao == regiao)
                    rgmsrgs.Add(msrg);
            return rgmsrgs.ToArray();
        }

        public override string ToString()
        {
            return "{\"id\":" + Id + ",\"nome\":\"" + Nome + "\",\"unidade_federativa\":" + UnidadeFederativa + "}";
        }
    }
}
