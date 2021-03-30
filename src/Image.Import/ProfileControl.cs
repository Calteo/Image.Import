using System;
using System.Windows.Forms;

namespace Image.Import
{
    internal partial class ProfileControl : UserControl
    {        
        public ProfileControl()
        {
            InitializeComponent();
        }

        private Profile _profile;
        public Profile Profile 
        { 
            get => _profile;
            set 
            { 
                _profile = value;

                textBoxName.Text = _profile?.Name;
                textBoxImageExtensions.Text = _profile?.ImageExtensions;
                textBoxImageExpression.Text = _profile?.ImageExpression;
                textBoxRawExtensions.Text = _profile?.RawExtensions;
                textBoxRawExpression.Text = _profile?.RawExpression;
                textBoxVideoExtensions.Text = _profile?.VideoExtensions;
                textBoxVideoExpression.Text = _profile?.VideoExpression;

                textBoxName.Enabled = _profile != null;
            }
        }

        private void TextBoxNameTextChanged(object sender, EventArgs e)
        {
            if (Profile != null) Profile.Name = textBoxName.Text;
        }

        private void TextBoxImageExtensionsTextChanged(object sender, EventArgs e)
        {
            if (Profile != null) Profile.ImageExtensions = textBoxImageExtensions.Text;
        }

        private void TextBoxImageExpressionTextChanged(object sender, EventArgs e)
        {
            if (Profile != null) Profile.ImageExpression = textBoxImageExpression.Text;
        }

        private void TextBoxRawExtensionsTextChanged(object sender, EventArgs e)
        {
            if (Profile != null) Profile.RawExtensions = textBoxRawExtensions.Text;
        }

        private void TextBoxRawExpressionTextChanged(object sender, EventArgs e)
        {
            if (Profile != null) Profile.RawExpression = textBoxRawExpression.Text;
        }

        private void TextBoxVideoExtensionsTextChanged(object sender, EventArgs e)
        {
            if (Profile != null) Profile.VideoExtensions = textBoxVideoExtensions.Text;
        }

        private void TextBoxVideoExpressionTextChanged(object sender, EventArgs e)
        {
            if (Profile != null) Profile.VideoExpression = textBoxVideoExpression.Text;
        }
    }
}
