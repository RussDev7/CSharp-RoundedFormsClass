using RoundedFormsExample.Properties;
using System.ComponentModel;
using System.Configuration;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace RoundedFormsExample
{
    public partial class MainForm : Form
    {
        // Form initialization.
        private CustomFormStyler _formThemeStyler;
        public MainForm()
        {
            InitializeComponent();
            Load += (_, __) => _formThemeStyler = this.ApplyTheme(); // Load the forms theme.
        }

        #region Fields

        // Fields.
        private bool _initialized = false;

        #endregion

        #region Form Load

        private void MainForm_Load(object sender, EventArgs e)
        {
            #region Set Form Theme

            // Dark / light:
            DarkMode_CheckBox.Checked          = (Settings.Default.UITheme == ThemeMode.Dark);

            // Corners:
            Corner saved                       = Settings.Default.UICorners;
            TopLeftCorner_CheckBox.Checked     = saved.HasFlag(Corner.TopLeft);
            TopRightCorner_CheckBox.Checked    = saved.HasFlag(Corner.TopRight);
            BottomLeftCorner_CheckBox.Checked  = saved.HasFlag(Corner.BottomLeft);
            BottomRightCorner_CheckBox.Checked = saved.HasFlag(Corner.BottomRight);

            // Everything else:
            CornerRadius_NumericUpDown.Value   = Settings.Default.UICornerRadius;
            TitleBarHeight_NumericUpDown.Value = Settings.Default.UITitleBarHeight;
            BorderSize_NumericUpDown.Value     = Settings.Default.UIBorderSize;
            ShowIcon_CheckBox.Checked          = Settings.Default.UIShowIcon;

            // Refresh the form UI.
            FormStylingExtensions.RefreshAllThemes();

            // Change the form fore-color settings based on the theme.
            if (Properties.Settings.Default.UITheme == ThemeMode.Dark)
                this.ForeColor = Color.White;
            else
                this.ForeColor = Color.Black;
            #endregion

            #region Form Initialized

            // Now that the form is fully loaded and at the restored spot, turn saving back on.
            _initialized = true;
            #endregion
        }
        #endregion

        #region Form Closing

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Optional: Save settings upon closing.
            try
            {
                Properties.Settings.Default.Save();
            }
            catch (ConfigurationErrorsException)
            {
                // Show path for quick manual cleanup.
                MessageBox.Show(
                    $"Failed to save settings.",
                    $"Settings Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                // Optionally cancel close so user doesn’t lose data.
                // e.Cancel = true;
            }

            // Ensure all threads are terminated.
            Application.ExitThread();
        }
        #endregion

        #region Help Button Demo

        private void MainForm_HelpButtonClicked(object? sender, CancelEventArgs e)
        {
            // In a real app you might open an in‑app help panel or
            // navigate to a FAQ page.
            MessageBox.Show("Help button clicked.", "Help Demo");

            // Prevent WinForms from trying to open .chm / HelpProvider.
            e.Cancel = true;
        }
        #endregion

        #region Event Handelers

        /// <summary>
        /// Raised when the form needs to discard its custom chrome
        /// and rebuild itself with the native window frame.
        /// </summary>
        public event EventHandler RestoreNativeRequested;

        /// <summary>
        /// Helper to raise <see cref="RestoreNativeRequested"/> safely.
        /// Call this inside the main form when you want to swap out.
        /// </summary>
        public void OnRestoreNativeRequested()
            => RestoreNativeRequested?.Invoke(this, EventArgs.Empty);

        #endregion

        #region Main UI Theme Controls

        // Global for theme control updating.
        public void UpdateUITheme(object sender, EventArgs e)
        {
            // Ensure the form is initialized before running.
            if (!_initialized) return;

            // Update settings.
            Properties.Settings.Default.UITheme          = DarkMode_CheckBox.Checked ? ThemeMode.Dark : ThemeMode.Light;
            Properties.Settings.Default.UICorners        = SelectedCorners;
            Properties.Settings.Default.UICornerRadius   = (int)CornerRadius_NumericUpDown.Value;
            Properties.Settings.Default.UITitleBarHeight = (int)TitleBarHeight_NumericUpDown.Value;
            Properties.Settings.Default.UIBorderSize     = (int)BorderSize_NumericUpDown.Value;
            Properties.Settings.Default.UIShowIcon       = ShowIcon_CheckBox.Checked;

            // Refresh the form UI.
            FormStylingExtensions.RefreshAllThemes();

            // Change the form fore-color settings based on the theme.
            if (Properties.Settings.Default.UITheme == ThemeMode.Dark)
                this.ForeColor = Color.White;
            else
                this.ForeColor = Color.Black;
        }

        /// <summary>
        /// Bit-mask of corner check-boxes.
        /// </summary>
        public Corner SelectedCorners
        {
            get
            {
                Corner c = Corner.None;

                // Optional selectors.
                /*
                if (NoCorners_RadioButton.Checked)      return Corner.None;
                if (AllCorners_RadioButton.Checked)     return Corner.All;
                */

                if (TopLeftCorner_CheckBox.Checked)     c |= Corner.TopLeft;
                if (TopRightCorner_CheckBox.Checked)    c |= Corner.TopRight;
                if (BottomLeftCorner_CheckBox.Checked)  c |= Corner.BottomLeft;
                if (BottomRightCorner_CheckBox.Checked) c |= Corner.BottomRight;
                return c;
            }
        }
        #endregion
    }
}
