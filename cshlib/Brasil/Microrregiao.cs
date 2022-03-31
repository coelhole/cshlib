using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace cshlib.Brasil
{
    public sealed class Microrregiao
    {
        private static readonly Microrregiao[] Microrregiaos;
        private static readonly Dictionary<int /*codigo_ibge*/, int /*indice*/> Indices;

        public static Microrregiao[] Itens() => (Microrregiao[])Microrregiaos.Clone();
        public static int[] Codigos()
        {
            int[] keys = new int[Indices.Keys.Count];
            Indices.Keys.CopyTo(keys, 0);
            return keys;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public Mesorregiao Mesorregiao { get; private set; }

        private Microrregiao() { }

        private struct Mcreg
        {
            [JsonProperty("microrregiao-id")]
            public int microrregiao_id;
            [JsonProperty("microrregiao-nome")]
            public string microrregiao_nome;
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

        static Microrregiao()
        {
            string microrregiaos;
            try
            {
                using var client = new HttpClient();
                microrregiaos = client.GetStringAsync(Strings.API_LOCALIDADES + "microrregioes?view=nivelado&orderBy=id").Result;
            }
            catch (Exception)
            {
                microrregiaos = Strings.MICRORREGIOES;
            }
            Mcreg[] mcregs = JsonConvert.DeserializeObject<Mcreg[]>(microrregiaos);
            Microrregiaos = new Microrregiao[mcregs.Length];
            Indices = new Dictionary<int, int>(mcregs.Length);
            for (int i = 0; i < Microrregiaos.Length; i++)
            {
                Microrregiaos[i] = new Microrregiao
                {
                    Id = mcregs[i].microrregiao_id,
                    Nome = mcregs[i].microrregiao_nome,
                    Mesorregiao = Mesorregiao.Get(mcregs[i].mesorregiao_id)
                };
                Indices.Add(mcregs[i].microrregiao_id, i);
            }
        }

        public static bool Existe(int id) => Indices.ContainsKey(id);

        public static Microrregiao Get(int id) => Indices.ContainsKey(id) ? Microrregiaos[Indices.GetValueOrDefault(id)] : null;

        public static Microrregiao[] Get(Mesorregiao mesorregiao)
        {
            List<Microrregiao> msregmcrgs = new();
            foreach (Microrregiao mcrg in Microrregiaos)
                if (mcrg.Mesorregiao == mesorregiao)
                    msregmcrgs.Add(mcrg);
            return msregmcrgs.ToArray();
        }

        public static Microrregiao[] Get(UnidadeFederativa unidade)
        {
            List<Microrregiao> ufmcrgs = new();
            foreach (Microrregiao mcrg in Microrregiaos)
                if (mcrg.Mesorregiao.UnidadeFederativa == unidade)
                    ufmcrgs.Add(mcrg);
            return ufmcrgs.ToArray();
        }

        public static Microrregiao[] Get(Regiao regiao)
        {
            List<Microrregiao> rgmcrgs = new();
            foreach (Microrregiao mcrg in Microrregiaos)
                if (mcrg.Mesorregiao.UnidadeFederativa.Regiao == regiao)
                    rgmcrgs.Add(mcrg);
            return rgmcrgs.ToArray();
        }

        public override string ToString()
        {
            return "{\"id\":" + Id + ",\"nome\":\"" + Nome + "\",\"mesorregiao\":" + Mesorregiao + "}";
        }
    }
}
