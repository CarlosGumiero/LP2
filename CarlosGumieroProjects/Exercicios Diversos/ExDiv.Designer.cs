namespace CarlosGumieroProjects.Exercicios_Diversos
{
    partial class ExDiv
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
            this.btnExecutar = new System.Windows.Forms.Button();
            this.txtResp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(140, 50);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(136, 99);
            this.btnExecutar.TabIndex = 0;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            // 
            // txtResp
            // 
            this.txtResp.Location = new System.Drawing.Point(364, 59);
            this.txtResp.Multiline = true;
            this.txtResp.Name = "txtResp";
            this.txtResp.Size = new System.Drawing.Size(240, 239);
            this.txtResp.TabIndex = 1;
            this.txtResp.TextChanged += new System.EventHandler(this.txtResp_TextChanged);
            // 
            // ExDiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 354);
            this.Controls.Add(this.txtResp);
            this.Controls.Add(this.btnExecutar);
            this.Name = "ExDiv";
            this.Text = "ExDiv";
            this.Load += new System.EventHandler(this.ExDiv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.TextBox txtResp;
    }
}