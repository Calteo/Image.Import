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
        }
        
        public ProfileContainer ProfileContainer { get; set; }

        private void ProfileFormLoad(object sender, EventArgs e)
        {           
            ProfileContainer.Profiles = new BindingList<Profile>(ProfileContainer.Profiles.OrderBy(p => p.Name).ToList());
            listBoxProfiles.DataSource = ProfileContainer.Profiles;
            listBoxProfiles.DisplayMember = "Name";
        }

        private void ButtonOkClick(object sender, EventArgs e)
        {
            ProfileContainer.Save();
        }

        private void ButtonNewClick(object sender, EventArgs e)
        {
            ProfileContainer.Profiles.Add(new Profile { Name = "New Profile" });
        }

        private void ListBoxProfilesSelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProfiles.SelectedItems.Count == 1)
            {
                profileControl.Profile = (Profile)listBoxProfiles.SelectedItem;
            }
            else
            {
                profileControl.Profile = null;
            }

            buttonDelete.Enabled = listBoxProfiles.SelectedItems.Count != 0;
        }

        private void ButtonDeleteClick(object sender, EventArgs e)
        {
            var profiles = listBoxProfiles.SelectedItems.Cast<Profile>().ToArray();
            foreach (var profile in profiles)
            {
                ProfileContainer.Profiles.Remove(profile);
            }
        }
    }
}
