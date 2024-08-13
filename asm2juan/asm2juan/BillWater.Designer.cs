namespace asm2juan
{
    partial class BillWater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillWater));
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblLastMonthReading = new System.Windows.Forms.Label();
            this.lblThisMonthReading = new System.Windows.Forms.Label();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.lblNumberOfPeople = new System.Windows.Forms.Label();
            this.tbxCustomerName = new System.Windows.Forms.TextBox();
            this.tbxLastMonthReading = new System.Windows.Forms.TextBox();
            this.tbxThisMonthReading = new System.Windows.Forms.TextBox();
            this.cbxCustomerType = new System.Windows.Forms.ComboBox();
            this.nudNumberOfPeople = new System.Windows.Forms.NumericUpDown();
            this.BtnCaculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.tbxResult = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lsv = new System.Windows.Forms.ListView();
            this.colCustomerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastMonthReading = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colThisMonthReading = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colConsumption = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNumberOfPeople = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotalBill = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnFace = new System.Windows.Forms.Button();
            this.tbxFind = new System.Windows.Forms.TextBox();
            this.BtnFind = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(331, 34);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(154, 25);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name";
            this.lblCustomerName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLastMonthReading
            // 
            this.lblLastMonthReading.AutoSize = true;
            this.lblLastMonthReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastMonthReading.Location = new System.Drawing.Point(331, 84);
            this.lblLastMonthReading.Name = "lblLastMonthReading";
            this.lblLastMonthReading.Size = new System.Drawing.Size(200, 25);
            this.lblLastMonthReading.TabIndex = 0;
            this.lblLastMonthReading.Text = "Last Month\'s Reading";
            // 
            // lblThisMonthReading
            // 
            this.lblThisMonthReading.AutoSize = true;
            this.lblThisMonthReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThisMonthReading.Location = new System.Drawing.Point(330, 134);
            this.lblThisMonthReading.Name = "lblThisMonthReading";
            this.lblThisMonthReading.Size = new System.Drawing.Size(201, 25);
            this.lblThisMonthReading.TabIndex = 0;
            this.lblThisMonthReading.Text = "This Month\'s Reading";
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.AutoSize = true;
            this.lblCustomerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerType.Location = new System.Drawing.Point(331, 186);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(147, 25);
            this.lblCustomerType.TabIndex = 0;
            this.lblCustomerType.Text = "Customer Type";
            // 
            // lblNumberOfPeople
            // 
            this.lblNumberOfPeople.AutoSize = true;
            this.lblNumberOfPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfPeople.Location = new System.Drawing.Point(331, 235);
            this.lblNumberOfPeople.Name = "lblNumberOfPeople";
            this.lblNumberOfPeople.Size = new System.Drawing.Size(173, 25);
            this.lblNumberOfPeople.TabIndex = 0;
            this.lblNumberOfPeople.Text = "Number Of People";
            // 
            // tbxCustomerName
            // 
            this.tbxCustomerName.Location = new System.Drawing.Point(581, 26);
            this.tbxCustomerName.Multiline = true;
            this.tbxCustomerName.Name = "tbxCustomerName";
            this.tbxCustomerName.Size = new System.Drawing.Size(208, 33);
            this.tbxCustomerName.TabIndex = 1;
            // 
            // tbxLastMonthReading
            // 
            this.tbxLastMonthReading.Location = new System.Drawing.Point(581, 77);
            this.tbxLastMonthReading.Multiline = true;
            this.tbxLastMonthReading.Name = "tbxLastMonthReading";
            this.tbxLastMonthReading.Size = new System.Drawing.Size(208, 32);
            this.tbxLastMonthReading.TabIndex = 1;
            // 
            // tbxThisMonthReading
            // 
            this.tbxThisMonthReading.Location = new System.Drawing.Point(581, 134);
            this.tbxThisMonthReading.Multiline = true;
            this.tbxThisMonthReading.Name = "tbxThisMonthReading";
            this.tbxThisMonthReading.Size = new System.Drawing.Size(208, 34);
            this.tbxThisMonthReading.TabIndex = 1;
            // 
            // cbxCustomerType
            // 
            this.cbxCustomerType.FormattingEnabled = true;
            this.cbxCustomerType.Location = new System.Drawing.Point(581, 186);
            this.cbxCustomerType.Name = "cbxCustomerType";
            this.cbxCustomerType.Size = new System.Drawing.Size(208, 24);
            this.cbxCustomerType.TabIndex = 2;
            // 
            // nudNumberOfPeople
            // 
            this.nudNumberOfPeople.Location = new System.Drawing.Point(581, 240);
            this.nudNumberOfPeople.Name = "nudNumberOfPeople";
            this.nudNumberOfPeople.Size = new System.Drawing.Size(208, 22);
            this.nudNumberOfPeople.TabIndex = 3;
            // 
            // BtnCaculate
            // 
            this.BtnCaculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCaculate.Location = new System.Drawing.Point(519, 283);
            this.BtnCaculate.Name = "BtnCaculate";
            this.BtnCaculate.Size = new System.Drawing.Size(163, 51);
            this.BtnCaculate.TabIndex = 4;
            this.BtnCaculate.Text = "Caculate";
            this.BtnCaculate.UseVisualStyleBackColor = true;
            this.BtnCaculate.Click += new System.EventHandler(this.BtnCaculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(51, 329);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(66, 25);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Result";
            this.lblResult.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbxResult
            // 
            this.tbxResult.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbxResult.Location = new System.Drawing.Point(56, 357);
            this.tbxResult.Multiline = true;
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.Size = new System.Drawing.Size(1271, 127);
            this.tbxResult.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(581, 490);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 51);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(714, 490);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 51);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Detele";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lsv
            // 
            this.lsv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCustomerName,
            this.colLastMonthReading,
            this.colThisMonthReading,
            this.colConsumption,
            this.colNumberOfPeople,
            this.colTotalBill});
            this.lsv.HideSelection = false;
            this.lsv.Location = new System.Drawing.Point(56, 547);
            this.lsv.Name = "lsv";
            this.lsv.Size = new System.Drawing.Size(927, 150);
            this.lsv.TabIndex = 6;
            this.lsv.UseCompatibleStateImageBehavior = false;
            this.lsv.View = System.Windows.Forms.View.Details;
            this.lsv.SelectedIndexChanged += new System.EventHandler(this.lsv_SelectedIndexChanged_1);
            // 
            // colCustomerName
            // 
            this.colCustomerName.Text = "Customer Name";
            // 
            // colLastMonthReading
            // 
            this.colLastMonthReading.Text = "Last Month\'s Reading";
            // 
            // colThisMonthReading
            // 
            this.colThisMonthReading.Text = "This Month\'s Reading";
            // 
            // colConsumption
            // 
            this.colConsumption.Text = "Consumption";
            // 
            // colNumberOfPeople
            // 
            this.colNumberOfPeople.Text = "Number Of People";
            // 
            // colTotalBill
            // 
            this.colTotalBill.Text = "Total Bill";
            // 
            // BtnFace
            // 
            this.BtnFace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnFace.BackgroundImage")));
            this.BtnFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnFace.Location = new System.Drawing.Point(56, 27);
            this.BtnFace.Name = "BtnFace";
            this.BtnFace.Size = new System.Drawing.Size(240, 225);
            this.BtnFace.TabIndex = 7;
            this.BtnFace.UseVisualStyleBackColor = true;
            // 
            // tbxFind
            // 
            this.tbxFind.Location = new System.Drawing.Point(874, 51);
            this.tbxFind.Multiline = true;
            this.tbxFind.Name = "tbxFind";
            this.tbxFind.Size = new System.Drawing.Size(271, 36);
            this.tbxFind.TabIndex = 9;
            this.tbxFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxFind.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BtnFind
            // 
            this.BtnFind.Location = new System.Drawing.Point(960, 108);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(97, 51);
            this.BtnFind.TabIndex = 10;
            this.BtnFind.Text = "Find";
            this.BtnFind.UseVisualStyleBackColor = true;
            this.BtnFind.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(829, 488);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(88, 53);
            this.BtnExit.TabIndex = 11;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnSort
            // 
            this.BtnSort.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSort.Location = new System.Drawing.Point(960, 186);
            this.BtnSort.Name = "BtnSort";
            this.BtnSort.Size = new System.Drawing.Size(97, 38);
            this.BtnSort.TabIndex = 0;
            this.BtnSort.Text = "Sort";
            this.BtnSort.UseVisualStyleBackColor = false;
            this.BtnSort.Click += new System.EventHandler(this.BtnSort_Click_1);
            // 
            // BillWater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1157, 709);
            this.Controls.Add(this.BtnSort);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnFind);
            this.Controls.Add(this.tbxFind);
            this.Controls.Add(this.BtnFace);
            this.Controls.Add(this.lsv);
            this.Controls.Add(this.tbxResult);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.BtnCaculate);
            this.Controls.Add(this.nudNumberOfPeople);
            this.Controls.Add(this.cbxCustomerType);
            this.Controls.Add(this.tbxThisMonthReading);
            this.Controls.Add(this.tbxLastMonthReading);
            this.Controls.Add(this.tbxCustomerName);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblNumberOfPeople);
            this.Controls.Add(this.lblCustomerType);
            this.Controls.Add(this.lblThisMonthReading);
            this.Controls.Add(this.lblLastMonthReading);
            this.Controls.Add(this.lblCustomerName);
            this.Name = "BillWater";
            this.Text = "BillWater";
            this.Load += new System.EventHandler(this.BillWater_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblLastMonthReading;
        private System.Windows.Forms.Label lblThisMonthReading;
        private System.Windows.Forms.Label lblCustomerType;
        private System.Windows.Forms.Label lblNumberOfPeople;
        private System.Windows.Forms.TextBox tbxCustomerName;
        private System.Windows.Forms.TextBox tbxLastMonthReading;
        private System.Windows.Forms.TextBox tbxThisMonthReading;
        private System.Windows.Forms.ComboBox cbxCustomerType;
        private System.Windows.Forms.NumericUpDown nudNumberOfPeople;
        private System.Windows.Forms.Button BtnCaculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox tbxResult;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListView lsv;
        private System.Windows.Forms.ColumnHeader colCustomerName;
        private System.Windows.Forms.ColumnHeader colLastMonthReading;
        private System.Windows.Forms.ColumnHeader colThisMonthReading;
        private System.Windows.Forms.ColumnHeader colConsumption;
        private System.Windows.Forms.ColumnHeader colNumberOfPeople;
        private System.Windows.Forms.ColumnHeader colTotalBill;
        private System.Windows.Forms.Button BtnFace;
        private System.Windows.Forms.TextBox tbxFind;
        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnSort;
    }
}