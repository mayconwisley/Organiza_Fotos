namespace Organiza_Fotos
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.txtDiretorio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnProcura = new System.Windows.Forms.Button();
            this.tvArvorePasta = new System.Windows.Forms.TreeView();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.BtnProcessar = new System.Windows.Forms.Button();
            this.PbImagem = new System.Windows.Forms.PictureBox();
            this.CbCriarAtePastaMes = new System.Windows.Forms.CheckBox();
            this.LblProcessando = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Processo_Worker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.PbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDiretorio
            // 
            this.txtDiretorio.Location = new System.Drawing.Point(12, 25);
            this.txtDiretorio.Name = "txtDiretorio";
            this.txtDiretorio.Size = new System.Drawing.Size(440, 20);
            this.txtDiretorio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Diretório";
            // 
            // BtnProcura
            // 
            this.BtnProcura.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnProcura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnProcura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnProcura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProcura.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProcura.Location = new System.Drawing.Point(426, 26);
            this.BtnProcura.Margin = new System.Windows.Forms.Padding(0);
            this.BtnProcura.Name = "BtnProcura";
            this.BtnProcura.Size = new System.Drawing.Size(25, 18);
            this.BtnProcura.TabIndex = 2;
            this.BtnProcura.Text = "...";
            this.BtnProcura.UseCompatibleTextRendering = true;
            this.BtnProcura.UseVisualStyleBackColor = true;
            this.BtnProcura.Click += new System.EventHandler(this.BtnProcura_Click);
            // 
            // tvArvorePasta
            // 
            this.tvArvorePasta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvArvorePasta.ImageIndex = 0;
            this.tvArvorePasta.ImageList = this.imgList;
            this.tvArvorePasta.Location = new System.Drawing.Point(12, 105);
            this.tvArvorePasta.Name = "tvArvorePasta";
            this.tvArvorePasta.SelectedImageIndex = 0;
            this.tvArvorePasta.Size = new System.Drawing.Size(290, 340);
            this.tvArvorePasta.TabIndex = 3;
            this.tvArvorePasta.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TvArvorePasta_NodeMouseClick);
            this.tvArvorePasta.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TvArvorePasta_NodeMouseDoubleClick);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "Arquivo.png");
            this.imgList.Images.SetKeyName(1, "Pasta.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Arvore de Pastas";
            // 
            // BtnProcessar
            // 
            this.BtnProcessar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnProcessar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnProcessar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnProcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProcessar.Location = new System.Drawing.Point(458, 24);
            this.BtnProcessar.Name = "BtnProcessar";
            this.BtnProcessar.Size = new System.Drawing.Size(140, 21);
            this.BtnProcessar.TabIndex = 5;
            this.BtnProcessar.Text = "Processar";
            this.BtnProcessar.UseCompatibleTextRendering = true;
            this.BtnProcessar.UseVisualStyleBackColor = true;
            this.BtnProcessar.Click += new System.EventHandler(this.BtnProcessar_Click);
            // 
            // PbImagem
            // 
            this.PbImagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbImagem.Location = new System.Drawing.Point(308, 105);
            this.PbImagem.Name = "PbImagem";
            this.PbImagem.Size = new System.Drawing.Size(480, 340);
            this.PbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbImagem.TabIndex = 10;
            this.PbImagem.TabStop = false;
            // 
            // CbCriarAtePastaMes
            // 
            this.CbCriarAtePastaMes.AutoSize = true;
            this.CbCriarAtePastaMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbCriarAtePastaMes.Location = new System.Drawing.Point(604, 26);
            this.CbCriarAtePastaMes.Name = "CbCriarAtePastaMes";
            this.CbCriarAtePastaMes.Size = new System.Drawing.Size(136, 17);
            this.CbCriarAtePastaMes.TabIndex = 11;
            this.CbCriarAtePastaMes.Text = "Criar Apenas Pasta Mês";
            this.CbCriarAtePastaMes.UseVisualStyleBackColor = true;
            this.CbCriarAtePastaMes.CheckedChanged += new System.EventHandler(this.CbCriarAtePastaMes_CheckedChanged);
            // 
            // LblProcessando
            // 
            this.LblProcessando.AutoSize = true;
            this.LblProcessando.Location = new System.Drawing.Point(305, 89);
            this.LblProcessando.Name = "LblProcessando";
            this.LblProcessando.Size = new System.Drawing.Size(16, 13);
            this.LblProcessando.TabIndex = 12;
            this.LblProcessando.Text = "...";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 9);
            this.label3.TabIndex = 13;
            this.label3.Text = "Maycon Wisley - v1.0";
            // 
            // Processo_Worker
            // 
            this.Processo_Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Processo_Worker_DoWork);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblProcessando);
            this.Controls.Add(this.CbCriarAtePastaMes);
            this.Controls.Add(this.PbImagem);
            this.Controls.Add(this.BtnProcessar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tvArvorePasta);
            this.Controls.Add(this.BtnProcura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiretorio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organizador Fotos - Simples";
            ((System.ComponentModel.ISupportInitialize)(this.PbImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDiretorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnProcura;
        private System.Windows.Forms.TreeView tvArvorePasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnProcessar;
        private System.Windows.Forms.PictureBox PbImagem;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.CheckBox CbCriarAtePastaMes;
        private System.Windows.Forms.Label LblProcessando;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker Processo_Worker;
    }
}

