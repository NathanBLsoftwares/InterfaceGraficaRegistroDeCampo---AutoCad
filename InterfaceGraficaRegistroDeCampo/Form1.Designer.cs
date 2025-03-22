namespace InterfaceGraficaRegistroDeCampo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            versoes = new CheckedListBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            BotaoDeInicializacao = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            BotaoReveterInicialização = new Button();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(versoes, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.77956F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.Size = new Size(843, 499);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // versoes
            // 
            versoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            versoes.FormattingEnabled = true;
            versoes.Location = new Point(10, 10);
            versoes.Margin = new Padding(10);
            versoes.Name = "versoes";
            versoes.Size = new Size(327, 400);
            versoes.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 437);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(837, 59);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(BotaoDeInicializacao);
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(160, 44);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // BotaoDeInicializacao
            // 
            BotaoDeInicializacao.Anchor = AnchorStyles.Bottom;
            BotaoDeInicializacao.Location = new Point(3, 3);
            BotaoDeInicializacao.Name = "BotaoDeInicializacao";
            BotaoDeInicializacao.Size = new Size(157, 41);
            BotaoDeInicializacao.TabIndex = 0;
            BotaoDeInicializacao.Text = "Configurar Inicialização";
            BotaoDeInicializacao.UseVisualStyleBackColor = true;
            BotaoDeInicializacao.Click += BotaoDeInicializacao_Click;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(BotaoReveterInicialização);
            flowLayoutPanel3.Location = new Point(169, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(165, 44);
            flowLayoutPanel3.TabIndex = 1;
            // 
            // BotaoReveterInicialização
            // 
            BotaoReveterInicialização.Anchor = AnchorStyles.Bottom;
            BotaoReveterInicialização.Location = new Point(3, 3);
            BotaoReveterInicialização.Name = "BotaoReveterInicialização";
            BotaoReveterInicialização.Size = new Size(162, 41);
            BotaoReveterInicialização.TabIndex = 0;
            BotaoReveterInicialização.Text = "Reverter Inicialização";
            BotaoReveterInicialização.UseVisualStyleBackColor = true;
            BotaoReveterInicialização.Click += BotaoReveterInicialização_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 499);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private CheckedListBox versoes;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button BotaoDeInicializacao;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button BotaoReveterInicialização;
    }
}
