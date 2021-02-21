using Toolbox.CommandLine;

namespace Image.Import
{
    class ImportOptions
    {
        [Option("source"), Position(0)]
        public string Source { get; set; }
    }
}
