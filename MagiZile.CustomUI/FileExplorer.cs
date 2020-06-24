using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using Microsoft.VisualBasic.FileIO;


namespace MagiZile.CustomUI
{
    /* Class  :FileExplorer
     * Author : Chandana Subasinghe
     * Date   : 10/03/2006
     * Description : This class use to create the tree view and load 
     *               directories and files in to the tree
     *          
     */
    public class FileExplorer
    {
        public FileExplorer()
        {

        }

        /* Method :CreateTree
         * Author : Chandana Subasinghe
         * Date   : 10/03/2006
         * Description : This is use to create and build the tree
         *          
         */

        public bool CreateTree(TreeView treeView)
        {
            bool returnValue = false;
                 
            try
            {
                // Create Desktop
                TreeNode desktop = new TreeNode();
                desktop.ImageIndex = 1;
                desktop.Text = "Desktop";
                desktop.Tag = "Desktop";
                desktop.Nodes.Add("");
                treeView.Nodes.Add(desktop);
                // Get driveInfo
                foreach (DriveInfo drv in DriveInfo.GetDrives())
                {
                    
                    TreeNode fChild = new TreeNode();
                    if (drv.DriveType == DriveType.CDRom)
                    {
                        fChild.ImageIndex = 2;
                        fChild.SelectedImageIndex = 2;
                    }
                    else if (drv.DriveType == DriveType.Fixed)
                    {
                        fChild.ImageIndex = 2;
                        fChild.SelectedImageIndex = 2;
                    }
                    fChild.Text = drv.Name;
                    fChild.Nodes.Add("");
                    treeView.Nodes.Add(fChild);
                    returnValue = true;
                }

            }
            catch
            {
                returnValue = false;
            }
            return returnValue;
            
        }

        /* Method :EnumerateDirectory
         * Author : Chandana Subasinghe
         * Date   : 10/03/2006
         * Description : This is use to Enumerate directories and files
         *          
         */
        public TreeNode EnumerateDirectory(TreeNode parentNode)
        {  
            try
            {
                DirectoryInfo rootDir;

                // To fill Desktop
                Char [] arr={'\\'};
                string [] nameList=parentNode.FullPath.Split(arr);
                string path = "";

                if (nameList.GetValue(0).ToString() == "Desktop")
                {
                    path = SpecialDirectories.Desktop+"\\";

                    for (int i = 1; i < nameList.Length; i++)
                    {
                        path = path + nameList[i] + "\\";
                    }

                    rootDir = new DirectoryInfo(path);
                }
             // for other Directories
                else
                {
                   
                    rootDir = new DirectoryInfo(parentNode.FullPath + "\\");
                }
                
                parentNode.Nodes[0].Remove();
                foreach (DirectoryInfo dir in rootDir.GetDirectories())
                {
                    
                    TreeNode node = new TreeNode();
                    node.ImageIndex = 1;
                    node.Text = dir.Name;
                    node.Nodes.Add("");
                    parentNode.Nodes.Add(node);
                }
            }

            catch
            {
                //TODO : 
            }
           
            return parentNode;
        }
    }
}
