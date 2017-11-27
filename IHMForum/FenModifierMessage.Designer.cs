namespace IHMForum
{
    partial class FenModifierMessage
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
            this.btnCancelModifMessage = new System.Windows.Forms.Button();
            this.txtModifMessage = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnValiderModifMessage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelModifMessage
            // 
            this.btnCancelModifMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelModifMessage.Image = global::IHMForum.Properties.Resources.Close;
            this.btnCancelModifMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelModifMessage.Location = new System.Drawing.Point(198, 3);
            this.btnCancelModifMessage.Name = "btnCancelModifMessage";
            this.btnCancelModifMessage.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCancelModifMessage.Size = new System.Drawing.Size(120, 39);
            this.btnCancelModifMessage.TabIndex = 0;
            this.btnCancelModifMessage.Text = "    Annuler";
            this.btnCancelModifMessage.UseVisualStyleBackColor = true;
            this.btnCancelModifMessage.Click += new System.EventHandler(this.btnCancelModifMessage_Click);
            // 
            // txtModifMessage
            // 
            this.txtModifMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModifMessage.Location = new System.Drawing.Point(65, 33);
            this.txtModifMessage.Name = "txtModifMessage";
            this.txtModifMessage.Size = new System.Drawing.Size(468, 56);
            this.txtModifMessage.TabIndex = 0;
            this.txtModifMessage.Text = "";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.65089F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.34911F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel2.Controls.Add(this.btnCancelModifMessage, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnValiderModifMessage, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(65, 103);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(468, 45);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnValiderModifMessage
            // 
            this.btnValiderModifMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnValiderModifMessage.Image = global::IHMForum.Properties.Resources.Apply;
            this.btnValiderModifMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValiderModifMessage.Location = new System.Drawing.Point(337, 3);
            this.btnValiderModifMessage.Name = "btnValiderModifMessage";
            this.btnValiderModifMessage.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnValiderModifMessage.Size = new System.Drawing.Size(128, 39);
            this.btnValiderModifMessage.TabIndex = 1;
            this.btnValiderModifMessage.Text = "Valider";
            this.btnValiderModifMessage.UseVisualStyleBackColor = true;
            this.btnValiderModifMessage.Click += new System.EventHandler(this.btnValiderModifMessage_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(65, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modifier votre message";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkRed;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.69687F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.30313F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.Controls.Add(this.txtModifMessage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.97872F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.02128F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(605, 162);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // FenModifierMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 162);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FenModifierMessage";
            this.Text = "Modifier Message";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelModifMessage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnValiderModifMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        internal System.Windows.Forms.RichTextBox txtModifMessage;
    }
}