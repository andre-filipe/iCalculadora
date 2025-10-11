namespace iCalculadora.Cientifica.UI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtDisplay;
        private Button btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9;
        private Button btnSomar, btnSubtrair, btnMultiplicar, btnDividir, btnIgual, btnClear;

        private void InitializeComponent()
        {
            var larguraBotao = 45;
            var alturaBotao = 40;
            var corBotao = Color.LightSteelBlue;
            var corBotaoOps = Color.Khaki;
            var corBordaBotao = Color.AliceBlue;
            var fonteBotao = new Font("Arial", 15);

            this.txtDisplay = new TextBox();
            this.btn0 = new Button();
            this.btn1 = new Button();
            this.btn2 = new Button();
            this.btn3 = new Button();
            this.btn4 = new Button();
            this.btn5 = new Button();
            this.btn6 = new Button();
            this.btn7 = new Button();
            this.btn8 = new Button();
            this.btn9 = new Button();
            this.btnSomar = new Button();
            this.btnSubtrair = new Button();
            this.btnMultiplicar = new Button();
            this.btnDividir = new Button();
            this.btnIgual = new Button();
            this.btnClear = new Button();
            this.SuspendLayout();

            // Display
            this.txtDisplay.Font = fonteBotao;
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Size = new System.Drawing.Size(185, 80);
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.TextAlign = HorizontalAlignment.Right;

            // Botões de números
            this.btn1.Text = "1";
            this.btn1.Font = fonteBotao;
            this.btn1.Location = new System.Drawing.Point(12, 50);
            this.btn1.Size = new System.Drawing.Size(larguraBotao, alturaBotao);
            this.btn1.FlatStyle = FlatStyle.Flat;
            this.btn1.FlatAppearance.BorderSize = 1;
            this.btn1.FlatAppearance.BorderColor = corBordaBotao;
            this.btn1.BackColor = corBotao;
            this.btn1.Click += new EventHandler(this.btnNumero_Click);

            this.btn2.Text = "2";
            this.btn2.Font = fonteBotao;
            this.btn2.Location = new System.Drawing.Point(60, 50);
            this.btn2.Size = new System.Drawing.Size(larguraBotao, alturaBotao);
            this.btn2.FlatStyle = FlatStyle.Flat;
            this.btn2.FlatAppearance.BorderSize = 1;
            this.btn2.FlatAppearance.BorderColor = corBordaBotao;
            this.btn2.BackColor = corBotao;
            this.btn2.Click += new EventHandler(this.btnNumero_Click);

            this.btn3.Text = "3";
            this.btn3.Font = fonteBotao;
            this.btn3.Location = new System.Drawing.Point(108, 50);
            this.btn3.Size = new System.Drawing.Size(larguraBotao, alturaBotao);
            this.btn3.FlatStyle = FlatStyle.Flat;
            this.btn3.FlatAppearance.BorderSize = 1;
            this.btn3.FlatAppearance.BorderColor = corBordaBotao;
            this.btn3.BackColor = corBotao;
            this.btn3.Click += new EventHandler(this.btnNumero_Click);

            this.btn4.Text = "4";
            this.btn4.Font = fonteBotao;
            this.btn4.Location = new System.Drawing.Point(12, 90);
            this.btn4.Size = new System.Drawing.Size(larguraBotao, alturaBotao);
            this.btn4.FlatStyle = FlatStyle.Flat;
            this.btn4.FlatAppearance.BorderSize = 1;
            this.btn4.FlatAppearance.BorderColor = corBordaBotao;
            this.btn4.BackColor = corBotao;
            this.btn4.Click += new EventHandler(this.btnNumero_Click);

            this.btn5.Text = "5";
            this.btn5.Font = fonteBotao;
            this.btn5.Location = new System.Drawing.Point(60, 90);
            this.btn5.Size = new System.Drawing.Size(larguraBotao, alturaBotao);
            this.btn5.FlatStyle = FlatStyle.Flat;
            this.btn5.FlatAppearance.BorderSize = 1;
            this.btn5.FlatAppearance.BorderColor = corBordaBotao;
            this.btn5.BackColor = corBotao;
            this.btn5.Click += new EventHandler(this.btnNumero_Click);

            this.btn6.Text = "6";
            this.btn6.Font = fonteBotao;
            this.btn6.Location = new System.Drawing.Point(108, 90);
            this.btn6.Size = new System.Drawing.Size(larguraBotao, alturaBotao);
            this.btn6.FlatStyle = FlatStyle.Flat;
            this.btn6.FlatAppearance.BorderSize = 1;
            this.btn6.FlatAppearance.BorderColor = corBordaBotao;
            this.btn6.BackColor = corBotao;
            this.btn6.Click += new EventHandler(this.btnNumero_Click);

            this.btn7.Text = "7";
            this.btn7.Font = fonteBotao;
            this.btn7.Location = new System.Drawing.Point(12, 130);
            this.btn7.Size = new System.Drawing.Size(larguraBotao, alturaBotao);
            this.btn7.FlatStyle = FlatStyle.Flat;
            this.btn7.FlatAppearance.BorderSize = 1;
            this.btn7.FlatAppearance.BorderColor = corBordaBotao;
            this.btn7.BackColor = corBotao;
            this.btn7.Click += new EventHandler(this.btnNumero_Click);

            this.btn8.Text = "8";
            this.btn8.Font = fonteBotao;
            this.btn8.Location = new System.Drawing.Point(60, 130);
            this.btn8.Size = new System.Drawing.Size(larguraBotao, alturaBotao);
            this.btn8.FlatStyle = FlatStyle.Flat;
            this.btn8.FlatAppearance.BorderSize = 1;
            this.btn8.FlatAppearance.BorderColor = corBordaBotao;
            this.btn8.BackColor = corBotao;
            this.btn8.Click += new EventHandler(this.btnNumero_Click);

            this.btn9.Text = "9";
            this.btn9.Font = fonteBotao;
            this.btn9.Location = new System.Drawing.Point(108, 130);
            this.btn9.Size = new System.Drawing.Size(larguraBotao, alturaBotao);
            this.btn9.FlatStyle = FlatStyle.Flat;
            this.btn9.FlatAppearance.BorderSize = 1;
            this.btn9.FlatAppearance.BorderColor = corBordaBotao;
            this.btn9.BackColor = corBotao;
            this.btn9.Click += new EventHandler(this.btnNumero_Click);

            this.btn0.Text = "0";
            this.btn0.Font = fonteBotao;
            this.btn0.Location = new System.Drawing.Point(60, 170);
            this.btn0.Size = new System.Drawing.Size(larguraBotao, alturaBotao);
            this.btn0.FlatStyle = FlatStyle.Flat;
            this.btn0.FlatAppearance.BorderSize = 1;
            this.btn0.FlatAppearance.BorderColor = corBordaBotao;
            this.btn0.BackColor = corBotao;
            this.btn0.Click += new EventHandler(this.btnNumero_Click);

            // Operações
            this.btnSomar.Text = "+";
            this.btnSomar.Font = fonteBotao;
            this.btnSomar.Location = new System.Drawing.Point(156, 50);
            this.btnSomar.Size = new System.Drawing.Size(larguraBotao, alturaBotao);
            this.btnSomar.FlatStyle = FlatStyle.Flat;
            this.btnSomar.FlatAppearance.BorderSize = 1;
            this.btnSomar.FlatAppearance.BorderColor = corBordaBotao;
            this.btnSomar.BackColor = corBotaoOps;
            this.btnSomar.Click += new EventHandler(this.btnOperacao_Click);

            this.btnSubtrair.Text = "-";
            this.btnSubtrair.Font = fonteBotao;
            this.btnSubtrair.Location = new System.Drawing.Point(156, 90);
            this.btnSubtrair.Size = new System.Drawing.Size(larguraBotao, alturaBotao);
            this.btnSubtrair.FlatStyle = FlatStyle.Flat;
            this.btnSubtrair.FlatAppearance.BorderSize = 1;
            this.btnSubtrair.FlatAppearance.BorderColor = corBordaBotao;
            this.btnSubtrair.BackColor = corBotaoOps;
            this.btnSubtrair.Click += new EventHandler(this.btnOperacao_Click);

            this.btnMultiplicar.Text = "×";
            this.btnMultiplicar.Font = fonteBotao;
            this.btnMultiplicar.Location = new System.Drawing.Point(156, 130);
            this.btnMultiplicar.Size = new System.Drawing.Size(larguraBotao, alturaBotao);
            this.btnMultiplicar.FlatStyle = FlatStyle.Flat;
            this.btnMultiplicar.FlatAppearance.BorderSize = 1;
            this.btnMultiplicar.FlatAppearance.BorderColor = corBordaBotao;
            this.btnMultiplicar.BackColor = corBotaoOps;
            this.btnMultiplicar.Click += new EventHandler(this.btnOperacao_Click);

            this.btnDividir.Text = "÷";
            this.btnDividir.Font = fonteBotao;
            this.btnDividir.Location = new System.Drawing.Point(156, 170);
            this.btnDividir.Size = new System.Drawing.Size(larguraBotao, alturaBotao);
            this.btnDividir.FlatStyle = FlatStyle.Flat;
            this.btnDividir.FlatAppearance.BorderSize = 1;
            this.btnDividir.FlatAppearance.BorderColor = corBordaBotao;
            this.btnDividir.BackColor = corBotaoOps;
            this.btnDividir.Click += new EventHandler(this.btnOperacao_Click);

            this.btnIgual.Text = "=";
            this.btnIgual.Font = fonteBotao;
            this.btnIgual.Location = new System.Drawing.Point(108, 170);
            this.btnIgual.Size = new System.Drawing.Size(larguraBotao, alturaBotao);
            this.btnIgual.FlatStyle = FlatStyle.Flat;
            this.btnIgual.FlatAppearance.BorderSize = 1;
            this.btnIgual.FlatAppearance.BorderColor = corBordaBotao;
            this.btnIgual.BackColor = corBotaoOps;
            this.btnIgual.Click += new EventHandler(this.btnIgual_Click);

            this.btnClear.Text = "C";
            this.btnClear.Font = fonteBotao;
            this.btnClear.Location = new System.Drawing.Point(12, 170);
            this.btnClear.Size = new System.Drawing.Size(larguraBotao, alturaBotao);
            this.btnClear.FlatStyle = FlatStyle.Flat;
            this.btnClear.FlatAppearance.BorderSize = 1;
            this.btnClear.FlatAppearance.BorderColor = corBordaBotao;
            this.btnClear.BackColor = Color.Coral;
            this.btnClear.Click += new EventHandler(this.btnClear_Click);

            // ---- Funções científicas ----
            var corBotaoCientifico = Color.LightGreen;

            string[] funcoes = {
                "sin", "cos", "tan",
                "log", "ln", "√", "x²", "x³",
                "π", "e", "1/x",
                "(", ")", "%", "rad", "deg"
};

            int startY = 210;
            int startX = 12;
            int col = 0, row = 0;

            foreach (var func in funcoes)
            {
                var btnFunc = new Button();
                btnFunc.Text = func;
                btnFunc.Font = fonteBotao;
                btnFunc.Size = new System.Drawing.Size(larguraBotao, alturaBotao);
                btnFunc.FlatStyle = FlatStyle.Flat;
                btnFunc.FlatAppearance.BorderSize = 1;
                btnFunc.FlatAppearance.BorderColor = corBordaBotao;
                btnFunc.BackColor = corBotaoCientifico;
                btnFunc.Location = new System.Drawing.Point(startX + (col * 48), startY + (row * 42));
                btnFunc.Click += new EventHandler(this.btnFuncao_Click);
                this.Controls.Add(btnFunc);

                col++;
                if (col > 3) { col = 0; row++; }
            }

            // ---- Ajusta altura da janela ----
            this.ClientSize = new System.Drawing.Size(215, 225 + (row * 42));

            // Form
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnClear);
            this.BackColor = Color.White;
            this.Name = "Form1";
            this.Text = "iCalculadora";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
