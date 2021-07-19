namespace SQL_DataBase_Link
{
    partial class Form1
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
            this.Find_Name = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Find_Address = new System.Windows.Forms.Button();
            this.JoinTables = new System.Windows.Forms.Button();
            this.Add_Data = new System.Windows.Forms.Button();
            this.FN_SearchBox = new System.Windows.Forms.TextBox();
            this.FirstNameSearchLable = new System.Windows.Forms.Label();
            this.LastNameSearchLable = new System.Windows.Forms.Label();
            this.LN_SearchBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Find_Name
            // 
            this.Find_Name.Location = new System.Drawing.Point(477, 377);
            this.Find_Name.Name = "Find_Name";
            this.Find_Name.Size = new System.Drawing.Size(206, 71);
            this.Find_Name.TabIndex = 0;
            this.Find_Name.Text = "Find All Name";
            this.Find_Name.UseVisualStyleBackColor = true;
            this.Find_Name.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(459, 436);
            this.dataGridView1.TabIndex = 1;
            // 
            // Find_Address
            // 
            this.Find_Address.Location = new System.Drawing.Point(689, 377);
            this.Find_Address.Name = "Find_Address";
            this.Find_Address.Size = new System.Drawing.Size(206, 71);
            this.Find_Address.TabIndex = 2;
            this.Find_Address.Text = "Find Address";
            this.Find_Address.UseVisualStyleBackColor = true;
            this.Find_Address.Click += new System.EventHandler(this.Find_Address_Click);
            // 
            // JoinTables
            // 
            this.JoinTables.Location = new System.Drawing.Point(477, 300);
            this.JoinTables.Name = "JoinTables";
            this.JoinTables.Size = new System.Drawing.Size(206, 71);
            this.JoinTables.TabIndex = 3;
            this.JoinTables.Text = "Join Tables";
            this.JoinTables.UseVisualStyleBackColor = true;
            this.JoinTables.Click += new System.EventHandler(this.JoinTables_Click);
            // 
            // Add_Data
            // 
            this.Add_Data.Location = new System.Drawing.Point(689, 300);
            this.Add_Data.Name = "Add_Data";
            this.Add_Data.Size = new System.Drawing.Size(206, 71);
            this.Add_Data.TabIndex = 4;
            this.Add_Data.Text = "Add Data";
            this.Add_Data.UseVisualStyleBackColor = true;
            this.Add_Data.Click += new System.EventHandler(this.Add_Data_Click);
            // 
            // FN_SearchBox
            // 
            this.FN_SearchBox.Location = new System.Drawing.Point(795, 159);
            this.FN_SearchBox.Name = "FN_SearchBox";
            this.FN_SearchBox.Size = new System.Drawing.Size(100, 20);
            this.FN_SearchBox.TabIndex = 5;
            // 
            // FirstNameSearchLable
            // 
            this.FirstNameSearchLable.AutoSize = true;
            this.FirstNameSearchLable.Location = new System.Drawing.Point(795, 143);
            this.FirstNameSearchLable.Name = "FirstNameSearchLable";
            this.FirstNameSearchLable.Size = new System.Drawing.Size(94, 13);
            this.FirstNameSearchLable.TabIndex = 6;
            this.FirstNameSearchLable.Text = "Frist Name Search";
            // 
            // LastNameSearchLable
            // 
            this.LastNameSearchLable.AutoSize = true;
            this.LastNameSearchLable.Location = new System.Drawing.Point(795, 182);
            this.LastNameSearchLable.Name = "LastNameSearchLable";
            this.LastNameSearchLable.Size = new System.Drawing.Size(95, 13);
            this.LastNameSearchLable.TabIndex = 8;
            this.LastNameSearchLable.Text = "Last Name Search";
            // 
            // LN_SearchBox
            // 
            this.LN_SearchBox.Location = new System.Drawing.Point(795, 198);
            this.LN_SearchBox.Name = "LN_SearchBox";
            this.LN_SearchBox.Size = new System.Drawing.Size(100, 20);
            this.LN_SearchBox.TabIndex = 7;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(689, 223);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(206, 71);
            this.SearchButton.TabIndex = 9;
            this.SearchButton.Text = "Search Table";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 460);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.LastNameSearchLable);
            this.Controls.Add(this.LN_SearchBox);
            this.Controls.Add(this.FirstNameSearchLable);
            this.Controls.Add(this.FN_SearchBox);
            this.Controls.Add(this.Add_Data);
            this.Controls.Add(this.JoinTables);
            this.Controls.Add(this.Find_Address);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Find_Name);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Find_Name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Find_Address;
        private System.Windows.Forms.Button JoinTables;
        private System.Windows.Forms.Button Add_Data;
        private System.Windows.Forms.TextBox FN_SearchBox;
        private System.Windows.Forms.Label FirstNameSearchLable;
        private System.Windows.Forms.Label LastNameSearchLable;
        private System.Windows.Forms.TextBox LN_SearchBox;
        private System.Windows.Forms.Button SearchButton;
    }
}

