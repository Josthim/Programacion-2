namespace winThereads
{
    partial class frmWinThereads
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
            this.pb1 = new System.Windows.Forms.ProgressBar();
            this.pb2 = new System.Windows.Forms.ProgressBar();
            this.pb3 = new System.Windows.Forms.ProgressBar();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(253, 48);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(437, 23);
            this.pb1.TabIndex = 0;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(253, 108);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(437, 23);
            this.pb2.TabIndex = 1;
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(253, 167);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(437, 23);
            this.pb3.TabIndex = 2;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIniciar.Location = new System.Drawing.Point(68, 96);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(102, 46);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // frmWinThereads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(773, 250);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Name = "frmWinThereads";
            this.Text = "frmWinThereads";
            this.ResumeLayout(false);

        }

        #endregion

        private ProgressBar pb1;
        private ProgressBar pb2;
        private ProgressBar pb3;
        private Button btnIniciar;
    }
}