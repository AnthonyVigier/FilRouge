namespace IHMForum
{
    partial class FenAccueil
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvTopics = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUser = new System.Windows.Forms.Label();
            this.cbxRubric = new System.Windows.Forms.ComboBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.cbxid = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.PUser = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAjouterTopic = new System.Windows.Forms.Button();
            this.pModerateur = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnModifTopic = new System.Windows.Forms.Button();
            this.btnSuppTopic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDeconnection = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.pAjoutMessage = new System.Windows.Forms.Panel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAjouterMessage = new System.Windows.Forms.Button();
            this.btnModifierMessage = new System.Windows.Forms.Button();
            this.dgvMessages = new System.Windows.Forms.DataGridView();
            this.pSuppMessage = new System.Windows.Forms.Panel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteResponse = new System.Windows.Forms.Button();
            this.dgvMessage = new System.Windows.Forms.DataGridView();
            this.bindingSourceRubric = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceTopics = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceMessage = new System.Windows.Forms.BindingSource(this.components);
            this.topicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.responseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTopicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRubricDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAuthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idResponseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTopicDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responseTxtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAuthorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopics)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.PUser.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.pModerateur.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.pAjoutMessage.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).BeginInit();
            this.pSuppMessage.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRubric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTopics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkRed;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.66181F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.3382F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel1.Controls.Add(this.dgvTopics, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.dgvMessage, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.93877F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.06123F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 252F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 367F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1147, 900);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvTopics
            // 
            this.dgvTopics.AllowUserToAddRows = false;
            this.dgvTopics.AllowUserToDeleteRows = false;
            this.dgvTopics.AllowUserToOrderColumns = true;
            this.dgvTopics.AutoGenerateColumns = false;
            this.dgvTopics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopics.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTopics.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTopics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTopicDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.dateCreationDataGridViewTextBoxColumn,
            this.auteurDataGridViewTextBoxColumn,
            this.idRubricDataGridViewTextBoxColumn,
            this.idAuthorDataGridViewTextBoxColumn});
            this.dgvTopics.DataSource = this.topicBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTopics.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTopics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTopics.Location = new System.Drawing.Point(120, 117);
            this.dgvTopics.Name = "dgvTopics";
            this.dgvTopics.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTopics.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTopics.RowHeadersVisible = false;
            this.dgvTopics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTopics.Size = new System.Drawing.Size(884, 246);
            this.dgvTopics.TabIndex = 0;
            this.dgvTopics.Click += new System.EventHandler(this.dgvTopics_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.SlateGray;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.90419F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.09581F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 232F));
            this.tableLayoutPanel2.Controls.Add(this.lblUser, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbxRubric, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnConnexion, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbxid, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblID, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(120, 48);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(884, 44);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Yellow;
            this.lblUser.Location = new System.Drawing.Point(412, 2);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 40);
            this.lblUser.TabIndex = 4;
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUser.Visible = false;
            // 
            // cbxRubric
            // 
            this.cbxRubric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxRubric.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRubric.FormattingEnabled = true;
            this.cbxRubric.Location = new System.Drawing.Point(5, 12);
            this.cbxRubric.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cbxRubric.Name = "cbxRubric";
            this.cbxRubric.Size = new System.Drawing.Size(150, 21);
            this.cbxRubric.TabIndex = 0;
            this.cbxRubric.SelectedIndexChanged += new System.EventHandler(this.cbxRubric_SelectedIndexChanged);
            // 
            // btnConnexion
            // 
            this.btnConnexion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnexion.Image = global::IHMForum.Properties.Resources.Boss;
            this.btnConnexion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnexion.Location = new System.Drawing.Point(652, 5);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(227, 34);
            this.btnConnexion.TabIndex = 1;
            this.btnConnexion.Text = "Se Connecter";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // cbxid
            // 
            this.cbxid.FormattingEnabled = true;
            this.cbxid.Location = new System.Drawing.Point(163, 5);
            this.cbxid.Name = "cbxid";
            this.cbxid.Size = new System.Drawing.Size(85, 21);
            this.cbxid.TabIndex = 5;
            this.cbxid.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(498, 2);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 13);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "label2";
            this.lblID.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.86487F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.13514F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 522F));
            this.tableLayoutPanel3.Controls.Add(this.PUser, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pModerateur, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(120, 377);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.15385F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(884, 69);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // PUser
            // 
            this.PUser.Controls.Add(this.tableLayoutPanel4);
            this.PUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PUser.Location = new System.Drawing.Point(3, 3);
            this.PUser.Name = "PUser";
            this.PUser.Size = new System.Drawing.Size(228, 63);
            this.PUser.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.SlateGray;
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.625F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.375F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel4.Controls.Add(this.btnAjouterTopic, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.86792F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.13207F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(228, 63);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // btnAjouterTopic
            // 
            this.btnAjouterTopic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAjouterTopic.Image = global::IHMForum.Properties.Resources.Add;
            this.btnAjouterTopic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouterTopic.Location = new System.Drawing.Point(15, 14);
            this.btnAjouterTopic.Name = "btnAjouterTopic";
            this.btnAjouterTopic.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnAjouterTopic.Size = new System.Drawing.Size(173, 34);
            this.btnAjouterTopic.TabIndex = 0;
            this.btnAjouterTopic.Text = "Ajouter Topic";
            this.btnAjouterTopic.UseVisualStyleBackColor = true;
            this.btnAjouterTopic.Click += new System.EventHandler(this.btnAjouterTopic_Click);
            // 
            // pModerateur
            // 
            this.pModerateur.Controls.Add(this.tableLayoutPanel5);
            this.pModerateur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pModerateur.Location = new System.Drawing.Point(364, 3);
            this.pModerateur.Name = "pModerateur";
            this.pModerateur.Size = new System.Drawing.Size(517, 63);
            this.pModerateur.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.SlateGray;
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.501945F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.49805F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel5.Controls.Add(this.btnModifTopic, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.btnSuppTopic, 3, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.60784F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.39216F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(517, 63);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // btnModifTopic
            // 
            this.btnModifTopic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModifTopic.Image = global::IHMForum.Properties.Resources.Update;
            this.btnModifTopic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifTopic.Location = new System.Drawing.Point(11, 14);
            this.btnModifTopic.Name = "btnModifTopic";
            this.btnModifTopic.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnModifTopic.Size = new System.Drawing.Size(182, 35);
            this.btnModifTopic.TabIndex = 1;
            this.btnModifTopic.Text = "Modifier Topic";
            this.btnModifTopic.UseVisualStyleBackColor = true;
            this.btnModifTopic.Click += new System.EventHandler(this.btnModifTopic_Click);
            // 
            // btnSuppTopic
            // 
            this.btnSuppTopic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSuppTopic.Image = global::IHMForum.Properties.Resources.Delete;
            this.btnSuppTopic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuppTopic.Location = new System.Drawing.Point(293, 14);
            this.btnSuppTopic.Name = "btnSuppTopic";
            this.btnSuppTopic.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnSuppTopic.Size = new System.Drawing.Size(199, 35);
            this.btnSuppTopic.TabIndex = 0;
            this.btnSuppTopic.Text = "Supprimer Topic";
            this.btnSuppTopic.UseVisualStyleBackColor = true;
            this.btnSuppTopic.Click += new System.EventHandler(this.btnSuppTopic_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(120, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Double-cliquez sur le topic pour afficher les messages correspondants";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.88889F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.11111F));
            this.tableLayoutPanel6.Controls.Add(this.lblDeconnection, 1, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(120, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.23188F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.76812F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(884, 39);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // lblDeconnection
            // 
            this.lblDeconnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeconnection.AutoSize = true;
            this.lblDeconnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDeconnection.LinkColor = System.Drawing.Color.Aqua;
            this.lblDeconnection.Location = new System.Drawing.Point(811, 14);
            this.lblDeconnection.Name = "lblDeconnection";
            this.lblDeconnection.Size = new System.Drawing.Size(70, 25);
            this.lblDeconnection.TabIndex = 5;
            this.lblDeconnection.TabStop = true;
            this.lblDeconnection.Text = "Déconnexion";
            this.lblDeconnection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDeconnection.Visible = false;
            this.lblDeconnection.VisitedLinkColor = System.Drawing.Color.White;
            this.lblDeconnection.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDeconnection_LinkClicked);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.69231F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.30769F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 246F));
            this.tableLayoutPanel7.Controls.Add(this.pAjoutMessage, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.pSuppMessage, 2, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(120, 819);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(884, 69);
            this.tableLayoutPanel7.TabIndex = 6;
            // 
            // pAjoutMessage
            // 
            this.pAjoutMessage.Controls.Add(this.tableLayoutPanel8);
            this.pAjoutMessage.Controls.Add(this.dgvMessages);
            this.pAjoutMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pAjoutMessage.Location = new System.Drawing.Point(3, 3);
            this.pAjoutMessage.Name = "pAjoutMessage";
            this.pAjoutMessage.Size = new System.Drawing.Size(521, 63);
            this.pAjoutMessage.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.BackColor = System.Drawing.Color.SlateGray;
            this.tableLayoutPanel8.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel8.ColumnCount = 5;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.291845F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.70815F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel8.Controls.Add(this.btnAjouterMessage, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.btnModifierMessage, 3, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.61539F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(521, 63);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // btnAjouterMessage
            // 
            this.btnAjouterMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAjouterMessage.Image = global::IHMForum.Properties.Resources.Add;
            this.btnAjouterMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouterMessage.Location = new System.Drawing.Point(14, 12);
            this.btnAjouterMessage.Name = "btnAjouterMessage";
            this.btnAjouterMessage.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnAjouterMessage.Size = new System.Drawing.Size(197, 37);
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
            this.btnModifierMessage.Location = new System.Drawing.Point(304, 12);
            this.btnModifierMessage.Name = "btnModifierMessage";
            this.btnModifierMessage.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnModifierMessage.Size = new System.Drawing.Size(187, 37);
            this.btnModifierMessage.TabIndex = 1;
            this.btnModifierMessage.Text = "   Editer message";
            this.btnModifierMessage.UseVisualStyleBackColor = true;
            this.btnModifierMessage.Click += new System.EventHandler(this.btnModifierMessage_Click);
            // 
            // dgvMessages
            // 
            this.dgvMessages.AllowUserToAddRows = false;
            this.dgvMessages.AllowUserToDeleteRows = false;
            this.dgvMessages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMessages.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMessages.Location = new System.Drawing.Point(0, 0);
            this.dgvMessages.Name = "dgvMessages";
            this.dgvMessages.ReadOnly = true;
            this.dgvMessages.RowHeadersVisible = false;
            this.dgvMessages.RowHeadersWidth = 200;
            this.dgvMessages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMessages.Size = new System.Drawing.Size(521, 63);
            this.dgvMessages.TabIndex = 2;
            // 
            // pSuppMessage
            // 
            this.pSuppMessage.Controls.Add(this.tableLayoutPanel9);
            this.pSuppMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSuppMessage.Location = new System.Drawing.Point(640, 3);
            this.pSuppMessage.Name = "pSuppMessage";
            this.pSuppMessage.Size = new System.Drawing.Size(241, 63);
            this.pSuppMessage.TabIndex = 1;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.BackColor = System.Drawing.Color.SlateGray;
            this.tableLayoutPanel9.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.5F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.5F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel9.Controls.Add(this.btnDeleteResponse, 1, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 3;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.09434F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.90566F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(241, 63);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // btnDeleteResponse
            // 
            this.btnDeleteResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteResponse.Image = global::IHMForum.Properties.Resources.Delete;
            this.btnDeleteResponse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteResponse.Location = new System.Drawing.Point(16, 12);
            this.btnDeleteResponse.Name = "btnDeleteResponse";
            this.btnDeleteResponse.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnDeleteResponse.Size = new System.Drawing.Size(197, 35);
            this.btnDeleteResponse.TabIndex = 0;
            this.btnDeleteResponse.Text = "      Supprimer  message";
            this.btnDeleteResponse.UseVisualStyleBackColor = true;
            this.btnDeleteResponse.Click += new System.EventHandler(this.btnDeleteResponse_Click);
            // 
            // dgvMessage
            // 
            this.dgvMessage.AllowUserToAddRows = false;
            this.dgvMessage.AllowUserToDeleteRows = false;
            this.dgvMessage.AutoGenerateColumns = false;
            this.dgvMessage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idResponseDataGridViewTextBoxColumn,
            this.idTopicDataGridViewTextBoxColumn1,
            this.responseTxtDataGridViewTextBoxColumn,
            this.dateCreationDataGridViewTextBoxColumn1,
            this.authorDataGridViewTextBoxColumn,
            this.idAuthorDataGridViewTextBoxColumn1});
            this.dgvMessage.DataSource = this.responseBindingSource;
            this.dgvMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMessage.Location = new System.Drawing.Point(120, 452);
            this.dgvMessage.Name = "dgvMessage";
            this.dgvMessage.ReadOnly = true;
            this.dgvMessage.RowHeadersVisible = false;
            this.dgvMessage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMessage.Size = new System.Drawing.Size(884, 361);
            this.dgvMessage.TabIndex = 7;
            this.dgvMessage.Click += new System.EventHandler(this.dgvMessage_Click);
            // 
            // topicBindingSource
            // 
            this.topicBindingSource.DataSource = typeof(LibraryForum.Topic);
            // 
            // responseBindingSource
            // 
            this.responseBindingSource.DataSource = typeof(LibraryForum.Response);
            // 
            // idTopicDataGridViewTextBoxColumn
            // 
            this.idTopicDataGridViewTextBoxColumn.DataPropertyName = "IdTopic";
            this.idTopicDataGridViewTextBoxColumn.HeaderText = "IdTopic";
            this.idTopicDataGridViewTextBoxColumn.Name = "idTopicDataGridViewTextBoxColumn";
            this.idTopicDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTopicDataGridViewTextBoxColumn.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.FillWeight = 138.0592F;
            this.titleDataGridViewTextBoxColumn.HeaderText = "Topic";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.FillWeight = 138.0592F;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateCreationDataGridViewTextBoxColumn
            // 
            this.dateCreationDataGridViewTextBoxColumn.DataPropertyName = "DateCreation";
            this.dateCreationDataGridViewTextBoxColumn.FillWeight = 62.96793F;
            this.dateCreationDataGridViewTextBoxColumn.HeaderText = "Date de création";
            this.dateCreationDataGridViewTextBoxColumn.Name = "dateCreationDataGridViewTextBoxColumn";
            this.dateCreationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // auteurDataGridViewTextBoxColumn
            // 
            this.auteurDataGridViewTextBoxColumn.DataPropertyName = "Auteur";
            this.auteurDataGridViewTextBoxColumn.FillWeight = 60.9137F;
            this.auteurDataGridViewTextBoxColumn.HeaderText = "Auteur";
            this.auteurDataGridViewTextBoxColumn.Name = "auteurDataGridViewTextBoxColumn";
            this.auteurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idRubricDataGridViewTextBoxColumn
            // 
            this.idRubricDataGridViewTextBoxColumn.DataPropertyName = "IdRubric";
            this.idRubricDataGridViewTextBoxColumn.HeaderText = "IdRubric";
            this.idRubricDataGridViewTextBoxColumn.Name = "idRubricDataGridViewTextBoxColumn";
            this.idRubricDataGridViewTextBoxColumn.ReadOnly = true;
            this.idRubricDataGridViewTextBoxColumn.Visible = false;
            // 
            // idAuthorDataGridViewTextBoxColumn
            // 
            this.idAuthorDataGridViewTextBoxColumn.DataPropertyName = "IdAuthor";
            this.idAuthorDataGridViewTextBoxColumn.HeaderText = "IdAuthor";
            this.idAuthorDataGridViewTextBoxColumn.Name = "idAuthorDataGridViewTextBoxColumn";
            this.idAuthorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAuthorDataGridViewTextBoxColumn.Visible = false;
            // 
            // idResponseDataGridViewTextBoxColumn
            // 
            this.idResponseDataGridViewTextBoxColumn.DataPropertyName = "IdResponse";
            this.idResponseDataGridViewTextBoxColumn.HeaderText = "IdResponse";
            this.idResponseDataGridViewTextBoxColumn.Name = "idResponseDataGridViewTextBoxColumn";
            this.idResponseDataGridViewTextBoxColumn.ReadOnly = true;
            this.idResponseDataGridViewTextBoxColumn.Visible = false;
            // 
            // idTopicDataGridViewTextBoxColumn1
            // 
            this.idTopicDataGridViewTextBoxColumn1.DataPropertyName = "IdTopic";
            this.idTopicDataGridViewTextBoxColumn1.HeaderText = "IdTopic";
            this.idTopicDataGridViewTextBoxColumn1.Name = "idTopicDataGridViewTextBoxColumn1";
            this.idTopicDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idTopicDataGridViewTextBoxColumn1.Visible = false;
            // 
            // responseTxtDataGridViewTextBoxColumn
            // 
            this.responseTxtDataGridViewTextBoxColumn.DataPropertyName = "ResponseTxt";
            this.responseTxtDataGridViewTextBoxColumn.FillWeight = 211.1671F;
            this.responseTxtDataGridViewTextBoxColumn.HeaderText = "Message";
            this.responseTxtDataGridViewTextBoxColumn.Name = "responseTxtDataGridViewTextBoxColumn";
            this.responseTxtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateCreationDataGridViewTextBoxColumn1
            // 
            this.dateCreationDataGridViewTextBoxColumn1.DataPropertyName = "DateCreation";
            this.dateCreationDataGridViewTextBoxColumn1.FillWeight = 43.1476F;
            this.dateCreationDataGridViewTextBoxColumn1.HeaderText = "Date de poste";
            this.dateCreationDataGridViewTextBoxColumn1.Name = "dateCreationDataGridViewTextBoxColumn1";
            this.dateCreationDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.FillWeight = 45.68528F;
            this.authorDataGridViewTextBoxColumn.HeaderText = "Auteur";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idAuthorDataGridViewTextBoxColumn1
            // 
            this.idAuthorDataGridViewTextBoxColumn1.DataPropertyName = "IdAuthor";
            this.idAuthorDataGridViewTextBoxColumn1.HeaderText = "IdAuthor";
            this.idAuthorDataGridViewTextBoxColumn1.Name = "idAuthorDataGridViewTextBoxColumn1";
            this.idAuthorDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idAuthorDataGridViewTextBoxColumn1.Visible = false;
            // 
            // FenAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 900);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FenAccueil";
            this.Text = "Accueil RTFF";
            this.Load += new System.EventHandler(this.FenAccueil_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopics)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.PUser.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.pModerateur.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.pAjoutMessage.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).EndInit();
            this.pSuppMessage.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRubric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTopics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvTopics;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cbxRubric;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel PUser;
        private System.Windows.Forms.Panel pModerateur;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnAjouterTopic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnSuppTopic;
        private System.Windows.Forms.BindingSource bindingSourceRubric;
        private System.Windows.Forms.BindingSource bindingSourceTopics;
        private System.Windows.Forms.Button btnModifTopic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        internal System.Windows.Forms.Label lblUser;
        internal System.Windows.Forms.LinkLabel lblDeconnection;
        internal System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.ComboBox cbxid;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Panel pAjoutMessage;
        private System.Windows.Forms.Panel pSuppMessage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button btnAjouterMessage;
        private System.Windows.Forms.Button btnModifierMessage;
        internal System.Windows.Forms.DataGridView dgvMessages;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Button btnDeleteResponse;
        private System.Windows.Forms.DataGridView dgvMessage;
        private System.Windows.Forms.BindingSource bindingSourceMessage;
        private System.Windows.Forms.BindingSource topicBindingSource;
        private System.Windows.Forms.BindingSource responseBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTopicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRubricDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAuthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idResponseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTopicDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn responseTxtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAuthorDataGridViewTextBoxColumn1;
    }
}

