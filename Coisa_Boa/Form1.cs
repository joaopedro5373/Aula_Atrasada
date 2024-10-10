namespace Coisa_Boa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            Criar_Produto cp = new Criar_Produto();
            var resultado = cp.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                string textoProduto = $"{cp.nomeProduto}({cp.nomeFabricante}) preço de compra [R$ {cp.precoCompra}] preço de venda [R$ {cp.precoVenda}]";
                listBox1.Items.Add(textoProduto);
            }
            
        }

        private void Remover_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex); 
        }
    }
}
