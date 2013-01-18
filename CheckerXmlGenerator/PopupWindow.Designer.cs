namespace CheckerXmlGenerator
{
    partial class PopupWindow
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
            this.refreshBut = new System.Windows.Forms.Button();
            this.AddBut = new System.Windows.Forms.Button();
            this.refKind = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.refName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refKindtextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // refreshBut
            // 
            this.refreshBut.Location = new System.Drawing.Point(363, 264);
            this.refreshBut.Name = "refreshBut";
            this.refreshBut.Size = new System.Drawing.Size(75, 33);
            this.refreshBut.TabIndex = 36;
            this.refreshBut.Text = "Refresh";
            this.refreshBut.UseVisualStyleBackColor = true;
            // 
            // AddBut
            // 
            this.AddBut.Location = new System.Drawing.Point(270, 264);
            this.AddBut.Name = "AddBut";
            this.AddBut.Size = new System.Drawing.Size(75, 33);
            this.AddBut.TabIndex = 35;
            this.AddBut.Text = "Add";
            this.AddBut.UseVisualStyleBackColor = true;
            this.AddBut.Click += new System.EventHandler(this.AddBut_Click);
            // 
            // refKind
            // 
            this.refKind.AutoSize = true;
            this.refKind.Location = new System.Drawing.Point(27, 44);
            this.refKind.Name = "refKind";
            this.refKind.Size = new System.Drawing.Size(90, 12);
            this.refKind.TabIndex = 37;
            this.refKind.Text = "Reference 종류";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.refName,
            this.refLink});
            this.dataGridView.Location = new System.Drawing.Point(29, 101);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(409, 150);
            this.dataGridView.TabIndex = 38;
            // 
            // refName
            // 
            this.refName.HeaderText = "Ref 이름";
            this.refName.Name = "refName";
            // 
            // refLink
            // 
            this.refLink.HeaderText = "Ref 링크";
            this.refLink.Name = "refLink";
            // 
            // refKindtextBox
            // 
            this.refKindtextBox.Location = new System.Drawing.Point(29, 60);
            this.refKindtextBox.Name = "refKindtextBox";
            this.refKindtextBox.Size = new System.Drawing.Size(222, 21);
            this.refKindtextBox.TabIndex = 39;
            // 
            // PopupWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(450, 321);
            this.Controls.Add(this.refKindtextBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.refKind);
            this.Controls.Add(this.refreshBut);
            this.Controls.Add(this.AddBut);
            this.Name = "PopupWindow";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refreshBut;
        private System.Windows.Forms.Button AddBut;
        private System.Windows.Forms.Label refKind;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn refName;
        private System.Windows.Forms.DataGridViewTextBoxColumn refLink;
        private System.Windows.Forms.TextBox refKindtextBox;
    }
}