
namespace GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgw = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Success = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmbx = new System.Windows.Forms.ComboBox();
            this.eventTxt = new System.Windows.Forms.TextBox();
            this.eventAdd = new System.Windows.Forms.Button();
            this.eventDelete = new System.Windows.Forms.Button();
            this.eventUpdate = new System.Windows.Forms.Button();
            this.isSuccess = new System.Windows.Forms.CheckBox();
            this.scheduleAdd = new System.Windows.Forms.Button();
            this.scheduleUpdate = new System.Windows.Forms.Button();
            this.scheduleDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw
            // 
            this.dgw.AllowUserToAddRows = false;
            this.dgw.AllowUserToDeleteRows = false;
            this.dgw.AllowUserToResizeRows = false;
            this.dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw.BackgroundColor = System.Drawing.Color.White;
            this.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.EventName,
            this.Date,
            this.Success});
            this.dgw.Location = new System.Drawing.Point(12, 12);
            this.dgw.Name = "dgw";
            this.dgw.RowTemplate.Height = 25;
            this.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw.Size = new System.Drawing.Size(497, 208);
            this.dgw.TabIndex = 0;
            this.dgw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // EventName
            // 
            this.EventName.HeaderText = "EventName";
            this.EventName.Name = "EventName";
            this.EventName.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Success
            // 
            this.Success.HeaderText = "Success";
            this.Success.Name = "Success";
            this.Success.ReadOnly = true;
            // 
            // cmbx
            // 
            this.cmbx.FormattingEnabled = true;
            this.cmbx.Location = new System.Drawing.Point(656, 36);
            this.cmbx.Name = "cmbx";
            this.cmbx.Size = new System.Drawing.Size(93, 23);
            this.cmbx.TabIndex = 1;
            // 
            // eventTxt
            // 
            this.eventTxt.Location = new System.Drawing.Point(584, 168);
            this.eventTxt.Name = "eventTxt";
            this.eventTxt.Size = new System.Drawing.Size(168, 23);
            this.eventTxt.TabIndex = 2;
            // 
            // eventAdd
            // 
            this.eventAdd.Location = new System.Drawing.Point(515, 197);
            this.eventAdd.Name = "eventAdd";
            this.eventAdd.Size = new System.Drawing.Size(75, 23);
            this.eventAdd.TabIndex = 3;
            this.eventAdd.Text = "Add";
            this.eventAdd.UseVisualStyleBackColor = true;
            this.eventAdd.Click += new System.EventHandler(this.eventAdd_Click);
            // 
            // eventDelete
            // 
            this.eventDelete.Location = new System.Drawing.Point(596, 197);
            this.eventDelete.Name = "eventDelete";
            this.eventDelete.Size = new System.Drawing.Size(75, 23);
            this.eventDelete.TabIndex = 4;
            this.eventDelete.Text = "Delete";
            this.eventDelete.UseVisualStyleBackColor = true;
            this.eventDelete.Click += new System.EventHandler(this.eventDelete_Click);
            // 
            // eventUpdate
            // 
            this.eventUpdate.Location = new System.Drawing.Point(677, 197);
            this.eventUpdate.Name = "eventUpdate";
            this.eventUpdate.Size = new System.Drawing.Size(75, 23);
            this.eventUpdate.TabIndex = 5;
            this.eventUpdate.Text = "Update";
            this.eventUpdate.UseVisualStyleBackColor = true;
            this.eventUpdate.Click += new System.EventHandler(this.eventUpdate_Click);
            // 
            // isSuccess
            // 
            this.isSuccess.AutoSize = true;
            this.isSuccess.Location = new System.Drawing.Point(604, 65);
            this.isSuccess.Name = "isSuccess";
            this.isSuccess.Size = new System.Drawing.Size(67, 19);
            this.isSuccess.TabIndex = 6;
            this.isSuccess.Text = "Success";
            this.isSuccess.UseVisualStyleBackColor = true;
            // 
            // scheduleAdd
            // 
            this.scheduleAdd.BackColor = System.Drawing.Color.Transparent;
            this.scheduleAdd.Location = new System.Drawing.Point(515, 36);
            this.scheduleAdd.Name = "scheduleAdd";
            this.scheduleAdd.Size = new System.Drawing.Size(75, 23);
            this.scheduleAdd.TabIndex = 7;
            this.scheduleAdd.Text = "Add";
            this.scheduleAdd.UseVisualStyleBackColor = false;
            this.scheduleAdd.Click += new System.EventHandler(this.scheduleAdd_Click);
            // 
            // scheduleUpdate
            // 
            this.scheduleUpdate.BackColor = System.Drawing.Color.Transparent;
            this.scheduleUpdate.Location = new System.Drawing.Point(515, 65);
            this.scheduleUpdate.Name = "scheduleUpdate";
            this.scheduleUpdate.Size = new System.Drawing.Size(75, 23);
            this.scheduleUpdate.TabIndex = 8;
            this.scheduleUpdate.Text = "Update";
            this.scheduleUpdate.UseVisualStyleBackColor = false;
            this.scheduleUpdate.Click += new System.EventHandler(this.scheduleUpdate_Click);
            // 
            // scheduleDelete
            // 
            this.scheduleDelete.BackColor = System.Drawing.Color.Transparent;
            this.scheduleDelete.Location = new System.Drawing.Point(515, 94);
            this.scheduleDelete.Name = "scheduleDelete";
            this.scheduleDelete.Size = new System.Drawing.Size(75, 23);
            this.scheduleDelete.TabIndex = 9;
            this.scheduleDelete.Text = "Delete";
            this.scheduleDelete.UseVisualStyleBackColor = false;
            this.scheduleDelete.Click += new System.EventHandler(this.scheduleDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(515, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Schedule";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(515, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Event";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(603, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Events: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(515, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "New Event: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(761, 228);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scheduleDelete);
            this.Controls.Add(this.scheduleUpdate);
            this.Controls.Add(this.scheduleAdd);
            this.Controls.Add(this.isSuccess);
            this.Controls.Add(this.eventUpdate);
            this.Controls.Add(this.eventDelete);
            this.Controls.Add(this.eventAdd);
            this.Controls.Add(this.eventTxt);
            this.Controls.Add(this.cmbx);
            this.Controls.Add(this.dgw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Schedule";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw;
        private System.Windows.Forms.ComboBox cmbx;
        private System.Windows.Forms.TextBox eventTxt;
        private System.Windows.Forms.Button eventAdd;
        private System.Windows.Forms.Button eventDelete;
        private System.Windows.Forms.Button eventUpdate;
        private System.Windows.Forms.CheckBox isSuccess;
        private System.Windows.Forms.Button scheduleAdd;
        private System.Windows.Forms.Button scheduleUpdate;
        private System.Windows.Forms.Button scheduleDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Success;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

