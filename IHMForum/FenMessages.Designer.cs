namespace IHMForum
{
    partial class FenMessages
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMessages = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pUserMessage = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAjouterMessage = new System.Windows.Forms.Button();
            this.btnModifierMessage = new System.Windows.Forms.Button();
            this.pModerateurMessage = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRetour = new System.Windows.Forms.Button();
            this.lbluser = new System.Windows.Forms.Label();
            this.bindingSourceMessages = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.pUserMessage.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.pModerateurMessage.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkRed;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.703911F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.29609F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.Controls.Add(this.dgvMessages, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.98374F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.01626F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(955, 717);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvMessages
            // 
            this.dgvMessages.AllowUserToAddRows = false;
            this.dgvMessages.AllowUserToDeleteRows = false;
            this.dgvMessages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMessages.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMessages.Location = new System.Drawing.Point(62, 89);
            this.dgvMessages.Name = "dgvMessages";
            this.dgvMessages.ReadOnly = true;
            this.dgvMessages.RowHeadersVisible = false;
            this.dgvMessages.RowHeadersWidth = 200;
            this.dgvMessages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMessages.Size = new System.Drawing.Size(820, 523);
            this.dgvMessages.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.16081F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.839187F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 330F));
            this.tableLayoutPanel2.Controls.Add(this.pUserMessage, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pModerateurMessage, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(62, 618);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(820, 75);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // pUserMessage
            // 
            this.pUserMessage.Controls.Add(this.tableLayoutPanel3);
            this.pUserMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pUserMessage.Location = new System.Drawing.Point(3, 3);
            this.pUserMessage.Name = "pUserMessage";
            this.pUserMessage.Size = new System.Drawing.Size(450, 69);
            this.pUserMessage.TabIndex = 0;
            this.pUserMessage.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.SlateGray;
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.22907F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.77093F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel3.Controls.Add(this.btnAjouterMessage, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnModifierMessage, 3, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.5614F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.4386F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(450, 69);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnAjouterMessage
            // 
            this.btnAjouterMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAjouterMessage.Image = global::IHMForum.Properties.Resources.Add;
            this.btnAjouterMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouterMessage.Location = new System.Drawing.Point(50, 18);
            this.btnAjouterMessage.Name = "btnAjouterMessage";
            this.btnAjouterMessage.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnAjouterMessage.Size = new System.Drawing.Size(137, 34);
            this.btnAjouterMessage.TabIndex = 0;
            this.btnAjouterMessage.Text = "    Ajouter message";
            this.btnAjouterMessage.UseVisualStyleBackColor = true;
            this.btnAjouterMessage.Click += new System.EventHandler(this.btnAjouterMessage_Click);
            // 
            // btnModifierMessage
            // 
            this.btnModifierMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModifierMessage.Enabled = false;
            this.btnModifierMessage.Image = global::IHMForum.Properties.Resources.Update;
            this.btnModifierMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifierMessage.Location = new System.Drawing.Point(221, 18);
            this.btnModifierMessage.Name = "btnModifierMessage";
            this.btnModifierMessage.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnModifierMessage.Size = new System.Drawing.Size(156, 34);
            this.btnModifierMessage.TabIndex = 1;
            this.btnModifierMessage.Text = "   Editer message";
            this.btnModifierMessage.UseVisualStyleBackColor = true;
            this.btnModifierMessage.Click += new System.EventHandler(this.btnModifierMessage_Click);
            // 
            // pModerateurMessage
            // 
            this.pModerateurMessage.Controls.Add(this.tableLayoutPanel4);
            this.pModerateurMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pModerateurMessage.Location = new System.Drawing.Point(492, 3);
            this.pModerateurMessage.Name = "pModerateurMessage";
            this.pModerateurMessage.Size = new System.Drawing.Size(325, 69);
            this.pModerateurMessage.TabIndex = 1;
            this.pModerateurMessage.Visible = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.SlateGray;
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.55466F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.44534F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel4.Controls.Add(this.button1, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(325, 69);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Image = global::IHMForum.Properties.Resources.Delete;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(75, 18);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(160, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "      Supprimer  message";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.SlateGray;
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.046036F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.95396F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel5.Controls.Add(this.btnRetour, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.lbluser, 1, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(62, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.66666F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(820, 80);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // btnRetour
            // 
            this.btnRetour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRetour.Image = global::IHMForum.Properties.Resources.Home;
            this.btnRetour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRetour.Location = new System.Drawing.Point(623, 20);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnRetour.Size = new System.Drawing.Size(168, 37);
            this.btnRetour.TabIndex = 0;
            this.btnRetour.Text = "Retour à l\'accueil";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // lbluser
            // 
            this.lbluser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.Color.Yellow;
            this.lbluser.Location = new System.Drawing.Point(15, 17);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(51, 43);
            this.lbluser.TabIndex = 1;
            this.lbluser.Text = "label1";
            this.lbluser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FenMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 717);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FenMessages";
            this.Text = "Messages";
            this.Load += new System.EventHandler(this.FenMessages_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pUserMessage.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.pModerateurMessage.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMessages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnAjouterMessage;
        private System.Windows.Forms.Button btnModifierMessage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnRetour;
        internal System.Windows.Forms.BindingSource bindingSourceMessages;
        internal System.Windows.Forms.DataGridView dgvMessages;
        internal System.Windows.Forms.Label lbluser;
        internal System.Windows.Forms.Panel pUserMessage;
        internal System.Windows.Forms.Panel pModerateurMessage;
    }
}