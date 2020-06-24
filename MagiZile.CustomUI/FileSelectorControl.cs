using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagiZile.CustomUI
{
    public partial class FileSelectorControl : UserControl
    {
        public FileSelectorControl()
        {
            InitializeComponent();
        }

        int i = 0;
        FileExplorer fe = new FileExplorer();
        List<string> FolderHistory = new List<string>();
        int historyIndex = 0;
        public string selection = "";
        string CompletePath = @"C:\";
        string LastPath = "";
        bool Failed = false;
        string[] filter = { "*.*" };
        public string startingPath = @"C:\";
        public enum FileMode { Open, OpenReadOnly, Save };
        public FileMode mode = FileMode.Open;
        public bool limitDirectoryTree = false;

        /// <summary>
        /// Returns a string representing the size of the specified file and the units.
        /// </summary>
        /// <param name="path">The file to get the size of.</param>
        /// <returns>The size number with the units.</returns>
        string GetFileSize(string path)
        {
            FileInfo objFile = new FileInfo(path);
            string size = "";
            double length = Convert.ToDouble(objFile.Length);
            if (length >= 1024.0 && length <= 1048576.0)
            {
                size = Math.Round((length / 1024), 1, MidpointRounding.ToEven).ToString() + " KB";
            }
            else if (length >= 1048576.0 && length <= 1073741824)
            {
                size = Math.Round((length / 1048576), 1, MidpointRounding.ToEven).ToString() + " MB";
            }
            else if (length >= 1073741824.0)
            {
                size = Math.Round((length / 1073741824), 1, MidpointRounding.ToEven).ToString() + " GB";
            }
            else
            {
                size = length.ToString() + " bytes";
            }
            return size;
        }

        public FileMode Mode
        {
            get
            {
                return mode;
            }
            set
            {
                mode = value;
            }
        }

        void LoadDirectoryAsNode(TreeNode node, string dir)
        {
            tvwFolders.Nodes.Add(node);
            foreach (string subdir in Directory.GetDirectories(dir))
            {
                node.Nodes.Add(subdir);
                if (Directory.GetDirectories(dir).Length != 0)
                {
                    LoadDirectoryAsNode(node, subdir);
                }
            }
        }

        public bool LimitDirectoryTree
        {
            get
            {
                return limitDirectoryTree;
            }
            set
            {
                limitDirectoryTree = value;
                if (limitDirectoryTree)
                {
                    TreeNode objNode = new TreeNode(Path.GetFileName(StartingPath));
                    objNode.ImageIndex = 4;
                    tvwFolders.Nodes.Clear();
                    LoadDirectoryAsNode(objNode, StartingPath);
                }
                else
                {
                    fe.CreateTree(tvwFolders);
                }
            }
        }

        /// <summary>
        /// The file filter for the file browser.
        /// </summary>
        public string[] FileFilter
        {
            get
            {
                return filter;
            }
            set
            {
                filter = value;
            }
        }

        /// <summary>
        /// The item the user selected.
        /// </summary>
        public string Selection
        {
            get
            {
                return selection;
            }
        }

        /// <summary>
        /// Thr path in the file browser when first opened.
        /// </summary>
        public string StartingPath
        {
            get
            {
                return startingPath;
            }
            set
            {
                startingPath = value;
                OpenFolder(startingPath);
            }
        }

        /// <summary>
        /// Adds an item to the file list and adds details to the columns.
        /// </summary>
        void AddItem(string item, int index)
        {
            ListViewItem objItem = new ListViewItem();
            objItem.Text = Path.GetFileName(item);
            objItem.ImageIndex = index;

            ListViewItem.ListViewSubItem objSubItem1 = new ListViewItem.ListViewSubItem();
            objSubItem1.Text = Path.GetExtension(item);
            objItem.SubItems.Add(objSubItem1);

            ListViewItem.ListViewSubItem objSubItem2 = new ListViewItem.ListViewSubItem();
            objSubItem2.Text = File.GetCreationTime(item).ToString();
            objItem.SubItems.Add(objSubItem2);

            ListViewItem.ListViewSubItem objSubItem3 = new ListViewItem.ListViewSubItem();
            objSubItem3.Text = File.GetLastWriteTime(item).ToString();
            objItem.SubItems.Add(objSubItem3);

            if (index == 4)
            {
                objItem.ToolTipText = "Name: " + Path.GetFileName(item) + "\nType: Folder\nLast Modified: " + File.GetLastWriteTime(item) + "\nDate Created: " + File.GetCreationTime(item);
            }
            else
            {
                objItem.ToolTipText = "Name: " + Path.GetFileName(item) + "\nSize: " + GetFileSize(item) + "\nType: " + Path.GetExtension(item) + " File\nLast Modified: " + File.GetLastWriteTime(item) + "\nDate Created: " + File.GetCreationTime(item);
            }
            lvwFiles.Items.Add(objItem);
        }

        /// <summary>
        /// Selects an item.
        /// </summary>
        void SelectItem()
        {
            if (mode == FileMode.Save)
            {
                CompletePath = CompletePath + @"\" + txtFileName.Text + "." + cboFileType.SelectedItem.ToString().Remove(FileFilter[cboFileType.SelectedIndex].Length).ToLower();
                selection = CompletePath;
            }
            else
            {
                try
                {
                    if (lvwFiles.SelectedItems[0].ImageIndex == 4) //If the icon is a folder icon...
                    {
                        string item = lvwFiles.SelectedItems[0].Text;
                        OpenFolder(CompletePath + item);
                        if (!Failed)
                        {
                            LastPath = CompletePath;
                            FolderHistory.Add(CompletePath);
                            historyIndex += 1;
                        }
                    }
                    else //Otherwise...
                    {
                        LastPath = CompletePath;
                        CompletePath = CompletePath + @"\" + lvwFiles.SelectedItems[0].Text;
                        selection = CompletePath;
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    //Do nothing.
                }
            }
        }

        /// <summary>
        /// Opens the specified folder.
        /// </summary>
        /// <param name="folder">The folder to open.</param>
        void OpenFolder(string folder)
        {
            selection = folder;
            try
            {
                tspLoading.Visible = true; //Show the loading progress bar to indicate that a folder is being loaded.
                tspLoading.Value = 0; //Reset the loading progress bar's value to zero.
                tspLoading.Maximum = Directory.GetDirectories(folder).Length; //Set the loading progress bar's maximum to the subdirectory count.
                tspLoading.Maximum += Directory.GetFiles(folder).Length; //Add the file count to the loading progress bar's maximum.
                lvwFiles.Clear();
                foreach (string f in Directory.GetDirectories(folder)) //For each of the specified folder's subsirectories...
                {
                    DirectoryInfo objInfo = new DirectoryInfo(f); //Create a DirectoryInfo instance for the subdirectory.
                    if ((objInfo.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden) //If the folder is not hidden...
                    {
                        AddItem(f, 4); //Add a ListViewItem with the folder icon to the list view.
                    }
                    tspLoading.Value += 1; //Increment the progress bar.
                }
                foreach (string f in Directory.GetFiles(folder)) //For each of the specified folder's files...
                {
                    FileInfo objInfo = new FileInfo(f); //Create a FileInfo instance for the file.
                    if ((objInfo.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden) //If the file is not hidden...
                    {
                        if (filter.Contains("*.*")) //If the file filter is set to All Files...
                        {
                            switch (Path.GetExtension(f).ToLower()) //Switch for file extensions.
                            {
                                case ".doc": //.doc file
                                    //Falls through.
                                case ".docx": //.docx file
                                    //Falls through.
                                case ".rtf": //Rich Text File
                                    //Falls through.
                                case ".txt": //Plain Text File
                                    AddItem(f, 3); //Add a ListView item with the document icon to the list view.
                                    break;
                                case ".jpg": //JPEG Image
                                    //Falls through.
                                case ".png": //PNG Image
                                    //Falls through.
                                case ".bmp": //Bitmap Image
                                    //Falls through.
                                case ".gif": //GIF Image
                                    int listLength = imgIcons.Images.Count; //Declare an integer representing the number of icons in the icon ImageList.
                                    try
                                    {
                                        imgIcons.Images.Add(Image.FromFile(f)); //Load the image file and add the image to the icon ImageList.
                                        listLength += 1; //Increment the list length integer.
                                        AddItem(f, listLength - 1); //Add a list item with the image thumbnail.
                                    }
                                    catch (OutOfMemoryException) //Corrupted/invalid image or not enough memory.
                                    {
                                        AddItem(f, 6); //Add a list item with the default image icon.
                                    }
                                    break; //Exit the switch statement.
                                case ".bat": //Batch File
                                    //Falls through.
                                case ".com": //DOS Application
                                    //Falls through.
                                case ".exe": //Windows Application
                                    AddItem(f, 0); //Add a ListView item with the application icon to the list view.
                                    break; //Exit the switch statement.
                                case ".html": //HTML Document (.HTML)
                                    //Falls through.
                                case ".htm": //HTML Document (.HTM)
                                    //Falls through.
                                case ".xml": //XML Document
                                    AddItem(f, 10); //Add a ListView item with the markup file icon to the list view.
                                    break; //Exit the switch statement.
                                case ".c": //C Code
                                    //Falls through.
                                case ".cpp": //C++ Code
                                    //Falls through.
                                case ".cs": //C# Code
                                    //Falls through.
                                case ".css": //CSS Code
                                    //Falls through.
                                case ".py": //Python Code
                                    //Falls through.
                                case ".pyw": //Python Code (no console window)
                                    //Falls through.
                                case ".js": //JavaScript Code
                                    //Falls through.
                                case ".java": //Java Code
                                    //Falls through.
                                case ".vb": //Visual Basic Code
                                    AddItem(f, 11); //Add a ListView item with the code file icon to the list view.
                                    break; //Exit the switch statement.
                                case ".midi": //MIDI Sequence File
                                    //Falls through.
                                case ".mp3": //MP3 File
                                    AddItem(f, 7); //Add a ListView item with the music icon to the list view.
                                    break; //Exit the switch statement.
                                case ".wav": //WAV Sound
                                    //Falls through.
                                case ".aiff": //AIFF Sound
                                    AddItem(f, 1); //Add a ListView item with the audio icon to the list view.
                                    break;
                                case ".mp4": //MP4 Video
                                    //Falls through.
                                case ".wmv": //WMV Video
                                    //Falls through.
                                case ".avi": //AVI Video
                                    AddItem(f, 9); //Add a ListView item with the video icon to the list view.
                                    break; //Exit the switch statement.
                                default: //Unknown File Type
                                    AddItem(f, 8); //Add a ListView item with the misc. file icon to the list view.
                                    break; //Exit the switch statement.
                            }
                        }
                        else //Otherwise...
                        {
                            foreach (string item in filter) //For each item in the filter array...
                            {
                                if (Path.GetExtension(f).ToLower() == "." + item.ToLower())
                                {
                                    switch (item.ToLower()) //See above seitch statement (lines 229 - 312.)
                                    {
                                        case "doc":

                                        case "docx":

                                        case "rtf":

                                        case "txt":
                                            AddItem(f, 3); //Add a ListView item with the document icon to the list view.
                                            break;
                                        case "jpg":

                                        case "png":

                                        case "bmp":

                                        case "gif":
                                            int listLength = imgIcons.Images.Count;
                                            try
                                            {
                                                imgIcons.Images.Add(Image.FromFile(f));
                                                listLength += 1;
                                                AddItem(f, listLength - 1);
                                            }
                                            catch (OutOfMemoryException)
                                            {
                                                AddItem(f, 6);
                                            }
                                            break;
                                        case "bat":

                                        case "com":

                                        case "exe":
                                            AddItem(f, 0); //Add a ListView item with the application icon to the list view.
                                            break;
                                        case "html":

                                        case "htm":

                                        case "xml":
                                            AddItem(f, 10); //Add a ListView item with the markup file icon to the list view.
                                            break;
                                        case "c":

                                        case "cpp":

                                        case "cs":

                                        case "css":

                                        case "py":

                                        case "pyw":

                                        case "js":

                                        case "java":

                                        case "vb":
                                            AddItem(f, 11); //Add a ListView item with the code file icon to the list view.
                                            break;
                                        case "midi":

                                        case "mp3":
                                            AddItem(f, 7); //Add a ListView item with the music icon to the list view.
                                            break;
                                        case "wav":

                                        case "aiff":
                                            AddItem(f, 1); //Add a ListView item with the audio icon to the list view.
                                            break;
                                        case "mp4":

                                        case "wmv":

                                        case "avi":
                                            AddItem(f, 9); //Add a ListView item with the video icon to the list view.
                                            break;
                                        case "alsp":
                                            AddItem(f, 8); //Add a ListView item with the misc. file icon to the list view.
                                            break;
                                    }
                                }
                            }
                        }
                    }
                    tspLoading.Value += 1;
                }
                tstTypePath.Text = folder;
                CompletePath = tstTypePath.Text + @"\";
                tsbBack.Enabled = true;
                Failed = false; //Set Failed to false to indicate a successful opening of the folder.
                tspLoading.Visible = false;
                if (lvwFiles.Items.Count == 0) //If the list is empty, which means the folder is empty...
                {
                    lblFolderEmpty.Visible = true; //Show the "empty folder" message label.
                    tsbDelete.Enabled = false; //Disable the Delete button.
                    tsbCopy.Enabled = false; //Disable the Copy button.
                    tsbCut.Enabled = false; //Disable the Cut button.
                }
                else //Otherwise...
                {
                    lblFolderEmpty.Visible = false; //Hise the "empty folder" message label.
                    tsbDelete.Enabled = true; //Enable the Delete button.
                    tsbCopy.Enabled = true; //Enable the Copy button.
                    tsbCut.Enabled = true; //Enable the Cut button.
                }
            }
            catch (UnauthorizedAccessException) //The user doesn't have permission to access the folder.
            {
                MessageBox.Show("You do not have permission to access the selected file or folder.", "Error Opening File/Folder", MessageBoxButtons.OK, MessageBoxIcon.Error); //Show an error message box indicating the access error.
                OpenFolder(CompletePath); //Open the previous folder.
                Failed = true; //Set Failed to true to indicate failure.
            }
        }

        private void lvwFiles_ItemActivate(object sender, EventArgs e)
        {
            SelectItem();
        }

        private void DeleteFolder(object sender, EventArgs e)
        {
            Directory.Delete(CompletePath + lvwFiles.SelectedItems[i].Text, true);
        }

        private void DeleteFile(object sender, EventArgs e)
        {
            File.Delete(CompletePath + lvwFiles.SelectedItems[i].Text);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you wish to permanently delete the selected items?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes) //If the user clicked Yes in a confirmation box...
                {
                    for (i = 0; i <= lvwFiles.SelectedItems.Count; i++) //For each of the selected items in the list...
                    {
                        if (lvwFiles.SelectedItems[i].ImageIndex == 4) //If the icon is a folder icon...
                        {
                            EnhancedFileSelection.frmFileOperationProgress frmFileOperationProgress = new EnhancedFileSelection.frmFileOperationProgress();  
                            frmFileOperationProgress.Text = "Deleting " + CompletePath + lvwFiles.SelectedItems[i].Text;
                            EnhancedFileSelection.FileOperation objFileOperation = new EnhancedFileSelection.FileOperation(EnhancedFileSelection.FileOperationType.DeleteFolder, lvwFiles.SelectedItems[i].Text);
                            frmFileOperationProgress.StartFileOperation(objFileOperation, new string[] { lvwFiles.SelectedItems[i].Text });
                            frmFileOperationProgress.Show();    
                            
                        }
                        else //Otherwise...
                        {
                            EnhancedFileSelection.frmFileOperationProgress frmFileOperationProgress = new EnhancedFileSelection.frmFileOperationProgress();
                            frmFileOperationProgress.Text = "Deleting " + CompletePath + lvwFiles.SelectedItems[i].Text;
                            EnhancedFileSelection.FileOperation objFileOperation = new EnhancedFileSelection.FileOperation(EnhancedFileSelection.FileOperationType.DeleteFolder, lvwFiles.SelectedItems[i].Text);
                            frmFileOperationProgress.StartFileOperation(objFileOperation, new string[] { lvwFiles.SelectedItems[i].Text });
                            frmFileOperationProgress.Show();
                        }
                        lvwFiles.Items.Remove(lvwFiles.SelectedItems[i]); //Remove the item from the list.
                    }
                }
            }
            catch (IOException) //I/O Error
            {
                MessageBox.Show("You do not have permission to delete the selected item.", "Could Not Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Error); //Show an error message indicating an access error.
            }
            catch (UnauthorizedAccessException) //The user doesn't have permission to delete the selected file/folder.
            {
                MessageBox.Show("You do not have permission to delete the selected item.", "Could Not Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Error); //Show an error message indicating an access error.
            }
            catch (ArgumentOutOfRangeException) 
            {
                //Ignore the error.
            }
        }

        private void tsbGoUp_Click(object sender, EventArgs e)
        {
            CompletePath = LastPath;
            OpenFolder(CompletePath);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbDelete.PerformClick();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectItem();
        }

        private void lvwFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwFiles.SelectedItems[0].ImageIndex == 4) //If the icon is a folder icon...
                {
                    
                }
                else //Otherwise
                {
                    
                }
                string ext = Path.GetExtension(lvwFiles.SelectedItems[0].Text);
                if (ext == ".JPG" || ext == ".jpg" || ext == ".png" || ext == ".PNG" || ext == ".bmp" || ext == ".BMP" || ext == ".gif" || ext == ".GIF") //If the item represents an image file...
                {
                    picPreview.Image = Image.FromFile(CompletePath + @"\" + lvwFiles.SelectedItems[0].Text);
                    picPreview.SizeMode = PictureBoxSizeMode.StretchImage;
                    lblPreviewFileType.Text = "File Format: " + ext.Substring(0).ToUpper();
                    lblFileSize.Text = "File Size: " + GetFileSize(CompletePath + @"\" + lvwFiles.SelectedItems[0].Text);
                    lblImageSize.Text = "Image Size: " + Image.FromFile(CompletePath + @"\" + lvwFiles.SelectedItems[0].Text).PhysicalDimension.ToString();
                }
                else //Otherwise...
                {
                    picPreview.Image = null;
                    lblFileName.Text = "File Name: ";
                    lblFileSize.Text = "File Size: ";
                    lblImageSize.Text = "Image Size: ";
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                //Do nothing.
            }
            catch (OutOfMemoryException) //Corrupted/invalid image or not enough memory.
            {
                picPreview.Image = imgIcons.Images[6];
                picPreview.SizeMode = PictureBoxSizeMode.CenterImage;
                lblFileName.Text = "File Name: ";
                lblFileSize.Text = "File Size: ";
                lblImageSize.Text = "Image Size: ";
            }
        }

        private void newFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnhancedFileSelection.frmNewFolder frmNewFolder = new EnhancedFileSelection.frmNewFolder(); //Open the New Folder dialog box.
            if (frmNewFolder.ShowDialog() == DialogResult.OK) //If the user clicked OK in the New Folder dialog box...
            {
                Directory.CreateDirectory(CompletePath + frmNewFolder.FolderName); //Create a new folder with the entered name.
                OpenFolder(CompletePath); //Update the list's contents to show the newly created folder.
            }
        }

        private void lvwFiles_DragDrop(object sender, DragEventArgs e)
        {
            File.Move(e.Data.ToString(), CompletePath + Path.GetFileName(e.Data.ToString())); //Move the dropped file to the open folder.
            OpenFolder(CompletePath); //Update the list's contents to show the sropped file.
        }

        private void fswFileUpdater_Created(object sender, FileSystemEventArgs e)
        {
            OpenFolder(CompletePath); //Update the list's contents to show the newly created file.
        }

        private void fswFileUpdater_Deleted(object sender, FileSystemEventArgs e)
        {
            if (CompletePath == Path.GetDirectoryName(e.FullPath)) //If the folder that the deleted file was in is currently open in the file list...
            {
                foreach (ListViewItem item in lvwFiles.Items) //For each item in the file list...
                {
                    if (item.Text == e.Name) //If the item's label is equal to the name of the file that was deleted...
                    {
                        lvwFiles.Items.Remove(item); //Remove the item from the list.
                    }
                }
            }
        }

        private void fswFileUpdater_Renamed(object sender, RenamedEventArgs e)
        {
            OpenFolder(CompletePath); //Update the list's contents to reflect the name change.
        }

        private void tsbBack_Click(object sender, EventArgs e)
        {
            try
            {
                historyIndex -= 1;

                if (historyIndex < 0)
                {
                    tsbBack.Enabled = false;
                }
                OpenFolder(FolderHistory[historyIndex]);
            }
            catch
            {
                //Ignore the error.
            }
        }

        private void tsbForward_Click(object sender, EventArgs e)
        {
            try
            {
                historyIndex += 1;

                if (historyIndex == FolderHistory.Count + 1)
                {
                    tsbForward.Enabled = false;
                }
                OpenFolder(FolderHistory[historyIndex]);
            }
            catch
            {
                //Ignore the error.
            }
        }

        private void tvwFolders_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes[0].Text == "")
            {
                TreeNode node = fe.EnumerateDirectory(e.Node);
            }
        }

        private void tvwFolders_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.FullPath.StartsWith("Desktop"))
            {
                OpenFolder(@"C:\Users\" + System.Security.Principal.WindowsIdentity.GetCurrent().Name.Substring(Environment.MachineName.Length + 1) + @"\Desktop");
            }
            else
            {
                OpenFolder(e.Node.FullPath);
            }
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwFiles.View = View.LargeIcon;
            largeIconToolStripMenuItem.Enabled = false;
            smallIconsToolStripMenuItem.Enabled = true;
            tilesToolStripMenuItem.Enabled = true;
            detailsToolStripMenuItem.Enabled = true;
            listToolStripMenuItem.Enabled = true;
        }

        private void smallIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwFiles.View = View.SmallIcon;
            largeIconToolStripMenuItem.Enabled = true;
            smallIconsToolStripMenuItem.Enabled = false;
            tilesToolStripMenuItem.Enabled = true;
            detailsToolStripMenuItem.Enabled = true;
            listToolStripMenuItem.Enabled = true;
        }

        private void tilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwFiles.View = View.Tile;
            largeIconToolStripMenuItem.Enabled = true;
            smallIconsToolStripMenuItem.Enabled = true;
            tilesToolStripMenuItem.Enabled = false;
            detailsToolStripMenuItem.Enabled = true;
            listToolStripMenuItem.Enabled = true;
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwFiles.View = View.Details;
            largeIconToolStripMenuItem.Enabled = true;
            smallIconsToolStripMenuItem.Enabled = true;
            tilesToolStripMenuItem.Enabled = true;
            detailsToolStripMenuItem.Enabled = false;
            listToolStripMenuItem.Enabled = true;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwFiles.View = View.List;
            largeIconToolStripMenuItem.Enabled = true;
            smallIconsToolStripMenuItem.Enabled = true;
            tilesToolStripMenuItem.Enabled = true;
            detailsToolStripMenuItem.Enabled = true;
            listToolStripMenuItem.Enabled = false;
        }

        private void EnhancedFileSelector_Load(object sender, EventArgs e)
        {
            fe.CreateTree(tvwFolders);
            CompletePath = StartingPath;
            OpenFolder(CompletePath);
            tsbBack.Enabled = false;
            if (mode == FileMode.Save)
            {
                
            }
            cboFileType.Items.Clear();
            foreach (string item in FileFilter)
            {
                cboFileType.Items.Add(item.Substring(1).ToUpper() + " files (" + item + ")");
            }
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwFiles.SelectedItems[0].BeginEdit();
        }

        private void lvwFiles_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (lvwFiles.SelectedItems[0].ImageIndex == 4) //If the icon is a folder icon...
            {
                Directory.Move(selection + @"\" + lvwFiles.SelectedItems[0], Path.GetDirectoryName(selection) + @"\" + e.Label); //Rename the directory to what the user typed in.
            }
            else
            {
                File.Move(selection + @"\" + lvwFiles.SelectedItems[0], Path.GetDirectoryName(selection) + @"\" + e.Label); //Rename the file to what the user typed in.
            }
        }
    }
}
