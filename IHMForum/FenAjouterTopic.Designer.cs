namespace IHMForum
{
    partial class FenAjouterTopic
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitreTopic = new System.Windows.Forms.TextBox();
            this.txtDescTopic = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelTopic = new System.Windows.Forms.Button();
            this.btnValiderTopic = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAjoutMessage = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkRed;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.77876F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.22124F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 532F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtTitreTopic, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDescTopic, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.71186F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.28814F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(683, 222);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titre du Topic :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(29, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTitreTopic
            // 
            this.txtTitreTopic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitreTopic.Location = new System.Drawing.Point(116, 34);
            this.txtTitreTopic.Name = "txtTitreTopic";
            this.txtTitreTopic.Size = new System.Drawing.Size(526, 20);
            this.txtTitreTopic.TabIndex = 2;
            // 
            // txtDescTopic
            // 
            this.txtDescTopic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescTopic.Location = new System.Drawing.Point(116, 66);
            this.txtDescTopic.Name = "txtDescTopic";
            this.txtDescTopic.Size = new System.Drawing.Size(526, 20);
            this.txtDescTopic.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.39344F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.60656F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel2.Controls.Add(this.btnCancelTopic, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnValiderTopic, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(116, 157);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(526, 42);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // btnCancelTopic
            // 
            this.btnCancelTopic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelTopic.Image = global::IHMForum.Properties.Resources.Close;
            this.btnCancelTopic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelTopic.Location = new System.Drawing.Point(250, 3);
            this.btnCancelTopic.Name = "btnCancelTopic";
            this.btnCancelTopic.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCancelTopic.Size = new System.Drawing.Size(119, 36);
            this.btnCancelTopic.TabIndex = 0;
            this.btnCancelTopic.Text = "Annuler";
            this.btnCancelTopic.UseVisualStyleBackColor = true;
            this.btnCancelTopic.Click += new System.EventHandler(this.btnCancelTopic_Click);
            // 
            // btnValiderTopic
            // 
            this.btnValiderTopic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnValiderTopic.Image = global::IHMForum.Properties.Resources.Apply;
            this.btnValiderTopic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValiderTopic.Location = new System.Drawing.Point(389, 3);
            this.btnValiderTopic.Name = "btnValiderTopic";
            this.btnValiderTopic.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnValiderTopic.Size = new System.Drawing.Size(134, 36);
            this.btnValiderTopic.TabIndex = 1;
            this.btnValiderTopic.Text = "Valider";
            this.btnValiderTopic.UseVisualStyleBackColor = true;
            this.btnValiderTopic.Click += new System.EventHandler(this.btnValiderTopic_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAjoutMessage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(116, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 54);
            this.panel1.TabIndex = 5;
            // 
            // txtAjoutMessage
            // 
            this.txtAjoutMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAjoutMessage.Location = new System.Drawing.Point(0, 0);
            this.txtAjoutMessage.Name = "txtAjoutMessage";
            this.txtAjoutMessage.Size = new System.Drawing.Size(526, 54);
            this.txtAjoutMessage.TabIndex = 0;
            this.txtAjoutMessage.Text = "";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(116, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vous devez obligatoirement ajouter un message à ce Topic";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(29, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 60);
            this.label4.TabIndex = 7;
            this.label4.Text = "Message :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FenAjouterTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 222);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FenAjouterTopic";
            this.Text = "Ajouter un Topic";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnCancelTopic;
        private System.Windows.Forms.Button btnValiderTopic;
        internal System.Windows.Forms.TextBox txtTitreTopic;
        internal System.Windows.Forms.TextBox txtDescTopic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.RichTextBox txtAjoutMessage;
    }
}