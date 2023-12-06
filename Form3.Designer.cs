namespace CestasDaPrima
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lsvItens = new System.Windows.Forms.ListView();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.grbFormulario = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.numPreco = new System.Windows.Forms.NumericUpDown();
            this.numID = new System.Windows.Forms.NumericUpDown();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstResultadosBusca = new System.Windows.Forms.ListView();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.grbFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).BeginInit();
            this.SuspendLayout();
            // 
            // lsvItens
            // 
            this.lsvItens.HideSelection = false;
            this.lsvItens.Location = new System.Drawing.Point(12, 12);
            this.lsvItens.Name = "lsvItens";
            this.lsvItens.Size = new System.Drawing.Size(408, 509);
            this.lsvItens.TabIndex = 0;
            this.lsvItens.UseCompatibleStateImageBehavior = false;
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(550, 476);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(118, 45);
            this.btnApagar.TabIndex = 1;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(674, 476);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(118, 45);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(426, 476);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(118, 45);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Novo Item";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click_1);
            // 
            // grbFormulario
            // 
            this.grbFormulario.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grbFormulario.Controls.Add(this.btnCancelar);
            this.grbFormulario.Controls.Add(this.btnSalvar);
            this.grbFormulario.Controls.Add(this.numPreco);
            this.grbFormulario.Controls.Add(this.numID);
            this.grbFormulario.Controls.Add(this.txtNome);
            this.grbFormulario.Controls.Add(this.label3);
            this.grbFormulario.Controls.Add(this.label2);
            this.grbFormulario.Controls.Add(this.label1);
            this.grbFormulario.Location = new System.Drawing.Point(426, 12);
            this.grbFormulario.Name = "grbFormulario";
            this.grbFormulario.Size = new System.Drawing.Size(361, 193);
            this.grbFormulario.TabIndex = 2;
            this.grbFormulario.TabStop = false;
            this.grbFormulario.Text = "Formulário";
            this.grbFormulario.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(270, 155);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 32);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(189, 155);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 32);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // numPreco
            // 
            this.numPreco.Location = new System.Drawing.Point(6, 97);
            this.numPreco.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPreco.Name = "numPreco";
            this.numPreco.Size = new System.Drawing.Size(164, 26);
            this.numPreco.TabIndex = 2;
            this.numPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numID
            // 
            this.numID.Enabled = false;
            this.numID.Location = new System.Drawing.Point(6, 45);
            this.numID.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numID.Name = "numID";
            this.numID.Size = new System.Drawing.Size(120, 26);
            this.numID.TabIndex = 2;
            this.numID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(132, 45);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(223, 26);
            this.txtNome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Preço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // lstResultadosBusca
            // 
            this.lstResultadosBusca.HideSelection = false;
            this.lstResultadosBusca.Location = new System.Drawing.Point(426, 264);
            this.lstResultadosBusca.Name = "lstResultadosBusca";
            this.lstResultadosBusca.Size = new System.Drawing.Size(361, 195);
            this.lstResultadosBusca.TabIndex = 3;
            this.lstResultadosBusca.UseCompatibleStateImageBehavior = false;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(426, 232);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(361, 26);
            this.txtPesquisa.TabIndex = 4;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 533);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lstResultadosBusca);
            this.Controls.Add(this.grbFormulario);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.lsvItens);
            this.Name = "Form3";
            this.Text = "ListView Form";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.grbFormulario.ResumeLayout(false);
            this.grbFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvItens;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.GroupBox grbFormulario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.NumericUpDown numPreco;
        private System.Windows.Forms.NumericUpDown numID;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstResultadosBusca;
        private System.Windows.Forms.TextBox txtPesquisa;
    }
}