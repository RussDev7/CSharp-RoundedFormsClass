using System.Windows.Forms;
using System.Drawing;

namespace RoundedFormsExample
{
    partial class MainForm
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
            BottomRight_Button = new Button();
            BottomLeft_Button = new Button();
            TopRight_Button = new Button();
            TopLeft_Button = new Button();
            RoundedCorners_Label = new Label();
            TopLeftCorner_CheckBox = new CheckBox();
            TopRightCorner_CheckBox = new CheckBox();
            BottomLeftCorner_CheckBox = new CheckBox();
            BottomRightCorner_CheckBox = new CheckBox();
            DarkMode_CheckBox = new CheckBox();
            ShowIcon_CheckBox = new CheckBox();
            Settings_Label = new Label();
            CornerRadius_Label = new Label();
            TitleBarHeight_Label = new Label();
            BorderSize_Label = new Label();
            CornerRadius_NumericUpDown = new NumericUpDown();
            TitleBarHeight_NumericUpDown = new NumericUpDown();
            BorderSize_NumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)CornerRadius_NumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TitleBarHeight_NumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BorderSize_NumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // BottomRight_Button
            // 
            BottomRight_Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BottomRight_Button.ForeColor = Color.Black;
            BottomRight_Button.Location = new Point(303, 172);
            BottomRight_Button.Name = "BottomRight_Button";
            BottomRight_Button.Size = new Size(90, 23);
            BottomRight_Button.TabIndex = 3;
            BottomRight_Button.Text = "Bottom Right";
            BottomRight_Button.UseVisualStyleBackColor = true;
            // 
            // BottomLeft_Button
            // 
            BottomLeft_Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BottomLeft_Button.ForeColor = Color.Black;
            BottomLeft_Button.Location = new Point(3, 172);
            BottomLeft_Button.Name = "BottomLeft_Button";
            BottomLeft_Button.Size = new Size(90, 23);
            BottomLeft_Button.TabIndex = 2;
            BottomLeft_Button.Text = "Bottom Left";
            BottomLeft_Button.UseVisualStyleBackColor = true;
            // 
            // TopRight_Button
            // 
            TopRight_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TopRight_Button.ForeColor = Color.Black;
            TopRight_Button.Location = new Point(303, 3);
            TopRight_Button.Name = "TopRight_Button";
            TopRight_Button.Size = new Size(90, 23);
            TopRight_Button.TabIndex = 1;
            TopRight_Button.Text = "Top Right";
            TopRight_Button.UseVisualStyleBackColor = true;
            // 
            // TopLeft_Button
            // 
            TopLeft_Button.ForeColor = Color.Black;
            TopLeft_Button.Location = new Point(3, 3);
            TopLeft_Button.Name = "TopLeft_Button";
            TopLeft_Button.Size = new Size(90, 23);
            TopLeft_Button.TabIndex = 0;
            TopLeft_Button.Text = "Top Left";
            TopLeft_Button.UseVisualStyleBackColor = true;
            // 
            // RoundedCorners_Label
            // 
            RoundedCorners_Label.AutoSize = true;
            RoundedCorners_Label.Location = new Point(14, 57);
            RoundedCorners_Label.Name = "RoundedCorners_Label";
            RoundedCorners_Label.Size = new Size(102, 15);
            RoundedCorners_Label.TabIndex = 0;
            RoundedCorners_Label.Text = "Rounded Corners:";
            // 
            // TopLeftCorner_CheckBox
            // 
            TopLeftCorner_CheckBox.AutoSize = true;
            TopLeftCorner_CheckBox.Checked = true;
            TopLeftCorner_CheckBox.CheckState = CheckState.Checked;
            TopLeftCorner_CheckBox.Location = new Point(18, 75);
            TopLeftCorner_CheckBox.Name = "TopLeftCorner_CheckBox";
            TopLeftCorner_CheckBox.Size = new Size(68, 19);
            TopLeftCorner_CheckBox.TabIndex = 1;
            TopLeftCorner_CheckBox.Text = "Top Left";
            TopLeftCorner_CheckBox.UseVisualStyleBackColor = true;
            TopLeftCorner_CheckBox.CheckedChanged += UpdateUITheme;
            // 
            // TopRightCorner_CheckBox
            // 
            TopRightCorner_CheckBox.AutoSize = true;
            TopRightCorner_CheckBox.Checked = true;
            TopRightCorner_CheckBox.CheckState = CheckState.Checked;
            TopRightCorner_CheckBox.Location = new Point(113, 75);
            TopRightCorner_CheckBox.Name = "TopRightCorner_CheckBox";
            TopRightCorner_CheckBox.Size = new Size(76, 19);
            TopRightCorner_CheckBox.TabIndex = 2;
            TopRightCorner_CheckBox.Text = "Top Right";
            TopRightCorner_CheckBox.UseVisualStyleBackColor = true;
            TopRightCorner_CheckBox.CheckedChanged += UpdateUITheme;
            // 
            // BottomLeftCorner_CheckBox
            // 
            BottomLeftCorner_CheckBox.AutoSize = true;
            BottomLeftCorner_CheckBox.Checked = true;
            BottomLeftCorner_CheckBox.CheckState = CheckState.Checked;
            BottomLeftCorner_CheckBox.Location = new Point(18, 100);
            BottomLeftCorner_CheckBox.Name = "BottomLeftCorner_CheckBox";
            BottomLeftCorner_CheckBox.Size = new Size(89, 19);
            BottomLeftCorner_CheckBox.TabIndex = 3;
            BottomLeftCorner_CheckBox.Text = "Bottom Left";
            BottomLeftCorner_CheckBox.UseVisualStyleBackColor = true;
            BottomLeftCorner_CheckBox.CheckedChanged += UpdateUITheme;
            // 
            // BottomRightCorner_CheckBox
            // 
            BottomRightCorner_CheckBox.AutoSize = true;
            BottomRightCorner_CheckBox.Checked = true;
            BottomRightCorner_CheckBox.CheckState = CheckState.Checked;
            BottomRightCorner_CheckBox.Location = new Point(113, 100);
            BottomRightCorner_CheckBox.Name = "BottomRightCorner_CheckBox";
            BottomRightCorner_CheckBox.Size = new Size(97, 19);
            BottomRightCorner_CheckBox.TabIndex = 4;
            BottomRightCorner_CheckBox.Text = "Bottom Right";
            BottomRightCorner_CheckBox.UseVisualStyleBackColor = true;
            BottomRightCorner_CheckBox.CheckedChanged += UpdateUITheme;
            // 
            // DarkMode_CheckBox
            // 
            DarkMode_CheckBox.AutoSize = true;
            DarkMode_CheckBox.Checked = true;
            DarkMode_CheckBox.CheckState = CheckState.Checked;
            DarkMode_CheckBox.Location = new Point(214, 75);
            DarkMode_CheckBox.Name = "DarkMode_CheckBox";
            DarkMode_CheckBox.Size = new Size(84, 19);
            DarkMode_CheckBox.TabIndex = 5;
            DarkMode_CheckBox.Text = "Dark Mode";
            DarkMode_CheckBox.UseVisualStyleBackColor = true;
            DarkMode_CheckBox.CheckedChanged += UpdateUITheme;
            // 
            // ShowIcon_CheckBox
            // 
            ShowIcon_CheckBox.AutoSize = true;
            ShowIcon_CheckBox.Checked = true;
            ShowIcon_CheckBox.CheckState = CheckState.Checked;
            ShowIcon_CheckBox.Location = new Point(214, 100);
            ShowIcon_CheckBox.Name = "ShowIcon_CheckBox";
            ShowIcon_CheckBox.Size = new Size(81, 19);
            ShowIcon_CheckBox.TabIndex = 6;
            ShowIcon_CheckBox.Text = "Show Icon";
            ShowIcon_CheckBox.UseVisualStyleBackColor = true;
            ShowIcon_CheckBox.CheckedChanged += UpdateUITheme;
            // 
            // Settings_Label
            // 
            Settings_Label.AutoSize = true;
            Settings_Label.Location = new Point(210, 57);
            Settings_Label.Name = "Settings_Label";
            Settings_Label.Size = new Size(52, 15);
            Settings_Label.TabIndex = 7;
            Settings_Label.Text = "Settings:";
            // 
            // CornerRadius_Label
            // 
            CornerRadius_Label.AutoSize = true;
            CornerRadius_Label.Location = new Point(14, 9);
            CornerRadius_Label.Name = "CornerRadius_Label";
            CornerRadius_Label.Size = new Size(84, 15);
            CornerRadius_Label.TabIndex = 8;
            CornerRadius_Label.Text = "Corner Radius:";
            // 
            // TitleBarHeight_Label
            // 
            TitleBarHeight_Label.AutoSize = true;
            TitleBarHeight_Label.Location = new Point(111, 9);
            TitleBarHeight_Label.Name = "TitleBarHeight_Label";
            TitleBarHeight_Label.Size = new Size(91, 15);
            TitleBarHeight_Label.TabIndex = 9;
            TitleBarHeight_Label.Text = "Title Bar Height:";
            // 
            // BorderSize_Label
            // 
            BorderSize_Label.AutoSize = true;
            BorderSize_Label.Location = new Point(208, 9);
            BorderSize_Label.Name = "BorderSize_Label";
            BorderSize_Label.Size = new Size(68, 15);
            BorderSize_Label.TabIndex = 10;
            BorderSize_Label.Text = "Border Size:";
            // 
            // CornerRadius_NumericUpDown
            // 
            CornerRadius_NumericUpDown.Location = new Point(17, 27);
            CornerRadius_NumericUpDown.Name = "CornerRadius_NumericUpDown";
            CornerRadius_NumericUpDown.Size = new Size(87, 23);
            CornerRadius_NumericUpDown.TabIndex = 11;
            CornerRadius_NumericUpDown.Value = new decimal(new int[] { 12, 0, 0, 0 });
            CornerRadius_NumericUpDown.ValueChanged += UpdateUITheme;
            // 
            // TitleBarHeight_NumericUpDown
            // 
            TitleBarHeight_NumericUpDown.Location = new Point(114, 27);
            TitleBarHeight_NumericUpDown.Minimum = new decimal(new int[] { 30, 0, 0, 0 });
            TitleBarHeight_NumericUpDown.Name = "TitleBarHeight_NumericUpDown";
            TitleBarHeight_NumericUpDown.Size = new Size(87, 23);
            TitleBarHeight_NumericUpDown.TabIndex = 12;
            TitleBarHeight_NumericUpDown.Value = new decimal(new int[] { 30, 0, 0, 0 });
            TitleBarHeight_NumericUpDown.ValueChanged += UpdateUITheme;
            // 
            // BorderSize_NumericUpDown
            // 
            BorderSize_NumericUpDown.Location = new Point(211, 27);
            BorderSize_NumericUpDown.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            BorderSize_NumericUpDown.Name = "BorderSize_NumericUpDown";
            BorderSize_NumericUpDown.Size = new Size(87, 23);
            BorderSize_NumericUpDown.TabIndex = 13;
            BorderSize_NumericUpDown.ValueChanged += UpdateUITheme;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.Control;
            ClientSize = new Size(314, 131);
            Controls.Add(BorderSize_NumericUpDown);
            Controls.Add(TitleBarHeight_NumericUpDown);
            Controls.Add(CornerRadius_NumericUpDown);
            Controls.Add(BorderSize_Label);
            Controls.Add(TitleBarHeight_Label);
            Controls.Add(CornerRadius_Label);
            Controls.Add(Settings_Label);
            Controls.Add(ShowIcon_CheckBox);
            Controls.Add(DarkMode_CheckBox);
            Controls.Add(BottomRightCorner_CheckBox);
            Controls.Add(BottomLeftCorner_CheckBox);
            Controls.Add(TopRightCorner_CheckBox);
            Controls.Add(TopLeftCorner_CheckBox);
            Controls.Add(RoundedCorners_Label);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "Rounded Forms Example";
            HelpButtonClicked += MainForm_HelpButtonClicked;
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)CornerRadius_NumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)TitleBarHeight_NumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)BorderSize_NumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BottomRight_Button;
        private Button BottomLeft_Button;
        private Button TopRight_Button;
        private Button TopLeft_Button;
        private Label RoundedCorners_Label;
        private CheckBox TopLeftCorner_CheckBox;
        private CheckBox TopRightCorner_CheckBox;
        private CheckBox BottomLeftCorner_CheckBox;
        private CheckBox BottomRightCorner_CheckBox;
        private CheckBox DarkMode_CheckBox;
        private CheckBox ShowIcon_CheckBox;
        private Label Settings_Label;
        private Label CornerRadius_Label;
        private Label TitleBarHeight_Label;
        private Label BorderSize_Label;
        private NumericUpDown CornerRadius_NumericUpDown;
        private NumericUpDown TitleBarHeight_NumericUpDown;
        private NumericUpDown BorderSize_NumericUpDown;
    }
}
