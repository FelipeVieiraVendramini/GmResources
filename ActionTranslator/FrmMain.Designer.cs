namespace ActionTranslator
{
    partial class FrmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pbProgressAction = new System.Windows.Forms.ProgressBar();
            this.btnTranslateAction = new System.Windows.Forms.Button();
            this.btnGetActions = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvOriginal = new System.Windows.Forms.DataGridView();
            this.idAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionParam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNew = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTranslateTypes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEstimatedTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numMs = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMs)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(903, 589);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pbProgressAction);
            this.tabPage1.Controls.Add(this.btnTranslateAction);
            this.tabPage1.Controls.Add(this.btnGetActions);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.txtTranslateTypes);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lblEstimatedTime);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.numMs);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(895, 563);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Actions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pbProgressAction
            // 
            this.pbProgressAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProgressAction.Location = new System.Drawing.Point(9, 531);
            this.pbProgressAction.Name = "pbProgressAction";
            this.pbProgressAction.Size = new System.Drawing.Size(710, 23);
            this.pbProgressAction.TabIndex = 8;
            // 
            // btnTranslateAction
            // 
            this.btnTranslateAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTranslateAction.Location = new System.Drawing.Point(725, 531);
            this.btnTranslateAction.Name = "btnTranslateAction";
            this.btnTranslateAction.Size = new System.Drawing.Size(75, 23);
            this.btnTranslateAction.TabIndex = 7;
            this.btnTranslateAction.Text = "&Translate";
            this.btnTranslateAction.UseVisualStyleBackColor = true;
            this.btnTranslateAction.Click += new System.EventHandler(this.btnTranslateAction_Click);
            // 
            // btnGetActions
            // 
            this.btnGetActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetActions.Location = new System.Drawing.Point(806, 531);
            this.btnGetActions.Name = "btnGetActions";
            this.btnGetActions.Size = new System.Drawing.Size(75, 23);
            this.btnGetActions.TabIndex = 6;
            this.btnGetActions.Text = "&Fetch";
            this.btnGetActions.UseVisualStyleBackColor = true;
            this.btnGetActions.Click += new System.EventHandler(this.btnGetActions_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(9, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 487);
            this.panel1.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvOriginal);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvNew);
            this.splitContainer1.Size = new System.Drawing.Size(872, 487);
            this.splitContainer1.SplitterDistance = 448;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvOriginal
            // 
            this.dgvOriginal.AllowUserToAddRows = false;
            this.dgvOriginal.AllowUserToDeleteRows = false;
            this.dgvOriginal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOriginal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAction,
            this.idNext,
            this.idFail,
            this.actionType,
            this.actionData,
            this.actionParam});
            this.dgvOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOriginal.Location = new System.Drawing.Point(0, 0);
            this.dgvOriginal.Name = "dgvOriginal";
            this.dgvOriginal.ReadOnly = true;
            this.dgvOriginal.Size = new System.Drawing.Size(448, 487);
            this.dgvOriginal.TabIndex = 0;
            // 
            // idAction
            // 
            this.idAction.Frozen = true;
            this.idAction.HeaderText = "Id";
            this.idAction.MaxInputLength = 16;
            this.idAction.Name = "idAction";
            this.idAction.ReadOnly = true;
            this.idAction.Width = 50;
            // 
            // idNext
            // 
            this.idNext.HeaderText = "IdNext";
            this.idNext.MaxInputLength = 16;
            this.idNext.Name = "idNext";
            this.idNext.ReadOnly = true;
            this.idNext.Width = 50;
            // 
            // idFail
            // 
            this.idFail.HeaderText = "IdNextFail";
            this.idFail.MaxInputLength = 16;
            this.idFail.Name = "idFail";
            this.idFail.ReadOnly = true;
            this.idFail.Width = 50;
            // 
            // actionType
            // 
            this.actionType.HeaderText = "Type";
            this.actionType.MaxInputLength = 16;
            this.actionType.Name = "actionType";
            this.actionType.ReadOnly = true;
            this.actionType.Width = 50;
            // 
            // actionData
            // 
            this.actionData.HeaderText = "Data";
            this.actionData.MaxInputLength = 16;
            this.actionData.Name = "actionData";
            this.actionData.ReadOnly = true;
            this.actionData.Width = 50;
            // 
            // actionParam
            // 
            this.actionParam.HeaderText = "Param";
            this.actionParam.MaxInputLength = 128;
            this.actionParam.Name = "actionParam";
            this.actionParam.ReadOnly = true;
            this.actionParam.Width = 500;
            // 
            // dgvNew
            // 
            this.dgvNew.AllowUserToAddRows = false;
            this.dgvNew.AllowUserToDeleteRows = false;
            this.dgvNew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNew.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNew.Location = new System.Drawing.Point(0, 0);
            this.dgvNew.Name = "dgvNew";
            this.dgvNew.ReadOnly = true;
            this.dgvNew.Size = new System.Drawing.Size(420, 487);
            this.dgvNew.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 16;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "IdNext";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 16;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "IdNextFail";
            this.dataGridViewTextBoxColumn3.MaxInputLength = 16;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Type";
            this.dataGridViewTextBoxColumn4.MaxInputLength = 16;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Data";
            this.dataGridViewTextBoxColumn5.MaxInputLength = 16;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Param";
            this.dataGridViewTextBoxColumn6.MaxInputLength = 128;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 500;
            // 
            // txtTranslateTypes
            // 
            this.txtTranslateTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTranslateTypes.Location = new System.Drawing.Point(565, 6);
            this.txtTranslateTypes.Name = "txtTranslateTypes";
            this.txtTranslateTypes.Size = new System.Drawing.Size(316, 20);
            this.txtTranslateTypes.TabIndex = 4;
            this.txtTranslateTypes.Text = "101;102;125;1010";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Need translation types";
            // 
            // lblEstimatedTime
            // 
            this.lblEstimatedTime.AutoSize = true;
            this.lblEstimatedTime.Location = new System.Drawing.Point(231, 9);
            this.lblEstimatedTime.Name = "lblEstimatedTime";
            this.lblEstimatedTime.Size = new System.Drawing.Size(192, 13);
            this.lblEstimatedTime.TabIndex = 2;
            this.lblEstimatedTime.Text = "ms. Total translation will last 0 seconds.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Translation interval";
            // 
            // numMs
            // 
            this.numMs.Location = new System.Drawing.Point(105, 6);
            this.numMs.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numMs.Name = "numMs";
            this.numMs.Size = new System.Drawing.Size(120, 20);
            this.numMs.TabIndex = 0;
            this.numMs.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(895, 563);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "NPCs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(895, 563);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Maps";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 613);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmMain";
            this.Text = "Database Translator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblEstimatedTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numMs;
        private System.Windows.Forms.TextBox txtTranslateTypes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvOriginal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNext;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFail;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionData;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionParam;
        private System.Windows.Forms.DataGridView dgvNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btnGetActions;
        private System.Windows.Forms.Button btnTranslateAction;
        private System.Windows.Forms.ProgressBar pbProgressAction;
    }
}

