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

        static Mesorregiao()
        {
            string mesorregiaos;
            using var client = new HttpClient();
            mesorregiaos = client.GetStringAsync("https://servicodados.ibge.gov.br/api/v1/localidades/mesorregioes?view=nivelado&orderBy=id").Result;

        }

        public static bool Existe(int id)
        {
            foreach (Mesorregiao i in Mesorregiaos)
                if (i.Id == id)
                    return true;
            return false;
        }

        public static Mesorregiao Get(int id)
        {
            foreach (Mesorregiao i in Mesorregiaos)
                if (i.Id == id)
                    return i;
            return null;
        }

        public override string ToString()
        {
            return "{\"id\":" + Id + ",\"nome\":\"" + Nome + "\",\"unidade_federativa\":" + UnidadeFederativa + "}";
        }
    }
}
