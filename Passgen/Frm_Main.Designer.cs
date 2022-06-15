namespace Passgen
{
    partial class Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.Ckb_Numbers = new System.Windows.Forms.CheckBox();
            this.Ckb_Symbols = new System.Windows.Forms.CheckBox();
            this.Btn_Generate = new System.Windows.Forms.Button();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Btn_Clipboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ckb_Numbers
            // 
            this.Ckb_Numbers.AutoSize = true;
            this.Ckb_Numbers.Location = new System.Drawing.Point(12, 12);
            this.Ckb_Numbers.Name = "Ckb_Numbers";
            this.Ckb_Numbers.Size = new System.Drawing.Size(68, 17);
            this.Ckb_Numbers.TabIndex = 0;
            this.Ckb_Numbers.Text = "Numbers";
            this.Ckb_Numbers.UseVisualStyleBackColor = true;
            // 
            // Ckb_Symbols
            // 
            this.Ckb_Symbols.AutoSize = true;
            this.Ckb_Symbols.Location = new System.Drawing.Point(12, 35);
            this.Ckb_Symbols.Name = "Ckb_Symbols";
            this.Ckb_Symbols.Size = new System.Drawing.Size(65, 17);
            this.Ckb_Symbols.TabIndex = 1;
            this.Ckb_Symbols.Text = "Symbols";
            this.Ckb_Symbols.UseVisualStyleBackColor = true;
            // 
            // Btn_Generate
            // 
            this.Btn_Generate.Location = new System.Drawing.Point(178, 12);
            this.Btn_Generate.Name = "Btn_Generate";
            this.Btn_Generate.Size = new System.Drawing.Size(102, 40);
            this.Btn_Generate.TabIndex = 2;
            this.Btn_Generate.Text = "Generate";
            this.Btn_Generate.UseVisualStyleBackColor = true;
            this.Btn_Generate.Click += new System.EventHandler(this.Btn_Generate_Click);
            // 
            // Txt_Password
            // 
            this.Txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Password.Location = new System.Drawing.Point(12, 58);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.ReadOnly = true;
            this.Txt_Password.Size = new System.Drawing.Size(268, 26);
            this.Txt_Password.TabIndex = 3;
            // 
            // Btn_Clipboard
            // 
            this.Btn_Clipboard.Location = new System.Drawing.Point(12, 90);
            this.Btn_Clipboard.Name = "Btn_Clipboard";
            this.Btn_Clipboard.Size = new System.Drawing.Size(268, 33);
            this.Btn_Clipboard.TabIndex = 4;
            this.Btn_Clipboard.Text = "Copy to clipboard";
            this.Btn_Clipboard.UseVisualStyleBackColor = true;
            this.Btn_Clipboard.Click += new System.EventHandler(this.Btn_Clipboard_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 138);
            this.Controls.Add(this.Btn_Clipboard);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Btn_Generate);
            this.Controls.Add(this.Ckb_Symbols);
            this.Controls.Add(this.Ckb_Numbers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passgen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Ckb_Numbers;
        private System.Windows.Forms.CheckBox Ckb_Symbols;
        private System.Windows.Forms.Button Btn_Generate;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Button Btn_Clipboard;
    }
}

