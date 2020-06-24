using MagiZile.CustomUI.Properties;
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
using System.Xml;

namespace MagiZile.CustomUI
{
    public partial class TabbedDocuments : UserControl
    {
        public TabbedDocuments()
        {
            languageKeywords.Add("if");
            languageKeywords.Add("while");
            languageKeywords.Add("for");
            languageKeywords.Add("set");
            languageKeywords.Add("as");
            languageKeywords.Add("try");
            languageKeywords.Add("catch");
            languageKeywords.Add("void");
            languageKeywords.Add("int");
            languageKeywords.Add("str");
            languageKeywords.Add("dbl");
            languageKeywords.Add("bool");
            languageKeywords.Add("char");
            languageKeywords.Add("true");
            languageKeywords.Add("false");
            languageKeywords.Add("null");
            languageKeywords.Add("constant");
            InitializeComponent();
        }
        /// <summary>
        /// This class is used by Acadica Add-Ons to refer to tabs.
        /// </summary>
        public class Tab
        {
            public string text = "";
            public string file = "";
            public int id = 0;
            public DocumentType type = DocumentType.None;

            /// <summary>
            /// The text shown on the tab button.
            /// </summary>
            public string Text
            {
                get
                {
                    return text;
                }
                set
                {
                    text = value;
                }
            }

            /// <summary>
            /// The file name associated with the tab.
            /// </summary>
            public string FileName
            {
                get
                {
                    return file;
                }
                set
                {
                    file = value;
                }
            }

            /// <summary>
            /// The tab ID.
            /// </summary>
            public int ID
            {
                get
                {
                    return id;
                }
                set
                {
                    id = value;
                }
            }

            /// <summary>
            /// The type of document associated with the tab.
            /// </summary>
            public DocumentType Type
            {
                get
                {
                    return type;
                }
                set
                {
                    type = value;
                }
            }

            public void Save(TabbedDocuments tabbedDocumentsControl)
            {
                tabbedDocumentsControl.SaveTab(id);
            }
        }

        string AppDataPath = @"C:\Users\" + System.Security.Principal.WindowsIdentity.GetCurrent().Name.Substring(Environment.MachineName.Length + 1) + @"\AppData\Roaming\MagiZile\Acadica\Acadica Lesson Studio";
        public enum DocumentType { Quiz, TextDocument, CodeFile, ImageDocument, Image, FinanceNationLesson, ProjectProperties, None }; //This is the list of document types.
        bool highlightCode = false;
        List<String> languageKeywords = new List<string>();

        public event EventHandler UnitsRemoved;

        byte activetab = 1;
        public byte TabsVisible = 0;
        public byte img = 0;
        public string tab1text = "";
        public string tab2text = "";
        public string tab3text = "";
        public string tab4text = "";
        public string tab5text = "";
        public string tab6text = "";
        public string tab1file = "";
        public string tab2file = "";
        public string tab3file = "";
        public string tab4file = "";
        public string tab5file = "";
        public string tab6file = "";
        public string projectPassword = "";

        void SaveTab(int tab)
        {
            switch (tab)
            {
                case 1:
                    try
                    {
                        if (tab1file != "")
                        {
                            StreamWriter objFile = new StreamWriter(tab1file);
                            switch (tab1doctype)
                            {
                                case DocumentType.CodeFile:

                                    break;
                                case DocumentType.FinanceNationLesson:

                                    break;
                                case DocumentType.Image:

                                    break;
                                case DocumentType.ImageDocument:

                                    break;
                                case DocumentType.ProjectProperties:

                                    break;
                                case DocumentType.Quiz:

                                    break;
                                case DocumentType.TextDocument:
                                    rtbTextDocumentBody.SaveFile(tab1file, RichTextBoxStreamType.RichText);
                                    break;
                                default:
                                    throw (new ArgumentException());
                            }
                        }
                    }
                    catch
                    {
                        break;
                    }
                    break;
                case 2:
                    try
                    {
                        if (tab2file != "")
                        {
                            StreamWriter objFile = new StreamWriter(tab2file);
                            switch (tab2doctype)
                            {
                                case DocumentType.CodeFile:

                                    break;
                                case DocumentType.FinanceNationLesson:

                                    break;
                                case DocumentType.Image:

                                    break;
                                case DocumentType.ImageDocument:

                                    break;
                                case DocumentType.ProjectProperties:

                                    break;
                                case DocumentType.Quiz:

                                    break;
                                case DocumentType.TextDocument:
                                    rtbTextDocumentBody.SaveFile(tab2file, RichTextBoxStreamType.RichText);
                                    break;
                                default:
                                    throw (new ArgumentException());
                            }
                        }
                    }
                    catch
                    {
                        break;
                    }
                    break;
                case 3:
                    try
                    {
                        if (tab3file != "")
                        {
                            StreamWriter objFile = new StreamWriter(tab3file);
                            switch (tab3doctype)
                            {
                                case DocumentType.CodeFile:

                                    break;
                                case DocumentType.FinanceNationLesson:

                                    break;
                                case DocumentType.Image:

                                    break;
                                case DocumentType.ImageDocument:

                                    break;
                                case DocumentType.ProjectProperties:

                                    break;
                                case DocumentType.Quiz:

                                    break;
                                case DocumentType.TextDocument:
                                    rtbTextDocumentBody.SaveFile(tab3file, RichTextBoxStreamType.RichText);
                                    break;
                                default:
                                    throw (new ArgumentException());
                            }
                        }
                    }
                    catch
                    {
                        break;
                    }
                    break;
                case 4:
                    try
                    {
                        if (tab4file != "")
                        {
                            StreamWriter objFile = new StreamWriter(tab4file);
                            switch (tab4doctype)
                            {
                                case DocumentType.CodeFile:

                                    break;
                                case DocumentType.FinanceNationLesson:

                                    break;
                                case DocumentType.Image:

                                    break;
                                case DocumentType.ImageDocument:

                                    break;
                                case DocumentType.ProjectProperties:

                                    break;
                                case DocumentType.Quiz:

                                    break;
                                case DocumentType.TextDocument:
                                    rtbTextDocumentBody.SaveFile(tab4file, RichTextBoxStreamType.RichText);
                                    break;
                                default:
                                    throw (new ArgumentException());
                            }
                        }
                    }
                    catch
                    {
                        break;
                    }
                    break;
                case 5:
                    try
                    {
                        if (tab5file != "")
                        {
                            StreamWriter objFile = new StreamWriter(tab5file);
                            switch (tab5doctype)
                            {
                                case DocumentType.CodeFile:

                                    break;
                                case DocumentType.FinanceNationLesson:

                                    break;
                                case DocumentType.Image:

                                    break;
                                case DocumentType.ImageDocument:

                                    break;
                                case DocumentType.ProjectProperties:

                                    break;
                                case DocumentType.Quiz:

                                    break;
                                case DocumentType.TextDocument:
                                    rtbTextDocumentBody.SaveFile(tab5file, RichTextBoxStreamType.RichText);
                                    break;
                                default:
                                    throw (new ArgumentException());
                            }
                        }
                    }
                    catch
                    {
                        break;
                    }
                    break;
                case 6:
                    try
                    {
                        if (tab6file != "")
                        {
                            StreamWriter objFile = new StreamWriter(tab6file);
                            switch (tab6doctype)
                            {
                                case DocumentType.CodeFile:

                                    break;
                                case DocumentType.FinanceNationLesson:

                                    break;
                                case DocumentType.Image:

                                    break;
                                case DocumentType.ImageDocument:

                                    break;
                                case DocumentType.ProjectProperties:

                                    break;
                                case DocumentType.Quiz:

                                    break;
                                case DocumentType.TextDocument:
                                    rtbTextDocumentBody.SaveFile(tab6file, RichTextBoxStreamType.RichText);
                                    break;
                                default:
                                    throw (new ArgumentException());
                            }
                        }
                    }
                    catch
                    {
                        break;
                    }
                    break;
            }
        }

