namespace Hilos
{
    partial class frmHilos
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
            this.Temporalizador = new System.Windows.Forms.Timer(this.components);
            this.pbProgreso = new System.Windows.Forms.ProgressBar();
            this.lblHoras = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.numCargaCPU = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCargaCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // Temporalizador
            // 
            this.Temporalizador.Enabled = true;
            this.Temporalizador.Interval = 1000;
            this.Temporalizador.Tick += new System.EventHandler(this.Temporalizador_Tick);
            // 
            // pbProgreso
            // 
            this.pbProgreso.Location = new System.Drawing.Point(99, 94);
            this.pbProgreso.Name = "pbProgreso";
            this.pbProgreso.Size = new System.Drawing.Size(412, 23);
            this.pbProgreso.Step = 1;
            this.pbProgreso.TabIndex = 0;
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHoras.Location = new System.Drawing.Point(30, 36);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(121, 37);
            this.lblHoras.TabIndex = 1;
            this.lblHoras.Text = "00:00:00";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(240, 141);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(96, 45);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // numCargaCPU
            // 
            this.numCargaCPU.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numCargaCPU.Location = new System.Drawing.Point(391, 244);
            this.numCargaCPU.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numCargaCPU.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numCargaCPU.Name = "numCargaCPU";
            this.numCargaCPU.Size = new System.Drawing.Size(120, 23);
            this.numCargaCPU.TabIndex = 3;
            this.numCargaCPU.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Carga CPU";
            // 
            // frmHilos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 331);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numCargaCPU);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.pbProgreso);
            this.Name = "frmHilos";
            this.Text = "Multitareas";
            ((System.ComponentModel.ISupportInitialize)(this.numCargaCPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Temporalizador;
        private ProgressBar pbProgreso;
        private Label lblHoras;
        private Button btnCalcular;
        private NumericUpDown numCargaCPU;
        private Label label2;
    }
}