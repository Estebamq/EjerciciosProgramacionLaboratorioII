
namespace WinFormsApp
{
    partial class FormPrincipal
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
            this.botonCalcular = new System.Windows.Forms.Button();
            this.richTxtBoxPalabras = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // botonCalcular
            // 
            this.botonCalcular.Location = new System.Drawing.Point(261, 306);
            this.botonCalcular.Name = "botonCalcular";
            this.botonCalcular.Size = new System.Drawing.Size(95, 23);
            this.botonCalcular.TabIndex = 0;
            this.botonCalcular.Text = "Calcular";
            this.botonCalcular.UseVisualStyleBackColor = true;
            this.botonCalcular.Click += new System.EventHandler(this.botonCalcular_Click);
            // 
            // richTxtBoxPalabras
            // 
            this.richTxtBoxPalabras.Location = new System.Drawing.Point(13, 13);
            this.richTxtBoxPalabras.Name = "richTxtBoxPalabras";
            this.richTxtBoxPalabras.Size = new System.Drawing.Size(343, 287);
            this.richTxtBoxPalabras.TabIndex = 1;
            this.richTxtBoxPalabras.Text = "";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 341);
            this.Controls.Add(this.richTxtBoxPalabras);
            this.Controls.Add(this.botonCalcular);
            this.Name = "FormPrincipal";
            this.Text = "Contador de Palabras";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonCalcular;
        private System.Windows.Forms.RichTextBox richTxtBoxPalabras;
    }
}

