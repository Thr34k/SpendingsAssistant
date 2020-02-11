namespace Spendings_assistant
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.accountNameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.curBalanceLabel = new System.Windows.Forms.Label();
            this.curbalanceNum = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.changebtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.newPurchaseName = new System.Windows.Forms.Label();
            this.newPurchasePrice = new System.Windows.Forms.Label();
            this.newChangePriceNum = new System.Windows.Forms.NumericUpDown();
            this.newChangeNametxt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.balanceOverview = new LiveCharts.WinForms.CartesianChart();
            this.historyView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.curbalanceNum)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newChangePriceNum)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.historyView);
            this.splitContainer1.Size = new System.Drawing.Size(800, 400);
            this.splitContainer1.SplitterDistance = 451;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(447, 396);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.accountNameLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(217, 192);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // accountNameLabel
            // 
            this.accountNameLabel.AutoSize = true;
            this.accountNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.accountNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountNameLabel.Location = new System.Drawing.Point(3, 0);
            this.accountNameLabel.Name = "accountNameLabel";
            this.accountNameLabel.Size = new System.Drawing.Size(211, 38);
            this.accountNameLabel.TabIndex = 0;
            this.accountNameLabel.Text = "label1";
            this.accountNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.Controls.Add(this.curBalanceLabel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.curbalanceNum, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 41);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(211, 148);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // curBalanceLabel
            // 
            this.curBalanceLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.curBalanceLabel.AutoSize = true;
            this.curBalanceLabel.Location = new System.Drawing.Point(3, 67);
            this.curBalanceLabel.Name = "curBalanceLabel";
            this.curBalanceLabel.Size = new System.Drawing.Size(111, 13);
            this.curBalanceLabel.TabIndex = 0;
            this.curBalanceLabel.Text = "Current balance in kr.:";
            // 
            // curbalanceNum
            // 
            this.curbalanceNum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.curbalanceNum.Location = new System.Drawing.Point(129, 64);
            this.curbalanceNum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.curbalanceNum.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.curbalanceNum.Name = "curbalanceNum";
            this.curbalanceNum.ReadOnly = true;
            this.curbalanceNum.Size = new System.Drawing.Size(79, 20);
            this.curbalanceNum.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.changebtn, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(226, 201);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(218, 192);
            this.tableLayoutPanel3.TabIndex = 1;
            this.tableLayoutPanel3.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // changebtn
            // 
            this.changebtn.AccessibleName = "";
            this.changebtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changebtn.Location = new System.Drawing.Point(3, 3);
            this.changebtn.Name = "changebtn";
            this.changebtn.Size = new System.Drawing.Size(212, 109);
            this.changebtn.TabIndex = 1;
            this.changebtn.Text = "Change Balance";
            this.changebtn.UseVisualStyleBackColor = true;
            this.changebtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.newPurchaseName, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.newPurchasePrice, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.newChangePriceNum, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.newChangeNametxt, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 118);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(212, 71);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // newPurchaseName
            // 
            this.newPurchaseName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newPurchaseName.AutoSize = true;
            this.newPurchaseName.Location = new System.Drawing.Point(35, 4);
            this.newPurchaseName.Name = "newPurchaseName";
            this.newPurchaseName.Size = new System.Drawing.Size(35, 13);
            this.newPurchaseName.TabIndex = 0;
            this.newPurchaseName.Text = "Name";
            // 
            // newPurchasePrice
            // 
            this.newPurchasePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newPurchasePrice.AutoSize = true;
            this.newPurchasePrice.Location = new System.Drawing.Point(143, 4);
            this.newPurchasePrice.Name = "newPurchasePrice";
            this.newPurchasePrice.Size = new System.Drawing.Size(31, 13);
            this.newPurchasePrice.TabIndex = 1;
            this.newPurchasePrice.Text = "Price";
            // 
            // newChangePriceNum
            // 
            this.newChangePriceNum.Location = new System.Drawing.Point(109, 24);
            this.newChangePriceNum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.newChangePriceNum.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.newChangePriceNum.Name = "newChangePriceNum";
            this.newChangePriceNum.Size = new System.Drawing.Size(100, 20);
            this.newChangePriceNum.TabIndex = 2;
            this.newChangePriceNum.ThousandsSeparator = true;
            // 
            // newChangeNametxt
            // 
            this.newChangeNametxt.Location = new System.Drawing.Point(3, 24);
            this.newChangeNametxt.Name = "newChangeNametxt";
            this.newChangeNametxt.Size = new System.Drawing.Size(100, 20);
            this.newChangeNametxt.TabIndex = 3;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.balanceOverview, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 201);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(217, 192);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // balanceOverview
            // 
            this.balanceOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.balanceOverview.Location = new System.Drawing.Point(3, 3);
            this.balanceOverview.Name = "balanceOverview";
            this.balanceOverview.Size = new System.Drawing.Size(211, 186);
            this.balanceOverview.TabIndex = 0;
            this.balanceOverview.Text = "cartesianChart1";
            // 
            // historyView
            // 
            this.historyView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.historyView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyView.HideSelection = false;
            this.historyView.Location = new System.Drawing.Point(0, 0);
            this.historyView.Name = "historyView";
            this.historyView.Size = new System.Drawing.Size(341, 396);
            this.historyView.TabIndex = 0;
            this.historyView.UseCompatibleStateImageBehavior = false;
            this.historyView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "History";
            this.columnHeader1.Width = 335;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 400);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.curbalanceNum)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newChangePriceNum)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView historyView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label accountNameLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button changebtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label newPurchaseName;
        private System.Windows.Forms.Label newPurchasePrice;
        private System.Windows.Forms.NumericUpDown newChangePriceNum;
        private System.Windows.Forms.TextBox newChangeNametxt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label curBalanceLabel;
        private System.Windows.Forms.NumericUpDown curbalanceNum;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private LiveCharts.WinForms.CartesianChart balanceOverview;
    }
}
