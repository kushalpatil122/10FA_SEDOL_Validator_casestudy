
namespace SEDOL_Checker
{
    partial class frmSEDOLChecker
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
            this.btnSEDOLChecker = new System.Windows.Forms.Button();
            this.txtSEDOLChecker = new System.Windows.Forms.TextBox();
            this.dgvSEDOLChecker = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSEDOLChecker)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSEDOLChecker
            // 
            this.btnSEDOLChecker.Location = new System.Drawing.Point(195, 13);
            this.btnSEDOLChecker.Name = "btnSEDOLChecker";
            this.btnSEDOLChecker.Size = new System.Drawing.Size(161, 23);
            this.btnSEDOLChecker.TabIndex = 0;
            this.btnSEDOLChecker.Text = "SEDOL Checker";
            this.btnSEDOLChecker.UseVisualStyleBackColor = true;
            this.btnSEDOLChecker.Click += new System.EventHandler(this.btnSEDOLChecker_Click);
            // 
            // txtSEDOLChecker
            // 
            this.txtSEDOLChecker.Location = new System.Drawing.Point(13, 13);
            this.txtSEDOLChecker.Name = "txtSEDOLChecker";
            this.txtSEDOLChecker.Size = new System.Drawing.Size(176, 23);
            this.txtSEDOLChecker.TabIndex = 1;
            // 
            // dgvSEDOLChecker
            // 
            this.dgvSEDOLChecker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSEDOLChecker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSEDOLChecker.Location = new System.Drawing.Point(13, 52);
            this.dgvSEDOLChecker.Name = "dgvSEDOLChecker";
            this.dgvSEDOLChecker.RowTemplate.Height = 25;
            this.dgvSEDOLChecker.Size = new System.Drawing.Size(777, 337);
            this.dgvSEDOLChecker.TabIndex = 2;
            // 
            // frmSEDOLChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 401);
            this.Controls.Add(this.dgvSEDOLChecker);
            this.Controls.Add(this.txtSEDOLChecker);
            this.Controls.Add(this.btnSEDOLChecker);
            this.Name = "frmSEDOLChecker";
            this.Text = "SEDOL Checker";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSEDOLChecker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSEDOLChecker;
        private System.Windows.Forms.TextBox txtSEDOLChecker;
        private System.Windows.Forms.DataGridView dgvSEDOLChecker;
    }
}

