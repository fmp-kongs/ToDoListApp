namespace ToDoListApp
{
    partial class ToDoList
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
            this.label1 = new System.Windows.Forms.Label();
            this.TitleTextbox = new System.Windows.Forms.TextBox();
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.ToDoListView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PriorityComboBox = new System.Windows.Forms.ComboBox();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.DuedateMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.FilterTextBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.IdFilterTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ToDoListView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1439, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "ToDo List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TitleTextbox
            // 
            this.TitleTextbox.Location = new System.Drawing.Point(12, 67);
            this.TitleTextbox.Name = "TitleTextbox";
            this.TitleTextbox.Size = new System.Drawing.Size(234, 22);
            this.TitleTextbox.TabIndex = 1;
            this.TitleTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Location = new System.Drawing.Point(12, 111);
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(1441, 22);
            this.descriptionTextbox.TabIndex = 2;
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(12, 92);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(212, 16);
            this.Description.TabIndex = 3;
            this.Description.Text = "Description";
            this.Description.Click += new System.EventHandler(this.Description_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonAdd.Location = new System.Drawing.Point(33, 399);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(337, 45);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add ";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Location = new System.Drawing.Point(1346, 13);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(71, 45);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.LawnGreen;
            this.buttonSave.Location = new System.Drawing.Point(1080, 399);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(337, 45);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save ";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonEdit.Location = new System.Drawing.Point(725, 399);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(337, 45);
            this.buttonEdit.TabIndex = 8;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.LightCoral;
            this.buttonDelete.Location = new System.Drawing.Point(376, 399);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(337, 45);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // ToDoListView
            // 
            this.ToDoListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ToDoListView.BackgroundColor = System.Drawing.Color.White;
            this.ToDoListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ToDoListView.Location = new System.Drawing.Point(20, 490);
            this.ToDoListView.Name = "ToDoListView";
            this.ToDoListView.RowHeadersWidth = 51;
            this.ToDoListView.RowTemplate.Height = 24;
            this.ToDoListView.Size = new System.Drawing.Size(1432, 321);
            this.ToDoListView.StandardTab = true;
            this.ToDoListView.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(500, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Due Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepPink;
            this.button1.Location = new System.Drawing.Point(1163, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 45);
            this.button1.TabIndex = 14;
            this.button1.Text = "Save to file";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(1009, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 45);
            this.button2.TabIndex = 15;
            this.button2.Text = "Load from file";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Status";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(228, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Prioritized";
            // 
            // PriorityComboBox
            // 
            this.PriorityComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PriorityComboBox.FormattingEnabled = true;
            this.PriorityComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.PriorityComboBox.Location = new System.Drawing.Point(220, 180);
            this.PriorityComboBox.Name = "PriorityComboBox";
            this.PriorityComboBox.Size = new System.Drawing.Size(121, 24);
            this.PriorityComboBox.TabIndex = 21;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "Completed",
            "Pending"});
            this.StatusComboBox.Location = new System.Drawing.Point(12, 180);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(121, 24);
            this.StatusComboBox.TabIndex = 22;
            // 
            // DuedateMonthCalendar
            // 
            this.DuedateMonthCalendar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DuedateMonthCalendar.ForeColor = System.Drawing.Color.Cyan;
            this.DuedateMonthCalendar.Location = new System.Drawing.Point(489, 180);
            this.DuedateMonthCalendar.Name = "DuedateMonthCalendar";
            this.DuedateMonthCalendar.TabIndex = 23;
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Location = new System.Drawing.Point(841, 458);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(127, 22);
            this.FilterTextBox.TabIndex = 24;
            this.FilterTextBox.TextChanged += new System.EventHandler(this.FilterTextBox_TextChanged);
            // 
            // FilterTextBox2
            // 
            this.FilterTextBox2.Location = new System.Drawing.Point(1281, 459);
            this.FilterTextBox2.Name = "FilterTextBox2";
            this.FilterTextBox2.Size = new System.Drawing.Size(124, 22);
            this.FilterTextBox2.TabIndex = 25;
            this.FilterTextBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(790, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Filter";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(1236, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Filter";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(340, 462);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "Sort";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(1064, 461);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(75, 23);
            this.SortButton.TabIndex = 29;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // IdFilterTextBox
            // 
            this.IdFilterTextBox.Location = new System.Drawing.Point(86, 463);
            this.IdFilterTextBox.Name = "IdFilterTextBox";
            this.IdFilterTextBox.Size = new System.Drawing.Size(127, 22);
            this.IdFilterTextBox.TabIndex = 30;
            this.IdFilterTextBox.TextChanged += new System.EventHandler(this.IdFilterTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(33, 466);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Filter";
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1464, 704);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.IdFilterTextBox);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FilterTextBox2);
            this.Controls.Add(this.FilterTextBox);
            this.Controls.Add(this.DuedateMonthCalendar);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.PriorityComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ToDoListView);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.descriptionTextbox);
            this.Controls.Add(this.TitleTextbox);
            this.Controls.Add(this.label1);
            this.Name = "ToDoList";
            this.Text = "ToDoList";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ToDoListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TitleTextbox;
        private System.Windows.Forms.TextBox descriptionTextbox;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView ToDoListView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox PriorityComboBox;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.MonthCalendar DuedateMonthCalendar;
        private System.Windows.Forms.TextBox FilterTextBox;
        private System.Windows.Forms.TextBox FilterTextBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.TextBox IdFilterTextBox;
        private System.Windows.Forms.Label label8;
    }
}

