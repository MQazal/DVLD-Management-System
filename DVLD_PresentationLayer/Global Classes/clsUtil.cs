using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace DVLD_PresentationLayer.Global_Classes
{
    public class clsUtil
    {
        public enum enMode { AddNew, Update }

        public static string PrintFinishMessage(byte ModeNumber, string AddModeMessage = "", string UpdateModeMessage = "")
        {
            return ModeNumber == 0 ? AddModeMessage : UpdateModeMessage;
        }

        public static string PrintFinishMessage(enMode BitValue, string AddModeMessage = "", string UpdateModeMessage = "")
        {
            return BitValue == enMode.AddNew ? AddModeMessage : UpdateModeMessage;
        }

        public static string GetBitString(byte BitValue, string OneBitString, string ZeroBitString)
        {
            return BitValue == 1 ? OneBitString : ZeroBitString;
        }

        public static void LoadFieldsPictures(Control Parent, ImageList List)
        {
            foreach (PictureBox pcbx in Parent.Controls.OfType<PictureBox>().OrderBy(pcbx => Convert.ToInt32(pcbx.Tag)))
            {
                pcbx.Image = List.Images[Convert.ToInt32(pcbx.Tag)];
            }
        }

        public static void SetPersonImageFromPath(string ImagePath, PictureBox PersonImageBox)
        {
            if (!string.IsNullOrEmpty(ImagePath))
            {
                PersonImageBox.Image = Image.FromFile(ImagePath);
                return;
            }
            PersonImageBox.Image = Image.FromFile(@"C:\Programming Path\Programming Advices.com\Backend Development Track\Course#19\Icons\no-image-100.png");
        }

        public static void SetRecordsNumber(Label label, DataGridView dgv)
        {
            label.Text = dgv.Rows.Count.ToString();
        }

        public static void SetRecordsNumber(Label label, DataView View)
        {
            label.Text = View.Count.ToString();
        }

        public static void SetScreenHeaderData(PictureBox pcbxPageImage, Image image)
        {
            pcbxPageImage.Image = image;
        }

        public static void SetScreenHeaderData(PictureBox pcbxPageImage, Image image, Label lblTitle, string Title)
        {
            lblTitle.Text = Title;
            SetScreenHeaderData(pcbxPageImage, image);
        }

        public static void SetDefaultStateOfFilter(ComboBox OptionsBox, TextBox txbxFilter)
        {
            OptionsBox.SelectedItem = "None";
            txbxFilter.Visible = false;
        }

        public static void SetDefaultStateOfFilter(ComboBox OptionsBox)
        {
            OptionsBox.SelectedItem = "None";
            OptionsBox.Visible = false;
        }

        public static void SetVisibilityMode(Control ctrl1, bool VisibilityStatus1, Control ctrl2, bool VisibilityStatus2)
        {
            ctrl1.Visible = VisibilityStatus1;
            ctrl2.Visible = VisibilityStatus2;
        }
    }
}