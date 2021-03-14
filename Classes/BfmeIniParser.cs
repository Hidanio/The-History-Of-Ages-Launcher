using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_History_Of_Ages_Launcher.Classes
{
  public  class BfmeIniParser : Launcher
    {

        public void SetParsedIni(Dictionary<string, string> parsed)
        {
            _parsedIni = parsed;
        }

        public Dictionary<string, string> ParserIni()
        {
            var lines = File.ReadAllLines(GetPathOption());
            var ParseRes = new Dictionary<string, string>();

            foreach (var line in lines)
            {
                if (line == "")
                {
                    continue;
                }
                var lineParts = line.Split('=');
                ParseRes[lineParts[0].Trim()] = lineParts[1].Trim();
            }
            return ParseRes;
        }

        private void WriteIniFile()
        {
            using (var sw = new StreamWriter(GetPathOption(), false, Encoding.Default))
            {
                foreach (var item in _parsedIni)
                {
                    sw.WriteLine(item.Key + " = " + item.Value);
                }
            }
        }

        public void EditIniOption(string option, string newValue)
        {
            _parsedIni[option] = newValue;
            WriteIniFile();
        }
        private Dictionary<string, string> _parsedIni;
    }
}
