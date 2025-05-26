namespace WinFormsApp1
{
    partial class Create
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
            buttonSave = new Button();
            buttonCancel = new Button();
            label1 = new Label();
            textName = new TextBox();
            textCountry = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textPhone = new TextBox();
            numericAge = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericAge).BeginInit();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(299, 212);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(47, 212);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 2;
            label1.Text = "name";
            // 
            // textName
            // 
            textName.Location = new Point(22, 45);
            textName.Name = "textName";
            textName.Size = new Size(159, 27);
            textName.TabIndex = 3;
            // 
            // textCountry
            // 
            textCountry.Location = new Point(23, 130);
            textCountry.Name = "textCountry";
            textCountry.Size = new Size(158, 27);
            textCountry.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 9);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 5;
            label2.Text = "age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 95);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 6;
            label3.Text = "country";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(256, 95);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 7;
            label4.Text = "phone";
            // 
            // textPhone
            // 
            textPhone.Location = new Point(256, 130);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(148, 27);
            textPhone.TabIndex = 8;
            // 
            // numericAge
            // 
            numericAge.Location = new Point(256, 45);
            numericAge.Name = "numericAge";
            numericAge.Size = new Size(148, 27);
            numericAge.TabIndex = 9;
            // 
            // Create
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 256);
            Controls.Add(numericAge);
            Controls.Add(textPhone);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textCountry);
            Controls.Add(textName);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Name = "Create";
            Text = "Create";
            ((System.ComponentModel.ISupportInitialize)numericAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Button buttonCancel;
        private Label label1;
        private TextBox textName;
        private TextBox textCountry;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textPhone;
        private NumericUpDown numericAge;
    }
}