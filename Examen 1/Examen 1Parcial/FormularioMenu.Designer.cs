namespace Examen_1Parcial
{
    partial class FormularioMenu
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
            this.Formulario2Button = new System.Windows.Forms.Button();
            this.Formulario3Button = new System.Windows.Forms.Button();
            this.Formulario1Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Formulario2Button
            // 
            this.Formulario2Button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Formulario2Button.Location = new System.Drawing.Point(144, 117);
            this.Formulario2Button.Name = "Formulario2Button";
            this.Formulario2Button.Size = new System.Drawing.Size(100, 38);
            this.Formulario2Button.TabIndex = 1;
            this.Formulario2Button.Text = "Formulario 2";
            this.Formulario2Button.UseVisualStyleBackColor = false;
            this.Formulario2Button.Click += new System.EventHandler(this.Formulario2Button_Click);
            // 
            // Formulario3Button
            // 
            this.Formulario3Button.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Formulario3Button.Location = new System.Drawing.Point(144, 182);
            this.Formulario3Button.Name = "Formulario3Button";
            this.Formulario3Button.Size = new System.Drawing.Size(100, 35);
            this.Formulario3Button.TabIndex = 2;
            this.Formulario3Button.Text = "Formulario 3";
            this.Formulario3Button.UseVisualStyleBackColor = false;
            this.Formulario3Button.Click += new System.EventHandler(this.Formulario3Button_Click);
            // 
            // Formulario1Button
            // 
            this.Formulario1Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Formulario1Button.Location = new System.Drawing.Point(144, 50);
            this.Formulario1Button.Name = "Formulario1Button";
            this.Formulario1Button.Size = new System.Drawing.Size(100, 40);
            this.Formulario1Button.TabIndex = 3;
            this.Formulario1Button.Text = "Formulario 1";
            this.Formulario1Button.UseVisualStyleBackColor = false;
            this.Formulario1Button.Click += new System.EventHandler(this.Formulario1Button_Click);
            // 
            // FormularioMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 313);
            this.Controls.Add(this.Formulario1Button);
            this.Controls.Add(this.Formulario3Button);
            this.Controls.Add(this.Formulario2Button);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormularioMenu";
            this.Text = "Formulario1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Formulario2Button;
        private System.Windows.Forms.Button Formulario3Button;
        private System.Windows.Forms.Button Formulario1Button;
    }
}