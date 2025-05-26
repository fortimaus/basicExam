namespace WinFormsApp3
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
            listView1 = new ListView();
            panel1 = new Panel();
            buttonRefresh = new Button();
            buttonLoad = new Button();
            buttonSave = new Button();
            buttonGroup = new Button();
            buttonAverage = new Button();
            buttonCreate = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(477, 426);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonRefresh);
            panel1.Controls.Add(buttonLoad);
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonGroup);
            panel1.Controls.Add(buttonAverage);
            panel1.Controls.Add(buttonCreate);
            panel1.Location = new Point(509, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 426);
            panel1.TabIndex = 1;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(69, 179);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(94, 29);
            buttonRefresh.TabIndex = 5;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(69, 281);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(94, 29);
            buttonLoad.TabIndex = 4;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(69, 229);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonGroup
            // 
            buttonGroup.Location = new Point(69, 130);
            buttonGroup.Name = "buttonGroup";
            buttonGroup.Size = new Size(94, 29);
            buttonGroup.TabIndex = 2;
            buttonGroup.Text = "Group";
            buttonGroup.UseVisualStyleBackColor = true;
            buttonGroup.Click += buttonGroup_Click;
            // 
            // buttonAverage
            // 
            buttonAverage.Location = new Point(69, 79);
            buttonAverage.Name = "buttonAverage";
            buttonAverage.Size = new Size(94, 29);
            buttonAverage.TabIndex = 1;
            buttonAverage.Text = "Average";
            buttonAverage.UseVisualStyleBackColor = true;
            buttonAverage.Click += buttonAverage_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(69, 21);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(94, 29);
            buttonCreate.TabIndex = 0;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Panel panel1;
        private Button buttonRefresh;
        private Button buttonLoad;
        private Button buttonSave;
        private Button buttonGroup;
        private Button buttonAverage;
        private Button buttonCreate;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
