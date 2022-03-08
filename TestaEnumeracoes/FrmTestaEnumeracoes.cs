﻿using System;
using System.Windows.Forms;
using cshlib.Brasil;

namespace TestaEnumeracoes
{
    public partial class FrmTestaEnumeracoes : Form
    {
        private int _iRegiaoSelecionada = -1;
        private Regiao _regiaoSelecionada;
        private int _iUnidadeFederativaSelecionada = -1;
        private UnidadeFederativa _unidadeFederativaSelecionada;

        public FrmTestaEnumeracoes()
        {
            InitializeComponent();
        }

        private void FrmTestaEnumeracoes_Load(object sender, EventArgs e)
        {
            foreach (Regiao i in Regiao.Itens)
                CbxRegioes.Items.Add(i.Nome);

            foreach (UnidadeFederativa i in UnidadeFederativa.Itens)
                CbxUFs.Items.Add(i.Nome);
        }

        private void CbxRegioes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _iRegiaoSelecionada = CbxRegioes.SelectedIndex;
            _regiaoSelecionada = Regiao.Itens[_iRegiaoSelecionada];
            TxtBxRegiao.Text = _regiaoSelecionada.ToString();
        }

        private void CbxUFs_SelectedIndexChanged(object sender, EventArgs e)
        {
            _iUnidadeFederativaSelecionada = CbxUFs.SelectedIndex;
            _unidadeFederativaSelecionada = UnidadeFederativa.Itens[_iUnidadeFederativaSelecionada];
            TxtBxUF.Text = _unidadeFederativaSelecionada.ToString();
        }
    }
}
