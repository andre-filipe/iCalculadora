using iCalculadora.Library;

namespace iCalculadora.Cientifica.UI
{
    public partial class Form1 : Form
    {
        private readonly Calculadora _calc = new Calculadora();

        private double _valorAtual = 0;
        private string _operacao = "";
        private bool _limpar = false;
        private bool _temOperacao = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            if (_limpar)
            {
                txtDisplay.Text = "";
                _limpar = false;
            }

            if (!_temOperacao)
            {
                _operacao = "";
            }

            txtDisplay.Text += (sender as Button).Text;
        }

        private void btnOperacao_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out _valorAtual))
            {
                _operacao = (sender as Button).Text;
                _limpar = true;
            }

            _temOperacao = true;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (!_temOperacao || !double.TryParse(txtDisplay.Text, out double valor2))
            {
                return;
            }

            double resultado = 0;

            switch (_operacao)
            {
                case "+": resultado = _calc.Somar(_valorAtual, valor2); break;
                case "-": resultado = _calc.Subtrair(_valorAtual, valor2); break;
                case "×": resultado = _calc.Multiplicar(_valorAtual, valor2); break;
                case "÷": resultado = _calc.Dividir(_valorAtual, valor2); break;
            }

            txtDisplay.Text = resultado.ToString();

            _limpar = true;
            _temOperacao = false;
        }
        private void btnFuncao_Click(object sender, EventArgs e)
        {
            var botao = sender as Button;

            if (botao == null) return;

            txtDisplay.Text = $"[{botao.Text}]";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            _valorAtual = 0;
            _operacao = "";
        }
    }
}
