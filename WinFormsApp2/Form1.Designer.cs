namespace WinFormsApp2
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
            buttonLoad = new Button();
            buttonSave = new Button();
            buttonRefresh = new Button();
            buttonGroup = new Button();
            buttonAverage = new Button();
            buttonCreate = new Button();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(73, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(355, 426);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonLoad);
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonRefresh);
            panel1.Controls.Add(buttonGroup);
            panel1.Controls.Add(buttonAverage);
            panel1.Controls.Add(buttonCreate);
            panel1.Location = new Point(538, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 426);
            panel1.TabIndex = 1;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(84, 307);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(94, 29);
            buttonLoad.TabIndex = 5;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(84, 255);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(84, 201);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(94, 29);
            buttonRefresh.TabIndex = 3;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonGroup
            // 
            buttonGroup.Location = new Point(84, 137);
            buttonGroup.Name = "buttonGroup";
            buttonGroup.Size = new Size(94, 29);
            buttonGroup.TabIndex = 2;
            buttonGroup.Text = "Group";
            buttonGroup.UseVisualStyleBackColor = true;
            buttonGroup.Click += buttonGroup_Click;
            // 
            // buttonAverage
            // 
            buttonAverage.Location = new Point(84, 74);
            buttonAverage.Name = "buttonAverage";
            buttonAverage.Size = new Size(94, 29);
            buttonAverage.TabIndex = 1;
            buttonAverage.Text = "Average";
            buttonAverage.UseVisualStyleBackColor = true;
            buttonAverage.Click += buttonAverage_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(84, 20);
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
        private Button buttonLoad;
        private Button buttonSave;
        private Button buttonRefresh;
        private Button buttonGroup;
        private Button buttonAverage;
        private Button buttonCreate;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
    }
}
