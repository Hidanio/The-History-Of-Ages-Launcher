using System;
using System.Collections.Generic;
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
        public string PathRegedit;

        public void CreateRegeditKey(string PathRegedit)
        {
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey SoftwareKey = currentUserKey.OpenSubKey("Software", true);
            RegistryKey SubSoftLauncherKey = SoftwareKey.CreateSubKey("ThoaLauncher");

            SubSoftLauncherKey.SetValue("PathEXE", PathRegedit);
            SubSoftLauncherKey.Close();
            SoftwareKey.Close();
        }

        public string GetRegeditPathExeValue()
        {
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey SoftwareKey = currentUserKey.OpenSubKey("Software", true);
            RegistryKey SubSoftLauncherKey = SoftwareKey.OpenSubKey("ThoaLauncher",true);

            string Path = SubSoftLauncherKey.GetValue("PathEXE").ToString();

            SubSoftLauncherKey.Close();
            SoftwareKey.Close();
            return Path;
        }

    }
}
