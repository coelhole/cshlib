using System;
using System.Windows.Forms;
using cshlib.Brasil;

namespace TestaEnumeracoes
{
    public partial class FrmEnumeracoes : Form
    {
        private static readonly Regiao[] Regioes = Regiao.Itens();
        private static readonly UnidadeFederativa[] UFs = UnidadeFederativa.Itens();

        private int _iRegiaoSelecionada = -1;
        private Regiao _regiaoSelecionada;
        private int _iUnidadeFederativaSelecionada = -1;
        private UnidadeFederativa _unidadeFederativaSelecionada;

        public FrmEnumeracoes()
        {
            InitializeComponent();
        }

        private void FrmTestaEnumeracoes_Load(object sender, EventArgs e)
        {
            foreach (Regiao i in Regioes)
                CbxRegioes.Items.Add(i.Nome);

            foreach (UnidadeFederativa i in UFs)
                CbxUFs.Items.Add(i.Nome);
        }

        private void CbxRegioes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _iRegiaoSelecionada = CbxRegioes.SelectedIndex;
            _regiaoSelecionada = Regioes[_iRegiaoSelecionada];
            TxtBxRegiao.Text = _regiaoSelecionada.ToString();
        }

        private void CbxUFs_SelectedIndexChanged(object sender, EventArgs e)
        {
            _iUnidadeFederativaSelecionada = CbxUFs.SelectedIndex;
            _unidadeFederativaSelecionada = UFs[_iUnidadeFederativaSelecionada];
            TxtBxUF.Text = _unidadeFederativaSelecionada.ToString();
        }
    }
}