        /// <summary>
        /// Highlights all instances of a word in the text document text.
        /// </summary>
        /// <param name="word">The word to highlight.</param>
        /// <param name="highlightColor"></param>
        void HighlightAll(string word, Color highlightColor)
        {
            int selectionStart = rtbTextDocumentBody.SelectionStart, startIndex = 0, index;
            while ((index = rtbTextDocumentBody.Text.IndexOf(word, startIndex)) != -1)
            {
                rtbTextDocumentBody.Select(index, word.Length);
                rtbTextDocumentBody.SelectionColor = highlightColor;
                startIndex = index + word.Length;
                rtbTextDocumentBody.SelectionStart = selectionStart;
                rtbTextDocumentBody.SelectionLength = 0;
                rtbTextDocumentBody.SelectionColor = Color.Black;
            }
        }

        /// <summary>
        /// Saves the selected font style/color as a preset.
        /// </summary>
        /// <param name="id">The preset ID.</param>
        void SavePreset(int id)
        {
            XmlWriter objPresetFile = XmlWriter.Create(AppDataPath + @"\presets\" + id.ToString() + ".prst");
            objPresetFile.WriteStartDocument();
            objPresetFile.WriteStartElement("preset");
            objPresetFile.WriteStartElement("family");
            objPresetFile.WriteString(rtbTextDocumentBody.SelectionFont.Name);
            objPresetFile.WriteEndElement();
            objPresetFile.WriteStartElement("size");
            objPresetFile.WriteString(rtbTextDocumentBody.SelectionFont.Size.ToString());
            objPresetFile.WriteEndElement();
            objPresetFile.WriteStartElement("style");
            objPresetFile.WriteString(FontStyleToNumber(rtbTextDocumentBody.SelectionFont.Bold, rtbTextDocumentBody.SelectionFont.Italic, rtbTextDocumentBody.SelectionFont.Underline, rtbTextDocumentBody.SelectionFont.Strikeout));
            objPresetFile.WriteEndElement();
            objPresetFile.WriteEndElement();
            objPresetFile.WriteEndDocument();
            objPresetFile.Close(); //Close the file.
            objPresetFile.Dispose(); //Clean up.
        }

        /// <summary>
        /// Changes the text box font style based on a style number.
        /// </summary>
        /// <param name="styleNumber">The style number.</param>
        public void GetFontStyle(string styleNumber)
        {
            changeStyle(styleNumber);
        }

        void changeStyle(string styleNumber)
        {
            switch (styleNumber)
            {
                case "0000":
                    rtbTextDocumentBody.SelectionFont = new Font(rtbTextDocumentBody.SelectionFont.FontFamily, rtbTextDocumentBody.SelectionFont.Size, FontStyle.Regular);
                    break;
                case "0001":
                    rtbTextDocumentBody.SelectionFont = new Font(rtbTextDocumentBody.SelectionFont.FontFamily, rtbTextDocumentBody.SelectionFont.Size, FontStyle.Strikeout);
                    break;
                case "0010":
                    rtbTextDocumentBody.SelectionFont = new Font(rtbTextDocumentBody.SelectionFont.FontFamily, rtbTextDocumentBody.SelectionFont.Size, FontStyle.Underline);
                    break;
                case "0100":
                    rtbTextDocumentBody.SelectionFont = new Font(rtbTextDocumentBody.SelectionFont.FontFamily, rtbTextDocumentBody.SelectionFont.Size, FontStyle.Italic);
                    break;
                case "1000":
                    rtbTextDocumentBody.SelectionFont = new Font(rtbTextDocumentBody.SelectionFont.FontFamily, rtbTextDocumentBody.SelectionFont.Size, FontStyle.Bold);
                    break;
                case "1100":
                    rtbTextDocumentBody.SelectionFont = new Font(rtbTextDocumentBody.SelectionFont.FontFamily, rtbTextDocumentBody.SelectionFont.Size, FontStyle.Bold | FontStyle.Italic);
                    break;
                case "1110":
                    rtbTextDocumentBody.SelectionFont = new Font(rtbTextDocumentBody.SelectionFont.FontFamily, rtbTextDocumentBody.SelectionFont.Size, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                    break;
                case "1111":
                    rtbTextDocumentBody.SelectionFont = new Font(rtbTextDocumentBody.SelectionFont.FontFamily, rtbTextDocumentBody.SelectionFont.Size, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline | FontStyle.Strikeout);
                    break;
                case "1011":
                    rtbTextDocumentBody.SelectionFont = new Font(rtbTextDocumentBody.SelectionFont.FontFamily, rtbTextDocumentBody.SelectionFont.Size, FontStyle.Bold | FontStyle.Underline | FontStyle.Strikeout);
                    break;
                case "1101":
                    rtbTextDocumentBody.SelectionFont = new Font(rtbTextDocumentBody.SelectionFont.FontFamily, rtbTextDocumentBody.SelectionFont.Size, FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout);
                    break;
                case "1001":
                    rtbTextDocumentBody.SelectionFont = new Font(rtbTextDocumentBody.SelectionFont.FontFamily, rtbTextDocumentBody.SelectionFont.Size, FontStyle.Bold | FontStyle.Strikeout);
                    break;
                case "0101":
                    rtbTextDocumentBody.SelectionFont = new Font(rtbTextDocumentBody.SelectionFont.FontFamily, rtbTextDocumentBody.SelectionFont.Size, FontStyle.Italic | FontStyle.Strikeout);
                    break;
                case "0111":
                    rtbTextDocumentBody.SelectionFont = new Font(rtbTextDocumentBody.SelectionFont.FontFamily, rtbTextDocumentBody.SelectionFont.Size, FontStyle.Italic | FontStyle.Underline | FontStyle.Strikeout);
                    break;
                case "1010":
                    rtbTextDocumentBody.SelectionFont = new Font(rtbTextDocumentBody.SelectionFont.FontFamily, rtbTextDocumentBody.SelectionFont.Size, FontStyle.Bold | FontStyle.Underline);
                    break;
                case "0110":
                    rtbTextDocumentBody.SelectionFont = new Font(rtbTextDocumentBody.SelectionFont.FontFamily, rtbTextDocumentBody.SelectionFont.Size, FontStyle.Italic | FontStyle.Underline);
                    break;
                default:
                    throw (new ArgumentException());
            }
        }

        /// <summary>
        /// Sets the font style based on four boolean variables, preferably menu item check states.
        /// </summary>
        /// <param name="menuItem1">The first value.</param>
        /// <param name="menuItem2">The second value.</param>
        /// <param name="menuItem3">The third value.</param>
        /// <param name="menuItem4">The fourth value.</param>
        public void SetFontStyle(bool menuItem1, bool menuItem2, bool menuItem3, bool menuItem4)
        {
            string styleNumber = "";
            if (menuItem1)
            {
                styleNumber += "1";
            }
            else
            {
                styleNumber += "0";
            }
            if (menuItem2)
            {
                styleNumber += "1";
            }
            else
            {
                styleNumber += "0";
            }
            if (menuItem3)
            {
                styleNumber += "1";
            }
            else
            {
                styleNumber += "0";
            }
            if (menuItem4)
            {
                styleNumber += "1";
            }
            else
            {
                styleNumber += "0";
            }
            changeStyle(styleNumber);
        }

        /// <summary>
        /// Saves the documents of all open tabs.
        /// </summary>
        public void SaveAllTabs()
        {
            for (int i = 0; i < 7; i++)
            {
                SaveTab(i);
            }
        }

        /// <summary>
        /// Gets a style number string from four font style values.
        /// </summary>
        /// <param name="bold">Whether or not the text is bold.</param>
        /// <param name="italic">Whether or not the text is italicized.</param>
        /// <param name="underline">Whether or not the text is underlined.</param>
        /// <param name="strikethrough">Whether or not there is a line through the text.</param>
        /// <returns></returns>
        public string FontStyleToNumber(bool bold, bool italic, bool underline, bool strikethrough)
        {
            string styleNumber = "";
            if (bold)
            {
                styleNumber += "1";
            }
            else
            {
                styleNumber += "0";
            }
            if (italic)
            {
                styleNumber += "1";
            }
            else
            {
                styleNumber += "0";
            }
            if (underline)
            {
                styleNumber += "1";
            }
            else
            {
                styleNumber += "0";
            }
            if (strikethrough)
            {
                styleNumber += "1";
            }
            else
            {
                styleNumber += "0";
            }
            return styleNumber;
        }

        /// <summary>
        /// Converts a string to a document type.
        /// </summary>
        /// <param name="text">The string to convert.</param>
        /// <returns></returns>
        public DocumentType StringToDocumentType(string text)
        {
            switch (text)
            {
                case "CodeFile":
                    return DocumentType.CodeFile;
                case "TextDocument":
                    return DocumentType.TextDocument;
                case "Quiz":
                    return DocumentType.Quiz;
                case "FinanceNationLesson":
                    return DocumentType.FinanceNationLesson;
                case "ImageDocument":
                    return DocumentType.ImageDocument;
                case "Image":
                    return DocumentType.Image;
                case "None":
                    return DocumentType.None;
                default:
                    throw (new InvalidCastException());
            }
        }

        public string Tab1_File
        {
            get
            {
                return tab1file;
            }
            set
            {
                tab1file = value;
            }
        }

        public string Tab2_File
        {
            get
            {
                return tab2file;
            }
            set
            {
                tab2file = value;
            }
        }

        public string Tab3_File
        {
            get
            {
                return tab3file;
            }
            set
            {
                tab3file = value;
            }
        }

        public string Tab4_File
        {
            get
            {
                return tab4file;
            }
            set
            {
                tab4file = value;
            }
        }

        public string Tab5_File
        {
            get
            {
                return tab5file;
            }
            set
            {
                tab5file = value;
            }
        }

        public string Tab6_File
        {
            get
            {
                return tab6file;
            }
            set
            {
                tab6file = value;
            }
        }

        public string Tab1_Text
        {
            get
            {
                return tab1text;
            }
            set
            {
                tab1text = value;
            }
        }
        public string Tab2_Text
        {
            get
            {
                return tab2text;
            }
            set
            {
                tab2text = value;
            }
        }
        public string Tab3_Text
        {
            get
            {
                return tab3text;
            }
            set
            {
                tab3text = value;
            }
        }
        public string Tab4_Text
        {
            get
            {
                return tab4text;
            }
            set
            {
                tab4text = value;
            }
        }
        public string Tab5_Text
        {
            get
            {
                return tab5text;
            }
            set
            {
                tab5text = value;
            }
        }
        public string Tab6_Text
        {
            get
            {
                return tab6text;
            }
            set
            {
                tab6text = value;
            }
        }

        /// <summary>
        /// The tab currently selected.
        /// </summary>
        public Button ActiveTab
        {
            get
            {
                switch (activetab)
                {
                    case 1:
                        return btnDoc1;
                    case 2:
                        return btnDoc2;
                    case 3:
                        return btnDoc3;
                    case 4:
                        return btnDoc4;
                    case 5:
                        return btnDoc5;
                    case 6:
                        return btnDoc6;
                    default:
                        return null;
                }
            }
        }
        public DocumentType tab1doctype = DocumentType.None;
        public DocumentType tab2doctype = DocumentType.None;
        public DocumentType tab3doctype = DocumentType.None;
        public DocumentType tab4doctype = DocumentType.None;
        public DocumentType tab5doctype = DocumentType.None;
        public DocumentType tab6doctype = DocumentType.None;

        public DocumentType Tab1_DocumentType
        {
            get
            {
                return tab1doctype;
            }
            set
            {
                tab1doctype = value;
            }
        }
        public DocumentType Tab2_DocumentType
        {
            get
            {
                return tab2doctype;
            }
            set
            {
                tab2doctype = value;
            }
        }
        public DocumentType Tab3_DocumentType
        {
            get
            {
                return tab3doctype;
            }
            set
            {
                tab3doctype = value;
            }
        }
        public DocumentType Tab4_DocumentType
        {
            get
            {
                return tab4doctype;
            }
            set
            {
                tab4doctype = value;
            }
        }
        public DocumentType Tab5_DocumentType
        {
            get
            {
                return tab5doctype;
            }
            set
            {
                tab5doctype = value;
            }
        }
        public DocumentType Tab6_DocumentType
        {
            get
            {
                return tab6doctype;
            }
            set
            {
                tab6doctype = value;
            }
        }

        /// <summary>
        /// Opens a document, creating it if the file does not exist.
        /// </summary>
        /// <param name="doc">The type of document.</param>
        /// <param name="name">The name shown on the tab.</param>
        /// <param name="file">The file name of the document.</param>
        public void OpenDocument(DocumentType doc, string name, string file)
        {
            try
            {
                switch (TabsVisible + 1)
                {
                    case 1:
                        btnDoc1.Visible = true;
                        btnCloseDoc1.Visible = true;
                        Tab1_DocumentType = doc;
                        Tab1_File = file;
                        break;
                    case 2:
                        btnDoc2.Visible = true;
                        btnCloseDoc2.Visible = true;
                        Tab2_DocumentType = doc;
                        Tab2_File = file;
                        break;
                    case 3:
                        btnDoc3.Visible = true;
                        btnCloseDoc3.Visible = true;
                        Tab3_DocumentType = doc;
                        Tab3_File = file;
                        break;
                    case 4:
                        btnDoc4.Visible = true;
                        btnCloseDoc4.Visible = true;
                        Tab4_DocumentType = doc;
                        Tab4_File = file;
                        break;
                    case 5:
                        btnDoc5.Visible = true;
                        btnCloseDoc5.Visible = true;
                        Tab5_DocumentType = doc;
                        Tab5_File = file;
                        break;
                    case 6:
                        btnDoc6.Visible = true;
                        btnCloseDoc6.Visible = true;
                        Tab6_DocumentType = doc;
                        Tab6_File = file;
                        break;
                    default:
                        MessageBox.Show("You can only have six tabs open at a time. You must close some before you can add more.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                SetActiveDocument(doc, Convert.ToByte(Convert.ToInt32(TabsVisible + 1)));
                ActiveTab.Text = name;
                TabsVisible++;
            }
            catch (ArgumentException)
            {
                //Ignore the error.
            }
        }

        /// <summary>
        /// Gets the active document.
        /// </summary>
        /// <returns>A Tab object representing the active document/tab.</returns>
        public Tab GetActiveDocument()
        {
            Tab objTab = new Tab();
            switch (activetab)
            {
                case 1:
                    objTab.ID = 1;
                    objTab.Type = tab1doctype;
                    objTab.Text = tab1text;
                    objTab.FileName = tab1file;
                    break;
                case 2:
                    objTab.ID = 2;
                    objTab.Type = tab2doctype;
                    objTab.Text = tab2text;
                    objTab.FileName = tab2file;
                    break;
                case 3:
                    objTab.ID = 3;
                    objTab.Type = tab3doctype;
                    objTab.Text = tab3text;
                    objTab.FileName = tab3file;
                    break;
                case 4:
                    objTab.ID = 4;
                    objTab.Type = tab4doctype;
                    objTab.Text = tab4text;
                    objTab.FileName = tab4file;
                    break;
                case 5:
                    objTab.ID = 5;
                    objTab.Type = tab5doctype;
                    objTab.Text = tab5text;
                    objTab.FileName = tab5file;
                    break;
                case 6:
                    objTab.ID = 6;
                    objTab.Type = tab6doctype;
                    objTab.Text = tab6text;
                    objTab.FileName = tab6file;
                    break;
            }
            return objTab;
        }

        /// <summary>
        /// Sets the active document.
        /// </summary>
        /// <param name="doc">The type of document.</param>
        /// <param name="tab">The tab that the document in in.</param>
        public void SetActiveDocument(DocumentType doc, byte tab) //This sets the active document and changes the button color for tab-like behavior.
        {
            switch (doc)
            {
                case DocumentType.CodeFile:
                    rtbTextDocumentBody.Clear();
                    rtbTextDocumentBody.Visible = true;
                    pnlQuizPanel.Visible = false;
                    pnlFinanceNationLessonEditor.Visible = false;
                    tabProjectProperties.Visible = false;
                    rtbTextDocumentBody.BringToFront();
                    cmuCodeFile.Enabled = true;
                    cmuTextDocument.Enabled = false;
                    rtbTextDocumentBody.ContextMenuStrip = cmuCodeFile;
                    highlightCode = true;
                    break;
                case DocumentType.FinanceNationLesson:
                    rtbTextDocumentBody.Clear();
                    rtbTextDocumentBody.Visible = false;
                    pnlQuizPanel.Visible = true;
                    pnlFinanceNationLessonEditor.Visible = true;
                    pnlFinanceNationLessonEditor.BringToFront();
                    break;
                case DocumentType.Quiz:
                    rtbTextDocumentBody.Clear();
                    rtbTextDocumentBody.Visible = false;
                    pnlQuizPanel.Visible = true;
                    pnlFinanceNationLessonEditor.Visible = false;
                    tabProjectProperties.Visible = false;
                    pnlQuizPanel.BringToFront();
                    break;
                case DocumentType.TextDocument:
                    rtbTextDocumentBody.Clear();
                    rtbTextDocumentBody.Visible = true;
                    pnlQuizPanel.Visible = false;
                    pnlFinanceNationLessonEditor.Visible = false;
                    tabProjectProperties.Visible = false;
                    rtbTextDocumentBody.BringToFront();
                    cmuCodeFile.Enabled = false;
                    cmuTextDocument.Enabled = true;
                    rtbTextDocumentBody.ContextMenuStrip = cmuTextDocument;
                    highlightCode = false;
                    break;
                case DocumentType.ProjectProperties:

                case DocumentType.None:
                    rtbTextDocumentBody.Clear();
                    rtbTextDocumentBody.Visible = false;
                    pnlQuizPanel.Visible = false;
                    pnlFinanceNationLessonEditor.Visible = false;
                    tabProjectProperties.Visible = false;
                    break;
            }
            switch (tab)
            {
                case 1:
                    tab1doctype = doc;
                    btnDoc1.BackColor = SystemColors.Window;
                    btnDoc2.BackColor = SystemColors.Control;
                    btnDoc3.BackColor = SystemColors.Control;
                    btnDoc4.BackColor = SystemColors.Control;
                    btnDoc5.BackColor = SystemColors.Control;
                    btnDoc6.BackColor = SystemColors.Control;
                    break;
                case 2:
                    tab2doctype = doc;
                    btnDoc1.BackColor = SystemColors.Control;
                    btnDoc2.BackColor = SystemColors.Window;
                    btnDoc3.BackColor = SystemColors.Control;
                    btnDoc4.BackColor = SystemColors.Control;
                    btnDoc5.BackColor = SystemColors.Control;
                    btnDoc6.BackColor = SystemColors.Control;
                    break;
                case 3:
                    tab3doctype = doc;
                    btnDoc1.BackColor = SystemColors.Control;
                    btnDoc2.BackColor = SystemColors.Control;
                    btnDoc3.BackColor = SystemColors.Window;
                    btnDoc4.BackColor = SystemColors.Control;
                    btnDoc5.BackColor = SystemColors.Control;
                    btnDoc6.BackColor = SystemColors.Control;
                    break;
                case 4:
                    tab4doctype = doc;
                    btnDoc1.BackColor = SystemColors.Control;
                    btnDoc2.BackColor = SystemColors.Control;
                    btnDoc3.BackColor = SystemColors.Control;
                    btnDoc4.BackColor = SystemColors.Window;
                    btnDoc5.BackColor = SystemColors.Control;
                    btnDoc6.BackColor = SystemColors.Control;
                    break;
                case 5:
                    tab5doctype = doc;
                    btnDoc1.BackColor = SystemColors.Control;
                    btnDoc2.BackColor = SystemColors.Control;
                    btnDoc3.BackColor = SystemColors.Control;
                    btnDoc4.BackColor = SystemColors.Control;
                    btnDoc5.BackColor = SystemColors.Window;
                    btnDoc6.BackColor = SystemColors.Control;
                    break;
                case 6:
                    tab6doctype = doc;
                    btnDoc1.BackColor = SystemColors.Control;
                    btnDoc2.BackColor = SystemColors.Control;
                    btnDoc3.BackColor = SystemColors.Control;
                    btnDoc4.BackColor = SystemColors.Control;
                    btnDoc5.BackColor = SystemColors.Control;
                    btnDoc6.BackColor = SystemColors.Window;
                    break;
                default:
                    throw (new ArgumentException());
            }
            activetab = tab;
        }

        /// <summary>
        /// Closes all tabs.
        /// </summary>
        public void CloseAll()
        {
            for (byte i = 1; i < 7; i++)
            {
                CloseTab(i);
            }
            TabsVisible = 0;
        }

        /// <summary>
        /// Closes all tabs except for the specified one.
        /// </summary>
        /// <param name="tab">The tab to leave open.</param>
        void CloseOthers(byte tab)
        {
            for (byte i = 1; i < 7; i++)
            {
                if (i == tab)
                {
                    continue;
                }
                else
                {
                    CloseTab(i);
                }
            }
            TabsVisible = 1;
        }

        /// <summary>
        /// Closes the specified tab.
        /// </summary>
        /// <param name="tab">The tab that will be closed.</param>
        void CloseTab(byte tab) //This method closes a tab and shifts the other tabs to the left.
        {
            switch (tab)
            {
                case 1:
                    btnDoc1.Visible = false;
                    btnCloseDoc1.Visible = false;
                    btnCloseDoc2.Location = new Point(btnCloseDoc2.Location.X - 116, btnCloseDoc2.Location.Y);
                    btnCloseDoc3.Location = new Point(btnCloseDoc3.Location.X - 116, btnCloseDoc3.Location.Y);
                    btnCloseDoc4.Location = new Point(btnCloseDoc4.Location.X - 116, btnCloseDoc4.Location.Y);
                    btnCloseDoc5.Location = new Point(btnCloseDoc5.Location.X - 116, btnCloseDoc5.Location.Y);
                    btnCloseDoc6.Location = new Point(btnCloseDoc6.Location.X - 116, btnCloseDoc6.Location.Y);
                    btnDoc2.Location = new Point(btnDoc2.Location.X - 116, btnDoc2.Location.Y);
                    btnDoc3.Location = new Point(btnDoc3.Location.X - 116, btnDoc3.Location.Y);
                    btnDoc4.Location = new Point(btnDoc4.Location.X - 116, btnDoc4.Location.Y);
                    btnDoc5.Location = new Point(btnDoc5.Location.X - 116, btnDoc5.Location.Y);
                    btnDoc6.Location = new Point(btnDoc6.Location.X - 116, btnDoc6.Location.Y);
                    SetActiveDocument(DocumentType.None, 1);
                    tab1file = "";
                    break;
                case 2:
                    btnDoc2.Visible = false;
                    btnCloseDoc2.Visible = false;
                    btnCloseDoc3.Location = new Point(btnCloseDoc3.Location.X - 116, btnCloseDoc3.Location.Y);
                    btnCloseDoc4.Location = new Point(btnCloseDoc4.Location.X - 116, btnCloseDoc4.Location.Y);
                    btnCloseDoc5.Location = new Point(btnCloseDoc5.Location.X - 116, btnCloseDoc5.Location.Y);
                    btnCloseDoc6.Location = new Point(btnCloseDoc6.Location.X - 116, btnCloseDoc6.Location.Y);
                    btnDoc3.Location = new Point(btnDoc3.Location.X - 116, btnDoc3.Location.Y);
                    btnDoc4.Location = new Point(btnDoc4.Location.X - 116, btnDoc4.Location.Y);
                    btnDoc5.Location = new Point(btnDoc5.Location.X - 116, btnDoc5.Location.Y);
                    btnDoc6.Location = new Point(btnDoc6.Location.X - 116, btnDoc6.Location.Y);
                    SetActiveDocument(tab1doctype, 1);
                    tab2file = "";
                    break;
                case 3:
                    btnDoc3.Visible = false;
                    btnCloseDoc3.Visible = false;
                    btnCloseDoc4.Location = new Point(btnCloseDoc4.Location.X - 116, btnCloseDoc4.Location.Y);
                    btnCloseDoc5.Location = new Point(btnCloseDoc5.Location.X - 116, btnCloseDoc5.Location.Y);
                    btnCloseDoc6.Location = new Point(btnCloseDoc6.Location.X - 116, btnCloseDoc6.Location.Y);
                    btnDoc4.Location = new Point(btnDoc4.Location.X - 116, btnDoc4.Location.Y);
                    btnDoc5.Location = new Point(btnDoc5.Location.X - 116, btnDoc5.Location.Y);
                    btnDoc6.Location = new Point(btnDoc6.Location.X - 116, btnDoc6.Location.Y);
                    SetActiveDocument(tab2doctype, 2);
                    tab3file = "";
                    break;
                case 4:
                    btnDoc4.Visible = false;
                    btnCloseDoc4.Visible = false;
                    btnCloseDoc5.Location = new Point(btnCloseDoc5.Location.X - 116, btnCloseDoc5.Location.Y);
                    btnCloseDoc6.Location = new Point(btnCloseDoc6.Location.X - 116, btnCloseDoc6.Location.Y);
                    btnDoc5.Location = new Point(btnDoc5.Location.X - 116, btnDoc5.Location.Y);
                    btnDoc6.Location = new Point(btnDoc6.Location.X - 116, btnDoc6.Location.Y);
                    SetActiveDocument(tab3doctype, 3);
                    tab4file = "";
                    break;
                case 5:
                    btnDoc5.Visible = false;
                    btnCloseDoc5.Visible = false;
                    btnCloseDoc6.Location = new Point(btnCloseDoc6.Location.X - 116, btnCloseDoc6.Location.Y);
                    btnDoc6.Location = new Point(btnDoc6.Location.X - 116, btnDoc6.Location.Y);
                    SetActiveDocument(tab4doctype, 4);
                    tab5file = "";
                    break;
                case 6:
                    btnDoc6.Visible = false;
                    btnCloseDoc6.Visible = false;
                    SetActiveDocument(tab5doctype, 5);
                    tab6file = "";
                    break;
            }
            TabsVisible--;
        }

        public event EventHandler TabSelected;
        public event EventHandler TextDocumentEdited;
        public event EventHandler ProjectPropertiesChanged;
        public event EventHandler PresetSaved;
        public event EventHandler TabClosed;

        private void btnDoc1_Click(object sender, EventArgs e)
        {
            SetActiveDocument(Tab1_DocumentType, 1);
            TabSelected?.Invoke(this, e);
        }

        private void btnDoc2_Click(object sender, EventArgs e)
        {
            SetActiveDocument(Tab2_DocumentType, 2);
            TabSelected?.Invoke(this, e);
        }

        private void btnDoc3_Click(object sender, EventArgs e)
        {
            SetActiveDocument(Tab3_DocumentType, 3);
            TabSelected?.Invoke(this, e);
        }

        private void btnDoc4_Click(object sender, EventArgs e)
        {
            SetActiveDocument(Tab4_DocumentType, 4);
            TabSelected?.Invoke(this, e);
        }

        private void btnDoc5_Click(object sender, EventArgs e)
        {
            SetActiveDocument(Tab5_DocumentType, 5);
            TabSelected?.Invoke(this, e);
        }

        private void btnDoc6_Click(object sender, EventArgs e)
        {
            SetActiveDocument(Tab6_DocumentType, 6);
            TabSelected?.Invoke(this, e);
        }

        private void btnCloseDoc1_Click(object sender, EventArgs e)
        {
            CloseTab(1);
            TabClosed?.Invoke(this, e);
        }

        private void btnCloseDoc2_Click(object sender, EventArgs e)
        {
            CloseTab(2);
            TabClosed?.Invoke(this, e);
        }

        private void btnCloseDoc3_Click(object sender, EventArgs e)
        {
            CloseTab(3);
            TabClosed?.Invoke(this, e);
        }

        private void btnCloseDoc4_Click(object sender, EventArgs e)
        {
            CloseTab(4);
            TabClosed?.Invoke(this, e);
        }

        private void btnCloseDoc5_Click(object sender, EventArgs e)
        {
            CloseTab(5);
            TabClosed?.Invoke(this, e);
        }

        private void btnCloseDoc6_Click(object sender, EventArgs e)
        {
            CloseTab(6);
            TabClosed?.Invoke(this, e);
        }

        private void rtbTextDocumentBody_TextChanged(object sender, EventArgs e)
        {
            if (highlightCode == true)
            {
                foreach (string item in languageKeywords)
                {
                    HighlightAll(item, Color.Blue);
                }
            }
            TextDocumentEdited?.Invoke(this, e);
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            TabClosed?.Invoke(this, e);
        }

        private void ttpInfo_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            TabForms.frmAddQuestion frmAddQuestion = new TabForms.frmAddQuestion();
            frmAddQuestion.ShowDialog();
        }

        private void chkPasswordProtect_CheckedChanged(object sender, EventArgs e)
        {
            pnlPassword.Enabled = chkPasswordProtect.Checked;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                EnhancedMessageBox frmCustomMessageBox = new EnhancedMessageBox();
                frmCustomMessageBox.ShowMessage(Resources.str_error, Resources.str_password_blank_error, SystemIcons.Error.ToBitmap());
            }
            else
            {
                if (txtConfirmPassword.Text == "")
                {
                    EnhancedMessageBox frmCustomMessageBox = new EnhancedMessageBox();
                    frmCustomMessageBox.ShowMessage(Resources.str_error, Resources.str_password_not_confirmed_error, SystemIcons.Error.ToBitmap());
                }
                else
                {
                    if (txtPassword.Text != txtConfirmPassword.Text)
                    {
                        EnhancedMessageBox frmCustomMessageBox = new EnhancedMessageBox();
                        frmCustomMessageBox.ShowMessage(Resources.str_error, Resources.str_password_mismatch_error, SystemIcons.Error.ToBitmap());
                    }
                    else
                    {
                        DialogResult passwordChangeConfirmation = DialogResult.None;
                        EnhancedMessageBox frmCustomMessageBox = new EnhancedMessageBox();
                        passwordChangeConfirmation = frmCustomMessageBox.ShowMessage(
                            Resources.str_confirm_password_change_title, //Title
                            Resources.str_confirm_password_change_message, //Message
                            SystemIcons.Warning.ToBitmap(), //Icon
                            frmCustomMessageBox.btn3, //Default button
                            frmCustomMessageBox.btn3, //Cancel button
                            false, //Button 1 is visible.
                            true, //Button 2 is visible.
                            true, //Button 3 is visible.
                            "", //Button 1 Text
                            "Change Password", //Button 2 Text
                            "Cancel", //Button 3 Text
                            DialogResult.None, //Button 1 DialogResult
                            DialogResult.OK, //Button 2 DialogResult
                            DialogResult.Cancel //Button 3 DialogResult
                        );
                        if (passwordChangeConfirmation == DialogResult.OK)
                        {
                            projectPassword = txtPassword.Text;
                            ProjectPropertiesChanged?.Invoke(this, e);
                            MessageBox.Show("Your password has been changed.", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTextDocumentBody.SelectAll(); //Select all of the text in the text box.
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTextDocumentBody.SelectedText.Remove(0, rtbTextDocumentBody.SelectedText.Length); //Delete all selected text.
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTextDocumentBody.Paste(); //Paste the data on the clipboard.
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTextDocumentBody.Copy(); //Copy the selected text.
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTextDocumentBody.Cut(); //Move the selected text to the clipboard.
        }

        private void strikethroughToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetFontStyle(boldToolStripMenuItem.Checked, italicToolStripMenuItem.Checked, underlineToolStripMenuItem.Checked, strikethroughToolStripMenuItem.Checked);
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetFontStyle(boldToolStripMenuItem.Checked, italicToolStripMenuItem.Checked, underlineToolStripMenuItem.Checked, strikethroughToolStripMenuItem.Checked);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetFontStyle(boldToolStripMenuItem.Checked, italicToolStripMenuItem.Checked, underlineToolStripMenuItem.Checked, strikethroughToolStripMenuItem.Checked);
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetFontStyle(boldToolStripMenuItem.Checked, italicToolStripMenuItem.Checked, underlineToolStripMenuItem.Checked, strikethroughToolStripMenuItem.Checked);
        }

        private void preset1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SavePreset(1);
            PresetSaved?.Invoke(this, e);
        }

        private void preset2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SavePreset(2);
            PresetSaved?.Invoke(this, e);
        }

        private void preset3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SavePreset(3);
            PresetSaved?.Invoke(this, e);
        }

        private void preset4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SavePreset(4);
            PresetSaved?.Invoke(this, e);
        }

        private void preset5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SavePreset(5);
            PresetSaved?.Invoke(this, e);
        }

        private void preset6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SavePreset(6);
            PresetSaved?.Invoke(this, e);
        }

