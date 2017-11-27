namespace IHMForum
{
    partial class FenAjouterMessage
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtResponse = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelMessage = new System.Windows.Forms.Button();
            this.btnValiderMessage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkRed;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.69687F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.30313F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Controls.Add(this.txtResponse, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.95506F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.04494F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(607, 160);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtResponse
            // 
            this.txtResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResponse.Location = new System.Drawing.Point(65, 35);
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(468, 51);
            this.txtResponse.TabIndex = 0;
            this.txtResponse.Text = "";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.65089F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.34911F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel2.Controls.Add(this.btnCancelMessage, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnValiderMessage, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(65, 100);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(468, 44);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnCancelMessage
            // 
            this.btnCancelMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelMessage.Image = global::IHMForum.Properties.Resources.Close;
            this.btnCancelMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelMessage.Location = new System.Drawing.Point(197, 3);
            this.btnCancelMessage.Name = "btnCancelMessage";
            this.btnCancelMessage.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCancelMessage.Size = new System.Drawing.Size(120, 38);
            this.btnCancelMessage.TabIndex = 0;
            this.btnCancelMessage.Text = "  Annuler";
            this.btnCancelMessage.UseVisualStyleBackColor = true;
            this.btnCancelMessage.Click += new System.EventHandler(this.btnCancelMessage_Click);
            // 
            // btnValiderMessage
            // 
            this.btnValiderMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnValiderMessage.Image = global::IHMForum.Properties.Resources.Apply;
            this.btnValiderMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValiderMessage.Location = new System.Drawing.Point(335, 3);
            this.btnValiderMessage.Name = "btnValiderMessage";
            this.btnValiderMessage.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnValiderMessage.Size = new System.Drawing.Size(130, 38);
            this.btnValiderMessage.TabIndex = 1;
            this.btnValiderMessage.Text = "Valider";
            this.btnValiderMessage.UseVisualStyleBackColor = true;
            this.btnValiderMessage.Click += new System.EventHandler(this.btnValiderMessage_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(65, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Saisissez votre message";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FenAjouterMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 160);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FenAjouterMessage";
            this.Text = "Ajouter un Message";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnCancelMessage;
        private System.Windows.Forms.Button btnValiderMessage;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.RichTextBox txtResponse;
    }
}