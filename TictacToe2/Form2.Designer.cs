
namespace TictacToe2
{
    partial class Form2
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
            this.button3 = new System.Windows.Forms.Button();
            this.X_O_display_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(716, 302);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 53);
            this.button3.TabIndex = 2;
            this.button3.Text = "reset";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // X_O_display_button
            // 
            this.X_O_display_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X_O_display_button.Location = new System.Drawing.Point(716, 168);
            this.X_O_display_button.Name = "X_O_display_button";
            this.X_O_display_button.Size = new System.Drawing.Size(129, 112);
            this.X_O_display_button.TabIndex = 3;
            this.X_O_display_button.Text = "X";
            this.X_O_display_button.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(88, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 464);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Human";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 609);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.X_O_display_button);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button X_O_display_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}