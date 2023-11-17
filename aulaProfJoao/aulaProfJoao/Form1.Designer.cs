namespace aulaProfJoao
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tx_RG = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_momento = new System.Windows.Forms.ComboBox();
            this.cb_funcao = new System.Windows.Forms.ComboBox();
            this.dt_nascimento = new System.Windows.Forms.DateTimePicker();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.tx_endereco = new System.Windows.Forms.TextBox();
            this.tx_cidade = new System.Windows.Forms.TextBox();
            this.mtx_CPF = new System.Windows.Forms.MaskedTextBox();
            this.mtx_RG = new System.Windows.Forms.MaskedTextBox();
            this.tx_estado = new System.Windows.Forms.TextBox();
            this.tx_salario = new System.Windows.Forms.TextBox();
            this.tx_email = new System.Windows.Forms.TextBox();
            this.mtx_telefone = new System.Windows.Forms.MaskedTextBox();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_concluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tx_RG
            // 
            this.tx_RG.AutoSize = true;
            this.tx_RG.BackColor = System.Drawing.Color.Transparent;
            this.tx_RG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_RG.ForeColor = System.Drawing.Color.White;
            this.tx_RG.Location = new System.Drawing.Point(242, 316);
            this.tx_RG.Name = "tx_RG";
            this.tx_RG.Size = new System.Drawing.Size(38, 18);
            this.tx_RG.TabIndex = 0;
            this.tx_RG.Text = "RG:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(518, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(653, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado Civil:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(565, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nascimento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(504, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Função:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(32, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "CPF:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(565, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Salario:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(32, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Estado:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(32, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Telefone:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(32, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Endereço:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(32, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 18);
            this.label12.TabIndex = 11;
            this.label12.Text = "Nome:";
            // 
            // cb_momento
            // 
            this.cb_momento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_momento.FormattingEnabled = true;
            this.cb_momento.Items.AddRange(new object[] {
            "solteiro",
            "casado",
            "separado",
            "divorciado",
            "viúvo"});
            this.cb_momento.Location = new System.Drawing.Point(646, 303);
            this.cb_momento.Name = "cb_momento";
            this.cb_momento.Size = new System.Drawing.Size(121, 24);
            this.cb_momento.TabIndex = 12;
            // 
            // cb_funcao
            // 
            this.cb_funcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_funcao.FormattingEnabled = true;
            this.cb_funcao.Items.AddRange(new object[] {
            "soldado",
            "Cabo",
            "SubTenente",
            "Tenente",
            "Capitão",
            "Major",
            "Coronel",
            "General"});
            this.cb_funcao.Location = new System.Drawing.Point(476, 303);
            this.cb_funcao.Name = "cb_funcao";
            this.cb_funcao.Size = new System.Drawing.Size(121, 24);
            this.cb_funcao.TabIndex = 13;
            // 
            // dt_nascimento
            // 
            this.dt_nascimento.Location = new System.Drawing.Point(123, 111);
            this.dt_nascimento.Name = "dt_nascimento";
            this.dt_nascimento.Size = new System.Drawing.Size(210, 20);
            this.dt_nascimento.TabIndex = 14;
            this.dt_nascimento.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // tx_nome
            // 
            this.tx_nome.Location = new System.Drawing.Point(96, 59);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(714, 20);
            this.tx_nome.TabIndex = 15;
            // 
            // tx_endereco
            // 
            this.tx_endereco.Location = new System.Drawing.Point(123, 270);
            this.tx_endereco.Name = "tx_endereco";
            this.tx_endereco.Size = new System.Drawing.Size(100, 20);
            this.tx_endereco.TabIndex = 16;
            // 
            // tx_cidade
            // 
            this.tx_cidade.Location = new System.Drawing.Point(636, 163);
            this.tx_cidade.Name = "tx_cidade";
            this.tx_cidade.Size = new System.Drawing.Size(100, 20);
            this.tx_cidade.TabIndex = 17;
            // 
            // mtx_CPF
            // 
            this.mtx_CPF.Location = new System.Drawing.Point(127, 317);
            this.mtx_CPF.Mask = "000,000,000-00";
            this.mtx_CPF.Name = "mtx_CPF";
            this.mtx_CPF.Size = new System.Drawing.Size(100, 20);
            this.mtx_CPF.TabIndex = 18;
            // 
            // mtx_RG
            // 
            this.mtx_RG.Location = new System.Drawing.Point(306, 316);
            this.mtx_RG.Mask = "0000000";
            this.mtx_RG.Name = "mtx_RG";
            this.mtx_RG.Size = new System.Drawing.Size(54, 20);
            this.mtx_RG.TabIndex = 19;
            // 
            // tx_estado
            // 
            this.tx_estado.Location = new System.Drawing.Point(123, 218);
            this.tx_estado.Name = "tx_estado";
            this.tx_estado.Size = new System.Drawing.Size(100, 20);
            this.tx_estado.TabIndex = 20;
            // 
            // tx_salario
            // 
            this.tx_salario.Location = new System.Drawing.Point(636, 219);
            this.tx_salario.Name = "tx_salario";
            this.tx_salario.Size = new System.Drawing.Size(100, 20);
            this.tx_salario.TabIndex = 22;
            // 
            // tx_email
            // 
            this.tx_email.Location = new System.Drawing.Point(579, 111);
            this.tx_email.Name = "tx_email";
            this.tx_email.Size = new System.Drawing.Size(231, 20);
            this.tx_email.TabIndex = 23;
            // 
            // mtx_telefone
            // 
            this.mtx_telefone.Location = new System.Drawing.Point(116, 160);
            this.mtx_telefone.Mask = "00 0000-0000";
            this.mtx_telefone.Name = "mtx_telefone";
            this.mtx_telefone.Size = new System.Drawing.Size(116, 20);
            this.mtx_telefone.TabIndex = 24;
            // 
            // bt_excluir
            // 
            this.bt_excluir.BackColor = System.Drawing.Color.Black;
            this.bt_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_excluir.ForeColor = System.Drawing.Color.White;
            this.bt_excluir.Location = new System.Drawing.Point(656, 373);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(92, 37);
            this.bt_excluir.TabIndex = 25;
            this.bt_excluir.Text = "EXCLUIR";
            this.bt_excluir.UseVisualStyleBackColor = false;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // bt_concluir
            // 
            this.bt_concluir.BackColor = System.Drawing.Color.Black;
            this.bt_concluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_concluir.ForeColor = System.Drawing.Color.Transparent;
            this.bt_concluir.Location = new System.Drawing.Point(116, 372);
            this.bt_concluir.Name = "bt_concluir";
            this.bt_concluir.Size = new System.Drawing.Size(87, 38);
            this.bt_concluir.TabIndex = 26;
            this.bt_concluir.Text = "CONCLUIR";
            this.bt_concluir.UseVisualStyleBackColor = false;
            this.bt_concluir.Click += new System.EventHandler(this.bt_concluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gabriola", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(283, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 54);
            this.label1.TabIndex = 27;
            this.label1.Text = "CADASTRO EXERCITO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::aulaProfJoao.Properties.Resources.imagem_exercito;
            this.ClientSize = new System.Drawing.Size(875, 435);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_concluir);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.mtx_telefone);
            this.Controls.Add(this.tx_email);
            this.Controls.Add(this.tx_salario);
            this.Controls.Add(this.tx_estado);
            this.Controls.Add(this.mtx_RG);
            this.Controls.Add(this.mtx_CPF);
            this.Controls.Add(this.tx_cidade);
            this.Controls.Add(this.tx_endereco);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.dt_nascimento);
            this.Controls.Add(this.cb_funcao);
            this.Controls.Add(this.cb_momento);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx_RG);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Name = "Form1";
            this.Text = "Cadastro de Funcionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tx_RG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_momento;
        private System.Windows.Forms.ComboBox cb_funcao;
        private System.Windows.Forms.DateTimePicker dt_nascimento;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.TextBox tx_endereco;
        private System.Windows.Forms.TextBox tx_cidade;
        private System.Windows.Forms.MaskedTextBox mtx_CPF;
        private System.Windows.Forms.MaskedTextBox mtx_RG;
        private System.Windows.Forms.TextBox tx_estado;
        private System.Windows.Forms.TextBox tx_salario;
        private System.Windows.Forms.TextBox tx_email;
        private System.Windows.Forms.MaskedTextBox mtx_telefone;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_concluir;
        private System.Windows.Forms.Label label1;
    }
}

