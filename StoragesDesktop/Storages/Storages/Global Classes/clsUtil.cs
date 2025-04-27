using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storages.Global_Classes
{
    public  class clsUtil
    {


        public static string GenerateGUID()
        {

            Guid NewGuid = Guid.NewGuid();
            return NewGuid.ToString();

        }

        public static bool CreateFolderIfDoesNotExist(string FolderPath)
        {

            if (!Directory.Exists(FolderPath))
            {
                try
                {
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error creating folder: " + ex.Message);

                    return false;
                }

            }

            return true;



        }


        public static string ReplaceFileNameWithGUID(string sourceFile)
        {

            string Filename = sourceFile;
            FileInfo FileInfo = new FileInfo(Filename);
            string extn = FileInfo.Extension;
            return GenerateGUID() + extn;

        }

        public static bool CopyImageToProjectImagesFolder(ref string sourceFile)
        {
            string DistinationFolder = @"C:\DVLD-People-Images\";
            if (!CreateFolderIfDoesNotExist(DistinationFolder))
            {

                return false;
            }
            string DistnationFile = DistinationFolder + ReplaceFileNameWithGUID(sourceFile);
            try
            {
                File.Copy(sourceFile, DistnationFile, true);

            }
            catch (IOException iox)
            {

                Console.WriteLine(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            sourceFile = DistnationFile;
            return true;

        }



    }
}
