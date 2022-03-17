using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;

namespace cshlib.Brasil
{
    public sealed class Municipio
    {
        private static readonly Municipio[] Municipios;
        private static readonly Dictionary<int /*codigo_ibge*/, int /*indice*/> Indices;

        public static Municipio[] Itens() => (Municipio[])Municipios.Clone();
        public static int[] Codigos()
        {
            int[] keys = new int[Indices.Keys.Count];
            Indices.Keys.CopyTo(keys, 0);
            return keys;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public Microrregiao Microrregiao { get; private set; }

        private Municipio() { }

        private struct Mncp
        {
            [JsonProperty("municipio-id")]
            public int municipio_id;
            [JsonProperty("municipio-nome")]
            public string municipio_nome;
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

        static Municipio()
        {
            string municipios;
            using var client = new HttpClient();
            municipios = client.GetStringAsync("https://servicodados.ibge.gov.br/api/v1/localidades/municipios?view=nivelado&orderBy=id").Result;
            Mncp[] mncps = JsonConvert.DeserializeObject<Mncp[]>(municipios);
            Municipios = new Municipio[mncps.Length];
            Indices = new Dictionary<int, int>(mncps.Length);
            for (int i = 0; i < Municipios.Length; i++)
            {
                Municipios[i] = new Municipio
                {
                    Id = mncps[i].municipio_id,
                    Nome = mncps[i].municipio_nome,
                    Microrregiao = Microrregiao.Get(mncps[i].microrregiao_id)
                };
                Indices.Add(mncps[i].municipio_id, i);
            }
        }

        public static bool Existe(int id) => Indices.ContainsKey(id);

        public static Municipio Get(int id) => Indices.ContainsKey(id) ? Municipios[Indices.GetValueOrDefault(id)] : null;

        public static Municipio[] Get(Microrregiao microrregiao)
        {
            List<Municipio> mcregmncps = new();
            foreach (Municipio mncp in Municipios)
                if (mncp.Microrregiao == microrregiao)
                    mcregmncps.Add(mncp);
            return mcregmncps.ToArray();
        }

        public static Municipio[] Get(Mesorregiao mesorregiao)
        {
            List<Municipio> msregmncps = new();
            foreach (Municipio mncp in Municipios)
                if (mncp.Microrregiao.Mesorregiao == mesorregiao)
                    msregmncps.Add(mncp);
            return msregmncps.ToArray();
        }

        public static Municipio[] Get(UnidadeFederativa unidade)
        {
            List<Municipio> ufmncps = new();
            foreach (Municipio mncp in Municipios)
                if (mncp.Microrregiao.Mesorregiao.UnidadeFederativa == unidade)
                    ufmncps.Add(mncp);
            return ufmncps.ToArray();
        }

        public static Municipio[] Get(Regiao regiao)
        {
            List<Municipio> rgmncps = new();
            foreach (Municipio mncp in Municipios)
                if (mncp.Microrregiao.Mesorregiao.UnidadeFederativa.Regiao == regiao)
                    rgmncps.Add(mncp);
            return rgmncps.ToArray();
        }

        public override string ToString()
        {
            return "{\"id\":" + Id + ",\"nome\":\"" + Nome + "\",\"microrregiao\":" + Microrregiao + "}";
        }
    }
}
