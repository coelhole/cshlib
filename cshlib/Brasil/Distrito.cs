using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace cshlib.Brasil
{
    public sealed class Distrito
    {
        private static readonly Distrito[] Distritos;
        private static readonly Dictionary<int /*codigo_ibge*/, int /*indice*/> Indices;

        public static Distrito[] Itens() => (Distrito[])Distritos.Clone();
        public static int[] Codigos()
        {
            int[] keys = new int[Indices.Keys.Count];
            Indices.Keys.CopyTo(keys, 0);
            return keys;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public Municipio Municipio { get; private set; }

        private Distrito() { }

        private struct Dstrt
        {
            [JsonProperty("distrito-id")]
            public int distrito_id;
            [JsonProperty("distrito-nome")]
            public string distrito_nome;
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

        static Distrito()
        {
            string distritos;
            try
            {
                using var client = new HttpClient();
                distritos = client.GetStringAsync(Strings.API_LOCALIDADES + "distritos?view=nivelado&orderBy=id").Result;
            }
            catch(Exception)
            {
                distritos = Strings.DISTRITOS;
            }
            Dstrt[] dstrts = JsonConvert.DeserializeObject<Dstrt[]>(distritos);
            Distritos = new Distrito[dstrts.Length];
            Indices = new Dictionary<int, int>(dstrts.Length);
            for (int i = 0; i < Distritos.Length; i++)
            {
                Distritos[i] = new Distrito
                {
                    Id = dstrts[i].distrito_id,
                    Nome = dstrts[i].distrito_nome,
                    Municipio = Municipio.Get(dstrts[i].municipio_id)
                };
                Indices.Add(dstrts[i].distrito_id, i);
            }
        }

        public static bool Existe(int id) => Indices.ContainsKey(id);

        public static Distrito Get(int id) => Indices.ContainsKey(id) ? Distritos[Indices.GetValueOrDefault(id)] : null;

        public static Distrito[] Get(Municipio municipio)
        {
            List<Distrito> mncpdstrts = new();
            foreach (Distrito dstrt in Distritos)
                if (dstrt.Municipio == municipio)
                    mncpdstrts.Add(dstrt);
            return mncpdstrts.ToArray();
        }

        public static Distrito[] Get(Microrregiao microrregiao)
        {
            List<Distrito> mcregdstrts = new();
            foreach (Distrito dstrt in Distritos)
                if (dstrt.Municipio.Microrregiao == microrregiao)
                    mcregdstrts.Add(dstrt);
            return mcregdstrts.ToArray();
        }

        public static Distrito[] Get(Mesorregiao mesorregiao)
        {
            List<Distrito> msregdstrts = new();
            foreach (Distrito dstrt in Distritos)
                if (dstrt.Municipio.Microrregiao.Mesorregiao == mesorregiao)
                    msregdstrts.Add(dstrt);
            return msregdstrts.ToArray();
        }

        public static Distrito[] Get(UnidadeFederativa unidade)
        {
            List<Distrito> ufdstrts = new();
            foreach (Distrito dstrt in Distritos)
                if (dstrt.Municipio.Microrregiao.Mesorregiao.UnidadeFederativa == unidade)
                    ufdstrts.Add(dstrt);
            return ufdstrts.ToArray();
        }

        public static Distrito[] Get(Regiao regiao)
        {
            List<Distrito> rgdstrts = new();
            foreach (Distrito dstrt in Distritos)
                if (dstrt.Municipio.Microrregiao.Mesorregiao.UnidadeFederativa.Regiao == regiao)
                    rgdstrts.Add(dstrt);
            return rgdstrts.ToArray();
        }

        public override string ToString() => "{\"id\":" + Id + ",\"nome\":\"" + Nome + "\",\"municipio\":" + Municipio + "}";
    }
}
