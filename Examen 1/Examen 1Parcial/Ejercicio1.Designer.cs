namespace Examen_1Parcial
{
    partial class Ejercicio1
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
            this.InteresListBox = new System.Windows.Forms.ListBox();
            this.CalculoInteresButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InteresListBox
            // 
            this.InteresListBox.FormattingEnabled = true;
            this.InteresListBox.ItemHeight = 16;
            this.InteresListBox.Location = new System.Drawing.Point(49, 24);
            this.InteresListBox.Name = "InteresListBox";
            this.InteresListBox.Size = new System.Drawing.Size(187, 132);
            this.InteresListBox.TabIndex = 1;
            // 
            // CalculoInteresButton
            // 
            this.CalculoInteresButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculoInteresButton.Location = new System.Drawing.Point(273, 158);
            this.CalculoInteresButton.Name = "CalculoInteresButton";
            this.CalculoInteresButton.Size = new System.Drawing.Size(127, 31);
            this.CalculoInteresButton.TabIndex = 2;
            this.CalculoInteresButton.Text = "Calcular Interes";
            this.CalculoInteresButton.UseVisualStyleBackColor = true;
            this.CalculoInteresButton.Click += new System.EventHandler(this.CalculoInteresButton_Click);
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 215);
            this.Controls.Add(this.CalculoInteresButton);
            this.Controls.Add(this.InteresListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ejercicio1";
            this.Text = "Ejercicio1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox InteresListBox;
        private System.Windows.Forms.Button CalculoInteresButton;
    }
}