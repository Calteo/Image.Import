using System;
using System.Diagnostics;
using System.IO;
using Toolbox.Xml.Serialization;

namespace Image.Import
{
    /// <summary>
    /// The state of the last import
    /// </summary>
    class ImportState
    {
        public DateTime Timestamp { get; set; }
        public bool Overwrite { get; set; }
        public bool OnlyAfterLastImport { get; set; }
        public string ProfileName { get; set; }

        private const string Filename = "Image.Import.State.xml";

        internal bool Save(string folder)
        {
            var filename = Path.Combine(folder, Filename);
            try
            {
                var formatter = new XmlFormatter<ImportState>();
                formatter.Serialize(this, filename);
                return true;
            }
            catch (Exception exeption)
            {
                Trace.WriteLine($"failed - {filename} - {exeption.Message}", "state save");
            }
            return false;
        }

        internal static ImportState Load(string folder)
        {
            var filename = Path.Combine(folder, Filename);
            try
            {
                if (File.Exists(filename))
                {
                    var formatter = new XmlFormatter<ImportState>();
                    return formatter.Deserialize(filename);
                }                
            }
            catch (Exception exeption)
            {
                Trace.WriteLine($"failed - {filename} - {exeption.Message}", "state load");                
            }
            return null;
        }
    }
}
