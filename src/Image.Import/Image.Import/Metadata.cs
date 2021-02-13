using System;
using System.IO;
using System.Windows.Media.Imaging;

namespace Image.Import
{
    class Metadata
    {
        public Metadata(FileInfo file)
        {
            using (var fs = new FileStream(file.FullName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                var frame = BitmapFrame.Create(fs);
                var metadata = (BitmapMetadata)frame.Metadata;

                DateTaken = DateTime.Parse(metadata.DateTaken);
            }
        }

        public DateTime DateTaken { get; }
    }
}
