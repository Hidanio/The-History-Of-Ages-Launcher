using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

public enum Palantir
{
    Mordor,
    Isengard,
    Rohan,
    Goblins
}
public enum GameInterface
{
    MordorInterface,
    IsengardInterface,
    RohanInterface,
    GoblinsInterface
}

namespace The_History_Of_Ages_Launcher.Classes
{

    public  class Launcher
    {
        public string GetPathOption()
        {
            return _pathOption;
        }

        public void SetPathRegedit(string value)
        {
            _pathRegedit = value;
            var currentUserKey = Registry.CurrentUser;
            var SoftwareKey = currentUserKey.OpenSubKey("Software", true);
            var SubSoftLauncherKey = SoftwareKey?.OpenSubKey("ThoaLauncher", true);
            if (SubSoftLauncherKey != null)
            {
                SubSoftLauncherKey.SetValue("PathEXE", _pathRegedit);
                SubSoftLauncherKey.Close();
                SoftwareKey.Close();
            }


        }
        public string GetPathRegedit()
        {
            return _pathRegedit;
        }
        public void CreateRegeditKey(string pathRegedit, string fieldName)
        {
            var currentUserKey = Registry.CurrentUser;
            var SoftwareKey = currentUserKey.OpenSubKey("Software", true);
                    var SubSoftLauncherKey = SoftwareKey?.CreateSubKey("ThoaLauncher");

                    if (SubSoftLauncherKey != null)
                    {
                        SubSoftLauncherKey.SetValue(fieldName, pathRegedit);
                        SubSoftLauncherKey.Close();
                        SoftwareKey?.Close();
                    }

        }

        public string GetRegeditValue(string regValue)
        {
            var currentUserKey = Registry.CurrentUser;
            var SoftwareKey = currentUserKey.OpenSubKey("Software", true);
            var SubSoftLauncherKey = SoftwareKey?.OpenSubKey("ThoaLauncher",true);
            if (SubSoftLauncherKey == null)
            {
                SubSoftLauncherKey.Close();
                SoftwareKey.Close();
                return null;
            }

            var Path = SubSoftLauncherKey.GetValue(regValue).ToString();

            return Path;

        }


        private string _pathRegedit;
        private string _pathOption = Path.Combine(Environment.GetFolderPath(
        Environment.SpecialFolder.ApplicationData), "My The History Of Ages™ Mod Files\\Options.ini");
    }
}
