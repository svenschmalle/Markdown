using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Markdown
{
    internal class functions
    {
        internal string getSavePath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MarkdownEditor");
        }

        internal void makeSavePath()
        {
            if (!Directory.Exists(getSavePath()))
            {
                Directory.CreateDirectory(getSavePath());
            }
        }

        internal string getSaveFile(string AktuellerDateiname)
        {
            string SaveDateiBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(AktuellerDateiname));
            string SaveFile = Path.Combine(getSavePath(), SaveDateiBase64);
            return SaveFile;
        }

        internal string getResourceFile(string Filename)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            using (StreamReader textStreamReader = new StreamReader(asm.GetManifestResourceStream(Filename)))
            {
                return textStreamReader.ReadToEnd();
            }
        }
    }
}
