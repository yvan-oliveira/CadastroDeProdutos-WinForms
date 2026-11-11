using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_windowsforms
{
    public partial class frmCadastroDeProdutos : Form
    {
        private int proximoCodigo = 1;

        public frmCadastroDeProdutos()
        {
            InitializeComponent();
        }

        private void frmCadastroDeProdutos_Load(object sender, EventArgs e)
        {
            txtNomeProduto.Focus();
            chkStatusProduto.Checked = true;
            mtbCodigo.Text = proximoCodigo.ToString("D6");
        }

        private void CalcularMargem()
        {
            decimal custo = nudPrecoCusto.Value;
            decimal venda = nudPrecoVenda.Value;

            decimal margem = venda - custo; 
            txtMargem.Text = margem.ToString("N2"); 
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNomeProduto.Text))
            {
                MessageBox.Show("O campo 'Nome do Produto' é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeProduto.Focus();
                return false;
            }

            if (cmbCategorias.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cmbCategorias.Text) || cmbCategorias.Text == "Selecione...")
            {
                MessageBox.Show("Selecione uma 'Categoria'.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategorias.Focus();
                return false;
            }

            if (cmbFornecedores.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cmbFornecedores.Text) || cmbFornecedores.Text == "Selecione...")
            {
                MessageBox.Show("Selecione um 'Fornecedor'.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbFornecedores.Focus();
                return false;
            }

            decimal custo = nudPrecoCusto.Value;
            if (custo <= 0)
            {
                MessageBox.Show("Informe um 'Preço de Custo' válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudPrecoCusto.Focus();
                return false;
            }

            decimal venda = nudPrecoVenda.Value;
            if (venda <= 0)
            {
                MessageBox.Show("Informe um 'Preço de Venda' válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudPrecoVenda.Focus();
                return false;
            }

            if (venda < custo)
            {
                MessageBox.Show("O 'Preço de Venda' não pode ser menor que o 'Preço de Custo'.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudPrecoVenda.Focus();
                return false;
            }

            decimal estoqueInicial = nudStockInicial.Value;
            if (estoqueInicial <= 0)
            {
                MessageBox.Show("Informe um 'Stock Inicial' válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudStockInicial.Focus();
                return false;
            }

            decimal estoqueMinimo = nudStockMinimo.Value;
            if (estoqueMinimo <= 0)
            {
                MessageBox.Show("Informe um 'Stock Mínimo' válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudStockMinimo.Focus();
                return false;
            }

            if (estoqueMinimo > estoqueInicial)
            {
                MessageBox.Show("O 'Stock Mínimo' não pode ser maior que o 'Stock Inicial'.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudStockMinimo.Focus();
                return false;
            }

            return true;
        }

        private void LimparCampos()
        {
            txtNomeProduto.Clear();
            cmbCategorias.SelectedIndex = -1;
            cmbCategorias.Text = "Selecione...";
            cmbFornecedores.SelectedIndex = -1;
            cmbFornecedores.Text = "Selecione...";
            txtDescricao.Clear();
            nudPrecoCusto.Value = 0;
            nudPrecoVenda.Value = 0;
            txtMargem.Text = "0,00";
            nudStockInicial.Value = 0;
            nudStockMinimo.Value = 0;
            chkStatusProduto.Checked = true;
            dtpDataCadastro.Value = DateTime.Today;
        }

        private void nudPrecoCusto_ValueChanged(object sender, EventArgs e)
        {
            CalcularMargem();
        }

        private void nudPrecoVenda_ValueChanged(object sender, EventArgs e)
        {
            CalcularMargem();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos(); 
            mtbCodigo.Text = proximoCodigo.ToString("D6"); 
            txtNomeProduto.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) // Valida os campos antes de salvar
            {
                return;
            }

            MessageBox.Show(
                "Produto cadastrado com sucesso!\n\n" +
                $"Status: {(chkStatusProduto.Checked ? "Ativo" : "Inativo")}\n" +
                $"Data de Cadastro: {dtpDataCadastro.Value:dd/MM/yyyy}",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            proximoCodigo++;
            LimparCampos(); 
            mtbCodigo.Text = proximoCodigo.ToString("D6");
            txtNomeProduto.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            txtNomeProduto.Focus(); 
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtbCodigo.Text))
            {
                MessageBox.Show("Nenhum produto selecionado para exclusão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacao = MessageBox.Show("Deseja realmente excluir este produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacao == DialogResult.Yes)
            {
                MessageBox.Show("Produto excluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }

            txtNomeProduto.Focus();
        }

    }
}
