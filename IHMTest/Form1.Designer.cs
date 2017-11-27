namespace IHMTest
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvRubric = new System.Windows.Forms.DataGridView();
            this.cbxRubric = new System.Windows.Forms.ComboBox();
            this.bindingSourceRubric = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblconnect = new System.Windows.Forms.Label();
            this.lblModo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRubric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRubric)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.2268F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.77319F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvRubric, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbxRubric, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.72165F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.27835F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 485);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvRubric
            // 
            this.dgvRubric.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRubric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRubric.Location = new System.Drawing.Point(148, 55);
            this.dgvRubric.Name = "dgvRubric";
            this.dgvRubric.Size = new System.Drawing.Size(449, 427);
            this.dgvRubric.TabIndex = 1;
            this.dgvRubric.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRubric_CellContentClick);
            // 
            // cbxRubric
            // 
            this.cbxRubric.FormattingEnabled = true;
            this.cbxRubric.Location = new System.Drawing.Point(3, 55);
            this.cbxRubric.Name = "cbxRubric";
            this.cbxRubric.Size = new System.Drawing.Size(139, 21);
            this.cbxRubric.TabIndex = 2;
            this.cbxRubric.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.txtLogin, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtPass, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnValider, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblconnect, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblModo, 0, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(603, 55);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.53271F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.46729F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 254F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(170, 427);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // txtLogin
            // 
            this.txtLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogin.Location = new System.Drawing.Point(3, 3);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(164, 20);
            this.txtLogin.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPass.Location = new System.Drawing.Point(3, 47);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(164, 20);
            this.txtPass.TabIndex = 1;
            // 
            // btnValider
            // 
            this.btnValider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnValider.Location = new System.Drawing.Point(3, 92);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(164, 32);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lblconnect
            // 
            this.lblconnect.AutoSize = true;
            this.lblconnect.Location = new System.Drawing.Point(3, 127);
            this.lblconnect.Name = "lblconnect";
            this.lblconnect.Size = new System.Drawing.Size(35, 13);
            this.lblconnect.TabIndex = 3;
            this.lblconnect.Text = "label1";
            // 
            // lblModo
            // 
            this.lblModo.AutoSize = true;
            this.lblModo.Location = new System.Drawing.Point(3, 172);
            this.lblModo.Name = "lblModo";
            this.lblModo.Size = new System.Drawing.Size(35, 13);
            this.lblModo.TabIndex = 4;
            this.lblModo.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 485);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRubric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRubric)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvRubric;
        private System.Windows.Forms.ComboBox cbxRubric;
        private System.Windows.Forms.BindingSource bindingSourceRubric;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblconnect;
        private System.Windows.Forms.Label lblModo;
    }
}

