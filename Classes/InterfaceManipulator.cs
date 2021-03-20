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
        //TODO: доделать копирование загрузочного экрана
     public void ChangeGameInterface(string InterfaceChoice)
     {
         var Path = GetGamePath();
         string[] GameIterfaces =
         {
             Path + "\\Alternative Interface\\Angmar\\__THOA_Art_Angmar.big",
             Path + "\\Alternative Interface\\BFME\\__THOA_Art_BFME.big",
             Path + "\\Alternative Interface\\BFME 2\\__THOA_Art_BFME2.big",
             Path + "\\Alternative Interface\\Dwarf\\__THOA_Art_Dwarf.big",
             Path + "\\Alternative Interface\\Elf\\__THOA_Art_Elf.big",
             Path + "\\Alternative Interface\\Rohan\\__THOA_Art_Rohan.big",
             Path + "\\Alternative Interface\\ROTWK\\__THOA_Art_ROTWK.big",
             Path + "\\Alternative Interface\\THOA\\__THOA_Art_THOA.big"
         };

         string[] FilesName =
         {
             "__THOA_Art_Angmar.big", "__THOA_Art_BFME.big", "__THOA_Art_BFME2.big",
             "__THOA_Art_Dwarf.big", "__THOA_Art_Elf.big", "__THOA_Art_Rohan.big",
             "__THOA_Art_ROTWK.big","__THOA_Art_THOA.big"
         };
         DeleteFiles(FilesName);
         switch (InterfaceChoice)
         {
             case "Angmar":
                 File.Copy(GameIterfaces[0], Path + "\\" + "__THOA_Art_Angmar.big", true);
                 break;
             case "BFME":
                 File.Copy(GameIterfaces[1], Path + "\\" + "__THOA_Art_BFME.big", true);
                 break;
             case "BFME 2":
                 File.Copy(GameIterfaces[2], Path + "\\" + "__THOA_Art_BFME2.big", true);
                 break;
             case "Dwarf":
                 File.Copy(GameIterfaces[3], Path + "\\" + "__THOA_Art_Dwarf.big", true);
                 break;
             case "Elf":
                 File.Copy(GameIterfaces[4], Path + "\\" + "__THOA_Art_Elf.big", true);
                 break;
             case "Rohan":
                 File.Copy(GameIterfaces[5], Path + "\\" + "__THOA_Art_Rohan.big", true);
                 break;
             case "ROTWK":
                 File.Copy(GameIterfaces[6], Path + "\\" + "__THOA_Art_ROTWK.big", true);
                 break;
             case "THOA":
                 File.Copy(GameIterfaces[7], Path + "\\" + "__THOA_Art_THOA.big", true);
                 break;
         }
     }
        public void ChangePalantir(string PalantirChoice)
        {
            var Path = GetGamePath();
            string[] Palantirs = {
                Path+ "\\Alternative Interface\\Palantir_Alternative\\__Palantir.big",
                Path+ "\\Alternative Interface\\Palantir_Alternative\\__Palantir_THOA.big", 
                Path+ "\\Alternative Interface\\Palantir_Alternative\\__Palantir_THOA_Ice.big",
                Path+ "\\Alternative Interface\\Palantir_Alternative\\__PALAntirr_History .big"
            };
            DeleteFiles(Directory.GetFiles(GetGamePath()+ "\\Alternative Interface\\Palantir_Alternative"));
            switch (PalantirChoice)
            {
                case "Default Palantir": 
                    File.Copy(Palantirs[0], Path + "\\" + "__Palantir.big", true);
                    break;
                case "THOA Palantir":
                    File.Copy(Palantirs[1], Path + "\\" + "__Palantir_THOA.big", true);
                    break;
                case "THOA Winter":
                    File.Copy(Palantirs[2], Path + "\\" + "__Palantir_THOA_Ice.big", true);
                    break;
                case "THOA History":
                    File.Copy(Palantirs[3], Path + "\\" + "__PALAntirr_History .big", true);
                    break;
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
