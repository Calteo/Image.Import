using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Image.Import
{
    internal partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();

            dataGridView.AutoGenerateColumns = false;
        }
        
        public ProfileContainer ProfileContainer { get; set; }

        private void ProfileFormLoad(object sender, EventArgs e)
        {
            
            ProfileContainer.Profiles = new BindingList<Profile>(ProfileContainer.Profiles.OrderBy(p => p.Name).ToList());
            dataGridView.DataSource = ProfileContainer.Profiles;
        }

        private void ButtonOkClick(object sender, EventArgs e)
        {
            dataGridView.CancelEdit();
            ProfileContainer.Save();
        }
    }
}
