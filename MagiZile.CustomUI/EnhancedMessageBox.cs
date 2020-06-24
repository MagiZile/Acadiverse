using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagiZile.CustomUI
{
    public partial class EnhancedMessageBox : Form
    {
        public EnhancedMessageBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Returns a DialogResult based on the user's selection from a confirmation box.
        /// </summary>
        /// <param name="title">The message box title.</param>
        /// <param name="message">The message to display.</param>
        /// <param name="icon">The icon shown.</param>
        /// <param name="button1Text">Button 1 Text</param>
        /// <param name="button2Text">Button 2 Text</param>
        /// <returns>The DialogResult of the button pressed.</returns>
        public DialogResult Confirmation(string title, string message, Image icon, string button1Text = "OK", string button2Text = "Cancel")
        {
            return ShowMessage(
                title,
                message,
                icon,
                btn2,
                btn3,
                false,
                true,
                true,
                "",
                button1Text,
                button2Text,
                DialogResult.None,
                DialogResult.OK,
                DialogResult.Cancel
                );
        }

        /// <summary>
        /// Shows a message in the message box.
        /// </summary>
        /// <param name="title">The text in the title bar.</param>
        /// <param name="message">The message in the message box.</param>
        /// <returns>Returns the dialog result of the message box.</returns>
        public DialogResult ShowMessage(string title, string message)
        {
            Text = title;
            lblMessage.Text = message;
            btn3.DialogResult = DialogResult.OK;
            picIcon.Image = SystemIcons.Information.ToBitmap();
            btn3.Visible = true;
            btn3.Text = "OK";
            Width -= 156;
            btn2.Dispose();
            Width -= 156;
            btn1.Dispose();
            MaximumSize = Size;
            MinimumSize = Size;
            AcceptButton = btn3;
            CancelButton = btn3;
            ShowDialog();
            return DialogResult;
        }

        /// <summary>
        /// Shows a message in the message box.
        /// </summary>
        /// <param name="title">The text in the title bar.</param>
        /// <param name="message">The message in the message box.</param>
        /// <param name="icon">The icon shown in the message box.</param>
        /// <returns>Returns the dialog result of the message box.</returns>
        public DialogResult ShowMessage(string title, string message, Image icon)
        {
            Text = title;
            lblMessage.Text = message;
            btn3.DialogResult = DialogResult.OK;
            picIcon.Image = icon;
            btn3.Visible = true;
            btn3.Text = "OK";
            Width -= 156;
            btn2.Dispose();
            Width -= 156;
            btn1.Dispose();
            AcceptButton = btn3;
            CancelButton = btn3;
            Width = lblMessage.Width + 80;
            Height = lblMessage.Height + 50;

            if (icon == SystemIcons.Error.ToBitmap())
            {
                System.Media.SystemSounds.Hand.Play();
            }
            else if (icon == SystemIcons.Warning.ToBitmap())
            {
                System.Media.SystemSounds.Exclamation.Play();
            }
            else if (icon == SystemIcons.Information.ToBitmap())
            {
                System.Media.SystemSounds.Beep.Play();
            }
            ShowDialog();
            return DialogResult;
        }

        /// <summary>
        /// Shows a message in the message box.
        /// </summary>
        /// <param name="title">The text in the title bar.</param>
        /// <param name="message">The message in the message box.</param>
        /// <param name="icon">The icon shown in the message box.</param>
        /// <param name="defaultButton">The default button of the message box.</param>
        /// <param name="cancelButton">The cancel button of the message box.</param>
        /// <param name="Button1">Represents whether or not Button 1 is shown.</param>
        /// <param name="Button2">Represents whether or not Button 2 is shown.</param>
        /// <param name="Button3">Represents whether or not Button 3 is shown.</param>
        /// <param name="Button1Text">The text of Button 1.</param>
        /// <param name="Button2Text">The text of Button 2.</param>
        /// <param name="Button3Text">The text of Button 3.</param>
        /// <param name="Button1Result">The dialog result of Button 1.</param>
        /// <param name="Button2Result">The dialog result of Button 2.</param>
        /// <param name="Button3Result">The dialog result of Button 3.</param>
        /// <returns>Returns the dialog result of the message box.</returns>
        public DialogResult ShowMessage(string title, string message, Image icon, bool Button1 = false, bool Button2 = false, bool Button3 = true, string Button1Text = "", string Button2Text = "", string Button3Text = "OK")
        {
            Text = title;
            lblMessage.Text = message;
            btn3.DialogResult = DialogResult.OK;
            btn2.DialogResult = DialogResult.None;
            btn1.DialogResult = DialogResult.None;
            picIcon.Image = icon;
            btn3.Visible = Button3;
            btn2.Visible = Button2;
            btn1.Visible = Button1;
            btn3.Text = Button3Text;
            btn2.Text = Button2Text;
            btn1.Text = Button3Text;
            AcceptButton = btn3;
            CancelButton = btn3;
            if (Button1 == false)
            {
                Width -= 156;
                btn1.Dispose();
            }
            if (Button2 == false)
            {
                Width -= 156;
                btn2.Dispose();
            }
            if (Button3 == false)
            {
                Width -= 156;
                btn3.Dispose();
            }
            Height = lblMessage.Height + 90;
            Width = lblMessage.Width + 90;
            MaximumSize = Size;
            MinimumSize = Size;
            if (icon == SystemIcons.Error.ToBitmap())
            {
                System.Media.SystemSounds.Hand.Play();
            }
            else if (icon == SystemIcons.Warning.ToBitmap())
            {
                System.Media.SystemSounds.Asterisk.Play();
            }
            else if (icon == SystemIcons.Information.ToBitmap())
            {
                System.Media.SystemSounds.Beep.Play();
            }
            ShowDialog();
            return DialogResult;
        }

        /// <summary>
        /// Shows a message in the message box.
        /// </summary>
        /// <param name="title">The text in the title bar.</param>
        /// <param name="message">The message in the message box.</param>
        /// <param name="icon">The icon shown in the message box.</param>
        /// <param name="defaultButton">The default button of the message box.</param>
        /// <param name="cancelButton">The cancel button of the message box.</param>
        /// <param name="Button1">Represents whether or not Button 1 is shown.</param>
        /// <param name="Button2">Represents whether or not Button 2 is shown.</param>
        /// <param name="Button3">Represents whether or not Button 3 is shown.</param>
        /// <param name="Button1Text">The text of Button 1.</param>
        /// <param name="Button2Text">The text of Button 2.</param>
        /// <param name="Button3Text">The text of Button 3.</param>
        /// <param name="Button1Result">The dialog result of Button 1.</param>
        /// <param name="Button2Result">The dialog result of Button 2.</param>
        /// <param name="Button3Result">The dialog result of Button 3.</param>
        /// <returns>Returns the dialog result of the message box.</returns>
        public DialogResult ShowMessage(string title, string message, Image icon, Button defaultButton, Button cancelButton, bool Button1 = false, bool Button2 = false, bool Button3 = true, string Button1Text = "", string Button2Text = "", string Button3Text = "OK", DialogResult Button1Result = DialogResult.None, DialogResult Button2Result = DialogResult.None, DialogResult Button3Result = DialogResult.OK)
        {
            Text = title;
            lblMessage.Text = message;
            btn3.DialogResult = Button3Result;
            btn2.DialogResult = Button2Result;
            btn1.DialogResult = Button1Result;
            picIcon.Image = icon;
            btn3.Visible = Button3;
            btn2.Visible = Button2;
            btn1.Visible = Button1;
            btn3.Text = Button3Text;
            btn2.Text = Button2Text;
            btn1.Text = Button1Text;
            if (Button1 == false)
            {
                Width -= 156;
                btn1.Dispose();
            }
            if (Button2 == false)
            {
                Width -= 156;
                btn2.Dispose();
            }
            if (Button3 == false)
            {
                Width -= 156;
                btn3.Dispose();
            }
            Height = lblMessage.Height + 90;
            Width = lblMessage.Width + 90;
            AcceptButton = defaultButton;
            CancelButton = cancelButton;
            MaximumSize = Size;
            MinimumSize = Size;
            if (icon == SystemIcons.Error.ToBitmap())
            {
                System.Media.SystemSounds.Hand.Play();
            }
            else if (icon == SystemIcons.Warning.ToBitmap())
            {
                System.Media.SystemSounds.Asterisk.Play();
            }
            else if (icon == SystemIcons.Information.ToBitmap())
            {
                System.Media.SystemSounds.Beep.Play();
            }
            ShowDialog();
            return DialogResult;
        }

        public bool ShowConfirmation(string title, string message, string button1, string button2)
        {
            return ShowMessage(
                    title,
                    message,
                    SystemIcons.Exclamation.ToBitmap(),
                    btn1,
                    btn2,
                    false,
                    true,
                    true,
                    "",
                    button1,
                    button2,
                    DialogResult.None,
                    DialogResult.OK,
                    DialogResult.Cancel             
                ) == DialogResult.OK;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            DialogResult = btn3.DialogResult;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            DialogResult = btn2.DialogResult;

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            DialogResult = btn1.DialogResult;
        }
    }
}
