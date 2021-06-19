using System;
using System.Windows.Forms;

namespace Liver
{
    public partial class Settings : Form
    {
        private readonly ISettings _settings;

        public Settings(ISettings settings)
        {
            _settings = settings;
            InitializeComponent();
            UpdateLabels();
        }

        void UpdateLabels()
        {
            collageColorPanel.BackColor = _settings.CollageColor;
            frameColorPanel.BackColor = _settings.FrameColor;
            perPageLabel.Text = _settings.PerPage + "";
        }

        private void frameColorButton_Click(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            dialog.Color = _settings.FrameColor;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _settings.FrameColor = dialog.Color;
                UpdateLabels();
            }
        }

        private void collageColorButton_Click(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            dialog.Color = _settings.CollageColor;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _settings.CollageColor = dialog.Color;
                UpdateLabels();
            }
        }

        private void perPageMinus_Click(object sender, EventArgs e)
        {
            _settings.PerPage--;
            UpdateLabels();
        }

        private void perPagePlus_Click(object sender, EventArgs e)
        {
            _settings.PerPage++;
            UpdateLabels();
        }
    }
}