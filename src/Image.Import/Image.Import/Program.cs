using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toolbox.CommandLine;

namespace Image.Import
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static int Main(string[] args)
        {
            var parser = Parser.Create<ImportOptions>();
            var result = parser.Parse(args);

            var rc = result
               .OnError(r =>
               {
                   MessageBox.Show(r.Text, "Image Import", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return -1;
               })
               .OnHelp(r =>
               {
                   MessageBox.Show(r.GetHelpText(), "Image Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   return 1;
               })
               .On<ImportOptions>(o =>
               {
                   Application.SetHighDpiMode(HighDpiMode.SystemAware);
                   Application.EnableVisualStyles();
                   Application.SetCompatibleTextRenderingDefault(false);
                   Application.Run(new ImportForm { Options = o });
                   return 0;
               })
               .Return;

            return rc;
        }
    }
}
