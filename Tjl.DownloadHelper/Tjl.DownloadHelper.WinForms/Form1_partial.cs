using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using Tjl.DownloadHelper.Core;

namespace Tjl.DownloadHelper.WinForms
{
   partial class Form1
   {
      private const string MediaInfoFileTemplatePath = @".\DataInput\MediaInfoTemplate.txt";

      private void Form1_Load(object sender, EventArgs e)
      {
         var downloadToolDefault = ConfigurationManager.AppSettings["DownloadToolDefault"];
         txtDownloadTool.Text = downloadToolDefault;

         txtMediaFolderBase.Text = ConfigurationManager.AppSettings["BaseTargetMediaDirPathDefault"];
      }

      private void btnDo_Click(object sender, EventArgs e)
      {
         var uriYouTube = new Uri(txtUrlSource.Text);
         //this.txtSourceMediaId.Text = MediaFile.GetYouTubeId(uriYouTube);
         var mfi = new MediaFile(txtMediaFolderBase.Text, MediaInfoFileTemplatePath, txtMediaDirRelativeWithoutYoutubeId.Text, uriYouTube);

         //TODO: how to download Youtube file programmatically? or perhaps how to command keepvid.com programmatically?

         var keyValuePairDict = new Dictionary<string, string>
         {
            {"__FILE-NAME-WITHOUT-PATH__", mfi.FileNameWithoutPostFix},
            {"__DOWNLOAD-TOOL__", txtDownloadTool.Text},
            {"__YOUTUBE-PUBLISHER__", txtMediaFilePublisher.Text},
            {"__MEDIA-LENGTH__", txtMediaLength.Text},
            {"__MEDIA-FORMAT__", txtMediaFormat.Text},
            {"__ORIGINAL-PUBLISHER__", txtOriginalPublisher.Text},
            {"__DOWNLOAD-DATE__", DateTime.Now.ToString("u")},
            {"__ADDITIONAL-INFO__", txtAdditionalInfo.Text}
         };
         //TODO: find out publisher-info using Google-API.
         //TODO: find out media-format from media-file itself 

         //TODO: Add more information from file: size, format etc.
         txtFilePathTarget.Text = mfi.FilePathTargetFull;

         var mbr = MessageBox.Show($"Copy Media-Link to Clipboard\n{mfi.FilePathTargetFull}.", "Copy To Clipboard?", MessageBoxButtons.YesNo);
         if (mbr == DialogResult.Yes)
         {
            System.Windows.Forms.Clipboard.SetDataObject(mfi.FilePathTargetFull, true);
         }

         mfi.CreateFolderAndFile(keyValuePairDict, txtMediaDirRelativeWithoutYoutubeId.Text);
      }

      private void btnCopyMediaLinkToClipboard_Click(object sender, EventArgs e)
      {
         if (string.IsNullOrWhiteSpace(txtFilePathTarget.Text))
         {
            var mbr = MessageBox.Show($"No medialink created", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
         }
         else
         {
            System.Windows.Forms.Clipboard.SetDataObject(txtFilePathTarget.Text, true);
         }
      }

      private void txtFilePathTarget_DoubleClick(object sender, EventArgs e)
      {
         txtFilePathTarget.SelectAll();
      }
   }
}
