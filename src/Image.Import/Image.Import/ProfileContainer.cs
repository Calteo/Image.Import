using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using Toolbox.ComponentModel;
using Toolbox.Xml.Serialization;

namespace Image.Import
{
    class ProfileContainer
    {
        public BindingList<Profile> Profiles { get; set; } = new BindingList<Profile>();

        public static string GetFilename()
        {
            var folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Calteo");
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            return Path.Combine(folder, "Image.Import.xml");
        }

        public static ProfileContainer Get()
        {
            var filename = GetFilename();
            if (File.Exists(filename))
            {
                var formatter = new XmlFormatter<ProfileContainer>();
                return formatter.Deserialize(filename);
            }
            else
            {
                return new ProfileContainer();
            }
        }

        public void Save()
        {
            var formatter = new XmlFormatter<ProfileContainer>();
            formatter.Serialize(this, GetFilename());
        }

        internal ProfileContainer Clone()
        {
            var formatter = new XmlFormatter<ProfileContainer>();
            var stream = new MemoryStream();
            formatter.Serialize(this, stream);
            stream.Position = 0;
            return formatter.Deserialize(stream);
        }
    }
}
