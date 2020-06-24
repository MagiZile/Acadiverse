using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagiZile.CustomUI
{
    public partial class frmStyleInfo : Form
    {
        public frmStyleInfo()
        {
            InitializeComponent();
        }

        string style = "";

        void Upload()
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create("ftp://www.magizile.com/uploads/looknfeel/" + Path.GetFileName(style));
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential("u73171616", "L2a2r3!@#$");
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = false;
                FileStream stream = File.OpenRead(style);
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                stream.Close();
                Stream reqStream = request.GetRequestStream();
                reqStream.Write(buffer, 0, buffer.Length);
                reqStream.Close();
            }
            catch(WebException)
            {
                EnhancedMessageBox frmErrorMessage = new EnhancedMessageBox();
                frmErrorMessage.ShowMessage("Upload Error", "Your look n' feel was not uploaded. Please check your network connection.");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Upload();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmStyleInfo_Load(object sender, EventArgs e)
        {
            EnhancedFileSelector frmSelectFile = new EnhancedFileSelector();
            frmSelectFile.Text = "Select Look n' Feel Style";
            if (frmSelectFile.ShowDialog() == DialogResult.OK)
            {
                style = frmSelectFile.Selection;
            }
            else
            {
                Close();
            }
        }
    }
}
