namespace CelebAppClient
{
    partial class FrmCelebrities
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCeleberities = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnDeleteOne = new System.Windows.Forms.Button();
            this.btnLoadFromLocal = new System.Windows.Forms.Button();
            this.dgvCelebretiesColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCelebretiesColCelebrityItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCelebretiesColBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCelebretiesColGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCelebretiesColRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCelebretiesColImage = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCeleberities)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCeleberities
            // 
            this.dgvCeleberities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCeleberities.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCeleberities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCeleberities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCelebretiesColName,
            this.dgvCelebretiesColCelebrityItem,
            this.dgvCelebretiesColBirthDate,
            this.dgvCelebretiesColGender,
            this.dgvCelebretiesColRole,
            this.dgvCelebretiesColImage});
            this.dgvCeleberities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCeleberities.EnableHeadersVisualStyles = false;
            this.dgvCeleberities.Location = new System.Drawing.Point(0, 0);
            this.dgvCeleberities.MultiSelect = false;
            this.dgvCeleberities.Name = "dgvCeleberities";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCeleberities.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCeleberities.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCeleberities.RowTemplate.Height = 200;
            this.dgvCeleberities.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCeleberities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCeleberities.Size = new System.Drawing.Size(936, 496);
            this.dgvCeleberities.TabIndex = 0;
            this.dgvCeleberities.SelectionChanged += new System.EventHandler(this.dgvCeleberities_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLoadFromLocal);
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.btnDeleteOne);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 96);
            this.panel1.TabIndex = 1;
            // 
            // btnReload
            // 
            this.btnReload.Enabled = false;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnReload.Location = new System.Drawing.Point(630, 26);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(277, 40);
            this.btnReload.TabIndex = 2;
            this.btnReload.Text = "Reload All From Web";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnDeleteOne
            // 
            this.btnDeleteOne.Enabled = false;
            this.btnDeleteOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeleteOne.Location = new System.Drawing.Point(26, 26);
            this.btnDeleteOne.Name = "btnDeleteOne";
            this.btnDeleteOne.Size = new System.Drawing.Size(277, 40);
            this.btnDeleteOne.TabIndex = 0;
            this.btnDeleteOne.Text = "Delete Selected";
            this.btnDeleteOne.UseVisualStyleBackColor = true;
            this.btnDeleteOne.Click += new System.EventHandler(this.btnDeleteOne_ClickAsync);
            // 
            // btnLoadFromLocal
            // 
            this.btnLoadFromLocal.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadFromLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLoadFromLocal.Location = new System.Drawing.Point(328, 26);
            this.btnLoadFromLocal.Name = "btnLoadFromLocal";
            this.btnLoadFromLocal.Size = new System.Drawing.Size(277, 40);
            this.btnLoadFromLocal.TabIndex = 3;
            this.btnLoadFromLocal.Text = "Restart Original";
            this.btnLoadFromLocal.UseVisualStyleBackColor = false;
            this.btnLoadFromLocal.Click += new System.EventHandler(this.btnLoadFromLocal_Click);
            // 
            // dgvCelebretiesColName
            // 
            this.dgvCelebretiesColName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCelebretiesColName.HeaderText = "Name";
            this.dgvCelebretiesColName.Name = "dgvCelebretiesColName";
            // 
            // dgvCelebretiesColCelebrityItem
            // 
            this.dgvCelebretiesColCelebrityItem.HeaderText = "CelebrityItem";
            this.dgvCelebretiesColCelebrityItem.Name = "dgvCelebretiesColCelebrityItem";
            this.dgvCelebretiesColCelebrityItem.Visible = false;
            this.dgvCelebretiesColCelebrityItem.Width = 138;
            // 
            // dgvCelebretiesColBirthDate
            // 
            this.dgvCelebretiesColBirthDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCelebretiesColBirthDate.HeaderText = "Date of birth";
            this.dgvCelebretiesColBirthDate.Name = "dgvCelebretiesColBirthDate";
            // 
            // dgvCelebretiesColGender
            // 
            this.dgvCelebretiesColGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCelebretiesColGender.HeaderText = "Gender";
            this.dgvCelebretiesColGender.Name = "dgvCelebretiesColGender";
            // 
            // dgvCelebretiesColRole
            // 
            this.dgvCelebretiesColRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCelebretiesColRole.HeaderText = "Role";
            this.dgvCelebretiesColRole.Name = "dgvCelebretiesColRole";
            // 
            // dgvCelebretiesColImage
            // 
            this.dgvCelebretiesColImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCelebretiesColImage.HeaderText = "Image";
            this.dgvCelebretiesColImage.Name = "dgvCelebretiesColImage";
            // 
            // FrmCelebrities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 496);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCeleberities);
            this.Name = "FrmCelebrities";
            this.ShowIcon = false;
            this.Text = "Celebrities";
            this.Load += new System.EventHandler(this.FrmCelebrities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCeleberities)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCeleberities;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteOne;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnLoadFromLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCelebretiesColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCelebretiesColCelebrityItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCelebretiesColBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCelebretiesColGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCelebretiesColRole;
        private System.Windows.Forms.DataGridViewImageColumn dgvCelebretiesColImage;
    }
}

