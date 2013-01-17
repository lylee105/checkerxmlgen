namespace CheckerXmlGenerator
{
    partial class ViewForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lineNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.context = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refTreeView = new System.Windows.Forms.TreeView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.levelViewBox = new System.Windows.Forms.TextBox();
            this.checkerViewBox = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generateBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lineNum,
            this.context});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(14, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(716, 204);
            this.dataGridView1.TabIndex = 54;
            // 
            // lineNum
            // 
            this.lineNum.FillWeight = 10F;
            this.lineNum.HeaderText = "번호";
            this.lineNum.Name = "lineNum";
            this.lineNum.ReadOnly = true;
            // 
            // context
            // 
            this.context.HeaderText = "내용";
            this.context.Name = "context";
            this.context.ReadOnly = true;
            // 
            // refTreeView
            // 
            this.refTreeView.Location = new System.Drawing.Point(12, 99);
            this.refTreeView.Name = "refTreeView";
            this.refTreeView.Size = new System.Drawing.Size(282, 97);
            this.refTreeView.TabIndex = 53;
            
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 52;
            this.label8.Text = "해결방법";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 51;
            this.label9.Text = "예시";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(261, 60);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(33, 28);
            this.button10.TabIndex = 50;
            this.button10.Text = "-";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(261, 19);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(33, 28);
            this.button9.TabIndex = 49;
            this.button9.Text = "-";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // levelViewBox
            // 
            this.levelViewBox.Location = new System.Drawing.Point(12, 67);
            this.levelViewBox.Name = "levelViewBox";
            this.levelViewBox.Size = new System.Drawing.Size(243, 21);
            this.levelViewBox.TabIndex = 48;
            // 
            // checkerViewBox
            // 
            this.checkerViewBox.Location = new System.Drawing.Point(12, 24);
            this.checkerViewBox.Name = "checkerViewBox";
            this.checkerViewBox.Size = new System.Drawing.Size(243, 21);
            this.checkerViewBox.TabIndex = 47;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(15, 456);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(715, 204);
            this.dataGridView2.TabIndex = 55;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 10F;
            this.dataGridViewTextBoxColumn1.HeaderText = "번호";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "내용";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // generateBut
            // 
            this.generateBut.Location = new System.Drawing.Point(555, 678);
            this.generateBut.Name = "generateBut";
            this.generateBut.Size = new System.Drawing.Size(75, 23);
            this.generateBut.TabIndex = 56;
            this.generateBut.Text = "생성";
            this.generateBut.UseVisualStyleBackColor = true;
            this.generateBut.Click += new System.EventHandler(this.generateBut_Click);
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 730);
            this.Controls.Add(this.generateBut);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.refTreeView);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.levelViewBox);
            this.Controls.Add(this.checkerViewBox);
            this.Name = "ViewForm";
            this.Text = "View";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TreeView refTreeView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox levelViewBox;
        private System.Windows.Forms.TextBox checkerViewBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn context;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button generateBut;
    }
}