        private void findToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TabForms.frmFind frmFind = new TabForms.frmFind();
            frmFind.textBox = rtbTextDocumentBody;
            frmFind.Show();
        }

        private void replaceToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUnforseenEvent_Click(object sender, EventArgs e)
        {
            TabForms.frmAddUnforseenEvent frmAddUnforseenEvent = new TabForms.frmAddUnforseenEvent();
            if (frmAddUnforseenEvent.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbEnabledFeatures.CheckedItems.Count; i++)
            {
                clbEnabledFeatures.SetItemChecked(i, true);
            }
        }

        private void btnUncheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbEnabledFeatures.CheckedItems.Count; i++)
            {
                clbEnabledFeatures.SetItemChecked(i, false);
            }
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            if (clbUnits.SelectedIndex > 0) //If the selected item is not at the top of the list...
            {
                int prev = clbUnits.SelectedIndex - 1; //Store an integer that is one less than the currently selected index.
                clbUnits.Items.Insert(clbUnits.SelectedIndex - 1, clbUnits.SelectedItem); //Insert a copy of the item above the selected item into the previous index.
                clbUnits.Items.RemoveAt(clbUnits.SelectedIndex); //Remove the selected item.
                clbUnits.SetSelected(prev, true); //Select the item at the previous index.
            }
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            if (clbUnits.SelectedIndex < clbUnits.Items.Count - 1) //If the selected item is not at the bottom of the list...
            {
                int next = clbUnits.SelectedIndex + 1; //Store an integer that is one more than the currently selected index.
                clbUnits.Items.Insert(clbUnits.SelectedIndex + 1, clbUnits.SelectedItem); //Insert a copy of the item below the selected item into the previous index.
                clbUnits.Items.RemoveAt(clbUnits.SelectedIndex); //Remove the selected item.
                clbUnits.SetSelected(next, true); //Select the item at the next index.
            }
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            clbUnits.Items.Add("New Unit");
        }

        private void btnRemoveUnit_Click(object sender, EventArgs e)
        {
            EnhancedMessageBox objConfirmation = new EnhancedMessageBox();
            if (objConfirmation.Confirmation("Acadica Lesson Studio", "Are you sure you wish to permanently delete the selected units? The files associated with the selected units will be permanently deleted!", SystemIcons.Exclamation.ToBitmap(), "Remove " + clbUnits.SelectedItems.Count + " Units", "Cancel") == DialogResult.OK)
            {
                foreach (object item in clbUnits.SelectedItems)
                {
                    clbUnits.Items.Remove(item);
                    UnitsRemoved?.Invoke(this, e);
                }
            }
        }

        private void dtpLessonStartDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                mclCalendar.MinDate = dtpLessonStartDate.Value;
            }
            catch (ArgumentOutOfRangeException)
            {
                EnhancedMessageBox objMessage = new EnhancedMessageBox();
                objMessage.ShowMessage("Error", "The lesson start date must be before the lesson end date.", SystemIcons.Error.ToBitmap());
            }
        }

        private void dtpLessonEndDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                mclCalendar.MaxDate = dtpLessonEndDate.Value;
            }
            catch (ArgumentOutOfRangeException)
            {
                EnhancedMessageBox objMessage = new EnhancedMessageBox();
                objMessage.ShowMessage("Error", "The lesson end date must be after the lesson start date.", SystemIcons.Error.ToBitmap());
            }
        }

        private void mclCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblDate.Text = mclCalendar.SelectionStart.Date.ToLongDateString();
        }

        private void TabbedDocuments_Load(object sender, EventArgs e)
        {
            mclCalendar.SelectionStart = DateTime.Today;
        }

        private void btnUnitProperties_Click(object sender, EventArgs e)
        {
            TabForms.frmUnitProperties frmUnitProperties = new TabForms.frmUnitProperties();
            if (frmUnitProperties.ShowDialog() == DialogResult.OK)
            {
                clbUnits.Items[clbUnits.SelectedIndex] = frmUnitProperties.txtName.Text;
            }
        }
    }
}