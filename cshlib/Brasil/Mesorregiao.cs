﻿namespace cshlib.Brasil
{
    public sealed class Mesorregiao
    {
        private static readonly Mesorregiao[] Mesorregiaos;

        public static Mesorregiao[] Itens() => (Mesorregiao[])Mesorregiaos.Clone();

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public UnidadeFederativa UnidadeFederativa { get; private set; }

        private Mesorregiao() { }

        static Mesorregiao()
        {
            //
            //
            //
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