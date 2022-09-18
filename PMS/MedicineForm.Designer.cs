using System;

namespace PMS
{
    partial class MedicineForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MedId = new System.Windows.Forms.TextBox();
            this.MedQuantity = new System.Windows.Forms.TextBox();
            this.MedPrice = new System.Windows.Forms.TextBox();
            this.MedName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.dlt_mid = new Guna.UI2.WinForms.Guna2TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.MedDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MedDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(882, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.VisibleChanged += new System.EventHandler(this.button1_VisibleChanged);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(658, 456);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 39);
            this.button3.TabIndex = 4;
            this.button3.Text = "DELETE ID:";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Teal;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(658, 386);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 39);
            this.button4.TabIndex = 5;
            this.button4.Text = "ADD";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Teal;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(882, 386);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 39);
            this.button5.TabIndex = 6;
            this.button5.Text = "EDIT";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(338, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "MEDICINE ESTIMATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(654, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID";
            // 
            // MedId
            // 
            this.MedId.Location = new System.Drawing.Point(834, 98);
            this.MedId.Name = "MedId";
            this.MedId.Size = new System.Drawing.Size(162, 22);
            this.MedId.TabIndex = 9;
            this.MedId.TextChanged += new System.EventHandler(this.MedId_TextChanged);
            this.MedId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MedId_KeyPress);
            // 
            // MedQuantity
            // 
            this.MedQuantity.Location = new System.Drawing.Point(834, 295);
            this.MedQuantity.Name = "MedQuantity";
            this.MedQuantity.Size = new System.Drawing.Size(162, 22);
            this.MedQuantity.TabIndex = 10;
            this.MedQuantity.TextChanged += new System.EventHandler(this.MedQuantity_TextChanged);
            this.MedQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MedQuantity_KeyPress);
            // 
            // MedPrice
            // 
            this.MedPrice.Location = new System.Drawing.Point(834, 230);
            this.MedPrice.Name = "MedPrice";
            this.MedPrice.Size = new System.Drawing.Size(162, 22);
            this.MedPrice.TabIndex = 11;
            this.MedPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MedPrice_KeyPress);
            // 
            // MedName
            // 
            this.MedName.Location = new System.Drawing.Point(834, 165);
            this.MedName.Name = "MedName";
            this.MedName.Size = new System.Drawing.Size(162, 22);
            this.MedName.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(654, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "MedicineName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(654, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(654, 294);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Quantity";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Teal;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(882, 530);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 39);
            this.button6.TabIndex = 16;
            this.button6.Text = "LOGOUT";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Teal;
            this.guna2Button1.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.BorderRadius = 3;
            this.guna2Button1.BorderThickness = 3;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Teal;
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(658, 530);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(114, 40);
            this.guna2Button1.TabIndex = 37;
            this.guna2Button1.Text = "Refresh";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // dlt_mid
            // 
            this.dlt_mid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dlt_mid.DefaultText = "";
            this.dlt_mid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.dlt_mid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.dlt_mid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dlt_mid.DisabledState.Parent = this.dlt_mid;
            this.dlt_mid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dlt_mid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dlt_mid.FocusedState.Parent = this.dlt_mid;
            this.dlt_mid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dlt_mid.HoverState.Parent = this.dlt_mid;
            this.dlt_mid.Location = new System.Drawing.Point(766, 457);
            this.dlt_mid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dlt_mid.Name = "dlt_mid";
            this.dlt_mid.PasswordChar = '\0';
            this.dlt_mid.PlaceholderText = "";
            this.dlt_mid.SelectedText = "";
            this.dlt_mid.ShadowDecoration.Parent = this.dlt_mid;
            this.dlt_mid.Size = new System.Drawing.Size(53, 38);
            this.dlt_mid.TabIndex = 38;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.DarkRed;
            this.button7.Location = new System.Drawing.Point(977, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(58, 39);
            this.button7.TabIndex = 39;
            this.button7.Text = "X";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // MedDataGridView
            // 
            this.MedDataGridView.AllowUserToAddRows = false;
            this.MedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedDataGridView.Location = new System.Drawing.Point(24, 101);
            this.MedDataGridView.Name = "MedDataGridView";
            this.MedDataGridView.RowHeadersWidth = 51;
            this.MedDataGridView.RowTemplate.Height = 24;
            this.MedDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MedDataGridView.Size = new System.Drawing.Size(596, 509);
            this.MedDataGridView.TabIndex = 41;
            // 
            // MedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1035, 640);
            this.Controls.Add(this.MedDataGridView);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dlt_mid);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MedName);
            this.Controls.Add(this.MedPrice);
            this.Controls.Add(this.MedQuantity);
            this.Controls.Add(this.MedId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MedicineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicineForm";
            this.Load += new System.EventHandler(this.MedicineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MedDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MedId;
        private System.Windows.Forms.TextBox MedQuantity;
        private System.Windows.Forms.TextBox MedPrice;
        private System.Windows.Forms.TextBox MedName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox dlt_mid;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView MedDataGridView;
    }
}