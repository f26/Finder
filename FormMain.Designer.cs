using BrightIdeasSoftware;

namespace Finder
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            textBoxSearchText = new TextBox();
            buttonFind = new Button();
            olv = new ObjectListView();
            colName = new OLVColumn();
            colType = new OLVColumn();
            colSize = new OLVColumn();
            colPath = new OLVColumn();
            colModTime = new OLVColumn();
            colCreateTime = new OLVColumn();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            labelCount = new Label();
            label1 = new Label();
            textBoxSearchPath = new TextBox();
            label2 = new Label();
            groupBoxLimitSize = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            textBoxSizeLimit = new TextBox();
            comboBoxSizeUnit = new ComboBox();
            checkBoxSizeLimit = new CheckBox();
            checkBoxTimeLimit = new CheckBox();
            groupBoxLimitTime = new GroupBox();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            textBoxTimeLimit = new TextBox();
            comboBoxTimeUnit = new ComboBox();
            pictureBoxRover = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)olv).BeginInit();
            statusStrip1.SuspendLayout();
            groupBoxLimitSize.SuspendLayout();
            groupBoxLimitTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRover).BeginInit();
            SuspendLayout();
            // 
            // textBoxSearchText
            // 
            textBoxSearchText.Location = new Point(81, 12);
            textBoxSearchText.Name = "textBoxSearchText";
            textBoxSearchText.Size = new Size(289, 23);
            textBoxSearchText.TabIndex = 0;
            textBoxSearchText.KeyUp += textBoxSearchText_KeyUp;
            // 
            // buttonFind
            // 
            buttonFind.Location = new Point(376, 12);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(75, 23);
            buttonFind.TabIndex = 1;
            buttonFind.Text = "Search";
            buttonFind.UseVisualStyleBackColor = true;
            buttonFind.Click += buttonFind_Click;
            // 
            // olv
            // 
            olv.CellEditUseWholeCell = false;
            olv.Columns.AddRange(new ColumnHeader[] { colName, colType, colSize, colPath, colModTime, colCreateTime });
            olv.FullRowSelect = true;
            olv.Location = new Point(12, 91);
            olv.Name = "olv";
            olv.ShowGroups = false;
            olv.Size = new Size(920, 499);
            olv.TabIndex = 2;
            olv.View = View.Details;
            olv.DoubleClick += olv_DoubleClick;
            olv.KeyUp += olv_KeyUp;
            olv.MouseClick += olv_MouseClick;
            // 
            // colName
            // 
            colName.AspectName = "Name";
            colName.MaximumWidth = 750;
            colName.MinimumWidth = 200;
            colName.Text = "Name";
            colName.Width = 200;
            // 
            // colType
            // 
            colType.AspectName = "Type";
            colType.Text = "Type";
            colType.Width = 45;
            // 
            // colSize
            // 
            colSize.AspectName = "Size";
            colSize.Text = "Size";
            colSize.Width = 80;
            // 
            // colPath
            // 
            colPath.AspectName = "Path";
            colPath.FillsFreeSpace = true;
            colPath.MinimumWidth = 200;
            colPath.Text = "Full path";
            colPath.Width = 500;
            // 
            // colModTime
            // 
            colModTime.AspectName = "DateModified";
            colModTime.Text = "Last Modified";
            colModTime.Width = 140;
            // 
            // colCreateTime
            // 
            colCreateTime.AspectName = "DateCreated";
            colCreateTime.Text = "Created";
            colCreateTime.Width = 140;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 447);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1216, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(39, 17);
            toolStripStatusLabel1.Text = "Ready";
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Location = new Point(376, 59);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(45, 15);
            labelCount.TabIndex = 4;
            labelCount.Text = "0 items";
            labelCount.Click += labelCount_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 59);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 5;
            label1.Text = "Path";
            // 
            // textBoxSearchPath
            // 
            textBoxSearchPath.Location = new Point(81, 56);
            textBoxSearchPath.Name = "textBoxSearchPath";
            textBoxSearchPath.Size = new Size(289, 23);
            textBoxSearchPath.TabIndex = 6;
            textBoxSearchPath.Text = "C:\\Users\\";
            textBoxSearchPath.KeyUp += textBoxSearchText_KeyUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 16);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 7;
            label2.Text = "Search for:";
            // 
            // groupBoxLimitSize
            // 
            groupBoxLimitSize.Controls.Add(radioButton3);
            groupBoxLimitSize.Controls.Add(radioButton4);
            groupBoxLimitSize.Controls.Add(textBoxSizeLimit);
            groupBoxLimitSize.Controls.Add(comboBoxSizeUnit);
            groupBoxLimitSize.Enabled = false;
            groupBoxLimitSize.Location = new Point(640, 0);
            groupBoxLimitSize.Name = "groupBoxLimitSize";
            groupBoxLimitSize.Size = new Size(381, 43);
            groupBoxLimitSize.TabIndex = 16;
            groupBoxLimitSize.TabStop = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Checked = true;
            radioButton3.Location = new Point(6, 15);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(85, 19);
            radioButton3.TabIndex = 15;
            radioButton3.TabStop = true;
            radioButton3.Text = "Larger than";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(97, 15);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(91, 19);
            radioButton4.TabIndex = 18;
            radioButton4.Text = "Smaller than";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // textBoxSizeLimit
            // 
            textBoxSizeLimit.Location = new Point(194, 14);
            textBoxSizeLimit.Name = "textBoxSizeLimit";
            textBoxSizeLimit.Size = new Size(99, 23);
            textBoxSizeLimit.TabIndex = 19;
            // 
            // comboBoxSizeUnit
            // 
            comboBoxSizeUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSizeUnit.FormattingEnabled = true;
            comboBoxSizeUnit.Items.AddRange(new object[] { "B", "KB", "MB", "GB" });
            comboBoxSizeUnit.Location = new Point(299, 14);
            comboBoxSizeUnit.Name = "comboBoxSizeUnit";
            comboBoxSizeUnit.Size = new Size(74, 23);
            comboBoxSizeUnit.TabIndex = 20;
            // 
            // checkBoxSizeLimit
            // 
            checkBoxSizeLimit.AutoSize = true;
            checkBoxSizeLimit.Location = new Point(509, 16);
            checkBoxSizeLimit.Name = "checkBoxSizeLimit";
            checkBoxSizeLimit.Size = new Size(92, 19);
            checkBoxSizeLimit.TabIndex = 17;
            checkBoxSizeLimit.Text = "Limit size to:";
            checkBoxSizeLimit.UseVisualStyleBackColor = true;
            checkBoxSizeLimit.CheckedChanged += checkBoxSizeLimit_CheckedChanged;
            // 
            // checkBoxTimeLimit
            // 
            checkBoxTimeLimit.AutoSize = true;
            checkBoxTimeLimit.Location = new Point(509, 58);
            checkBoxTimeLimit.Name = "checkBoxTimeLimit";
            checkBoxTimeLimit.Size = new Size(125, 19);
            checkBoxTimeLimit.TabIndex = 21;
            checkBoxTimeLimit.Text = "Limit mod time to:";
            checkBoxTimeLimit.UseVisualStyleBackColor = true;
            checkBoxTimeLimit.CheckedChanged += checkBoxTimeLimit_CheckedChanged;
            // 
            // groupBoxLimitTime
            // 
            groupBoxLimitTime.Controls.Add(radioButton5);
            groupBoxLimitTime.Controls.Add(radioButton6);
            groupBoxLimitTime.Controls.Add(textBoxTimeLimit);
            groupBoxLimitTime.Controls.Add(comboBoxTimeUnit);
            groupBoxLimitTime.Enabled = false;
            groupBoxLimitTime.Location = new Point(640, 42);
            groupBoxLimitTime.Name = "groupBoxLimitTime";
            groupBoxLimitTime.Size = new Size(381, 43);
            groupBoxLimitTime.TabIndex = 21;
            groupBoxLimitTime.TabStop = false;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Checked = true;
            radioButton5.Location = new Point(6, 15);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(86, 19);
            radioButton5.TabIndex = 15;
            radioButton5.TabStop = true;
            radioButton5.Text = "Newer than";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(97, 15);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(81, 19);
            radioButton6.TabIndex = 18;
            radioButton6.Text = "Older than";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // textBoxTimeLimit
            // 
            textBoxTimeLimit.Location = new Point(194, 14);
            textBoxTimeLimit.Name = "textBoxTimeLimit";
            textBoxTimeLimit.Size = new Size(99, 23);
            textBoxTimeLimit.TabIndex = 19;
            // 
            // comboBoxTimeUnit
            // 
            comboBoxTimeUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTimeUnit.FormattingEnabled = true;
            comboBoxTimeUnit.Items.AddRange(new object[] { "hours", "days", "months", "years" });
            comboBoxTimeUnit.Location = new Point(299, 14);
            comboBoxTimeUnit.Name = "comboBoxTimeUnit";
            comboBoxTimeUnit.Size = new Size(74, 23);
            comboBoxTimeUnit.TabIndex = 20;
            // 
            // pictureBoxRover
            // 
            pictureBoxRover.Image = (Image)resources.GetObject("pictureBoxRover.Image");
            pictureBoxRover.Location = new Point(1027, 12);
            pictureBoxRover.Name = "pictureBoxRover";
            pictureBoxRover.Size = new Size(73, 73);
            pictureBoxRover.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxRover.TabIndex = 22;
            pictureBoxRover.TabStop = false;
            pictureBoxRover.Visible = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 469);
            Controls.Add(pictureBoxRover);
            Controls.Add(groupBoxLimitTime);
            Controls.Add(checkBoxTimeLimit);
            Controls.Add(checkBoxSizeLimit);
            Controls.Add(groupBoxLimitSize);
            Controls.Add(label2);
            Controls.Add(textBoxSearchPath);
            Controls.Add(label1);
            Controls.Add(labelCount);
            Controls.Add(statusStrip1);
            Controls.Add(buttonFind);
            Controls.Add(textBoxSearchText);
            Controls.Add(olv);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMain";
            Text = "Finder";
            Load += FormMain_Load;
            Resize += FormMain_Resize;
            ((System.ComponentModel.ISupportInitialize)olv).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBoxLimitSize.ResumeLayout(false);
            groupBoxLimitSize.PerformLayout();
            groupBoxLimitTime.ResumeLayout(false);
            groupBoxLimitTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRover).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSearchText;
        private Button buttonFind;
        private ObjectListView olv;
        private OLVColumn colName, colType, colSize, colPath, colModTime, colCreateTime;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Label labelCount;
        private Label label1;
        private TextBox textBoxSearchPath;
        private Label label2;
        private GroupBox groupBoxLimitSize;
        private CheckBox checkBoxSizeLimit;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private TextBox textBoxSizeLimit;
        private ComboBox comboBoxSizeUnit;
        private CheckBox checkBoxTimeLimit;
        private GroupBox groupBoxLimitTime;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private TextBox textBoxTimeLimit;
        private ComboBox comboBoxTimeUnit;
        private PictureBox pictureBoxRover;
    }
}