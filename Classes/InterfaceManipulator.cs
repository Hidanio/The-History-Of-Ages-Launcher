using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace The_History_Of_Ages_Launcher.Classes
{
   public class InterfaceManipulator
   {
     public  string GetGamePath()
        {
            var currentUserKey = Registry.CurrentUser;
            var SoftwareKey = currentUserKey.OpenSubKey("Software", true);
            var SubSoftLauncherKey = SoftwareKey?.OpenSubKey("ThoaLauncher", true);

            var Path = SubSoftLauncherKey.GetValue("PathEXE").ToString();

            SubSoftLauncherKey.Close();
            SoftwareKey.Close();

            var length = Path.Length-1;
            for (var i = length; i > 0; --i)
            {
                if (Path[i] == '\\')
                {
                    Path = Path.Substring(0, i);
                    return Path;
                }
            }

            return null;
        }

     public string[] GetFilesInDir(string Path)
     {
         return  Directory.GetFiles(Path);
     }
     public void ChangeLanguage(bool Russian)
     {
         string PathTo = GetGamePath();
         if (Russian)
         {
             string PathFrom = GetGamePath() + "\\language\\ru";
             string[] FilesToCopy = Directory.GetFiles(PathFrom);

             string[] Temp = Directory.GetFiles(PathFrom);
             DeleteFiles(Directory.GetFiles(GetGamePath() + "\\language\\en"));


             string[] FilesToCopyNames = GetFilesNames(Temp);

             for (var i = 0; i < FilesToCopy.Length; ++i)
             {
                 File.Copy(FilesToCopy[i], PathTo + "\\" + FilesToCopyNames[i], true);
             }

         }
         else
         {
             string PathFrom = GetGamePath() + "\\language\\en";
             string[] FilesToCopy = Directory.GetFiles(PathFrom);

             string[] Temp = Directory.GetFiles(PathFrom);
             DeleteFiles(Directory.GetFiles(GetGamePath() + "\\language\\ru"));

             string[] FilesToCopyNames = GetFilesNames(Temp);

             for (var i = 0; i < FilesToCopy.Length; ++i)
             {
                 File.Copy(FilesToCopy[i], PathTo + "\\" + FilesToCopyNames[i], true);
             }
         }
     }

     public string[] GetFilesNames(string[] FilesWithPath)
     {
         for (var i = 0; i < FilesWithPath.Length; ++i)
         {
             for (var j = FilesWithPath[i].Length - 1; j > 0; --j)
             {
                 if (FilesWithPath[i][j] == '\\')
                 {
                     FilesWithPath[i] = FilesWithPath[i].Substring(j + 1);
                     break;

                 }
             }

         }
         return FilesWithPath;

     }
     public void DeleteFiles(string[] FilesToDel)
     {
            
            string[] FilesInDirNames = GetFilesNames(Directory.GetFiles(GetGamePath()));
            string[] FilesForDelNames = GetFilesNames(FilesToDel);


            var length = FilesInDirNames.Length;

         for (var i = 0; i < length; ++i)
         {
             for (var j=0; j < FilesToDel.Length; ++j)
             {
                 if (FilesInDirNames[i] == FilesForDelNames[j])
                 {
                     File.Delete(GetGamePath()+"\\"+ FilesForDelNames[j]);
                 }
             }
         }

     }
        public void SetGamePath(string Path)
        {
            _GamePath = Path;
        }
       private string _GamePath;
   }
}
