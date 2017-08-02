namespace lps_domotica_vista
{
    partial class SeguimientoEnergia
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
            this.dgEnergia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgEnergia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEnergia
            // 
            this.dgEnergia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgEnergia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEnergia.Location = new System.Drawing.Point(12, 12);
            this.dgEnergia.Name = "dgEnergia";
            this.dgEnergia.Size = new System.Drawing.Size(403, 158);
            this.dgEnergia.TabIndex = 0;
            // 
            // SeguimientoEnergia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 182);
            this.Controls.Add(this.dgEnergia);
            this.Name = "SeguimientoEnergia";
            this.Text = "SeguimientoEnergia";
            this.Load += new System.EventHandler(this.SeguimientoEnergia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEnergia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEnergia;
    }
}