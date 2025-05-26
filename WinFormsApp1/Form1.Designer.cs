namespace WinFormsApp1
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
            panelAll = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonCreate = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonSortAge = new Button();
            buttonGroupCountry = new Button();
            buttonRefresh = new Button();
            buttonSave = new Button();
            buttonLoad = new Button();
            listView = new ListView();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            panelAll.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelAll
            // 
            panelAll.Controls.Add(flowLayoutPanel1);
            panelAll.Controls.Add(listView);
            panelAll.Dock = DockStyle.Fill;
            panelAll.Location = new Point(0, 0);
            panelAll.Name = "panelAll";
            panelAll.Size = new Size(770, 450);
            panelAll.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonCreate);
            flowLayoutPanel1.Controls.Add(buttonUpdate);
            flowLayoutPanel1.Controls.Add(buttonDelete);
            flowLayoutPanel1.Controls.Add(buttonSortAge);
            flowLayoutPanel1.Controls.Add(buttonGroupCountry);
            flowLayoutPanel1.Controls.Add(buttonRefresh);
            flowLayoutPanel1.Controls.Add(buttonSave);
            flowLayoutPanel1.Controls.Add(buttonLoad);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(537, 0);
            flowLayoutPanel1.Margin = new Padding(10);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(233, 450);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(13, 13);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(208, 29);
            buttonCreate.TabIndex = 0;
            buttonCreate.Text = "Создать";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(13, 48);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(208, 29);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(13, 83);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(208, 29);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSortAge
            // 
            buttonSortAge.Location = new Point(13, 118);
            buttonSortAge.Name = "buttonSortAge";
            buttonSortAge.Size = new Size(208, 29);
            buttonSortAge.TabIndex = 3;
            buttonSortAge.Text = "Sort Age";
            buttonSortAge.UseVisualStyleBackColor = true;
            buttonSortAge.Click += buttonSortAge_Click;
            // 
            // buttonGroupCountry
            // 
            buttonGroupCountry.Location = new Point(13, 153);
            buttonGroupCountry.Name = "buttonGroupCountry";
            buttonGroupCountry.Size = new Size(208, 29);
            buttonGroupCountry.TabIndex = 4;
            buttonGroupCountry.Text = "GroupByCountry";
            buttonGroupCountry.UseVisualStyleBackColor = true;
            buttonGroupCountry.Click += buttonGroupCountry_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(13, 188);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(208, 29);
            buttonRefresh.TabIndex = 5;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(13, 223);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(208, 29);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(13, 258);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(208, 29);
            buttonLoad.TabIndex = 7;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // listView
            // 
            listView.Dock = DockStyle.Fill;
            listView.GridLines = true;
            listView.Location = new Point(0, 0);
            listView.Name = "listView";
            listView.Size = new Size(770, 450);
            listView.TabIndex = 5;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.List;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 450);
            Controls.Add(panelAll);
            Name = "Form1";
            Text = "Form1";
            panelAll.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAll;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonCreate;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button buttonSortAge;
        private Button buttonGroupCountry;
        private ListView listView;
        private Button buttonRefresh;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button buttonSave;
        private Button buttonLoad;
    }
}
