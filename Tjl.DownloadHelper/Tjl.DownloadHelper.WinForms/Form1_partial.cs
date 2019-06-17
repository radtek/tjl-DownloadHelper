using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Tjl.DownloadHelper.Core;

namespace Tjl.DownloadHelper.WinForms
{
   partial class Form1
   {
      private const string MediaInfoFileTemplateTxtPathWithoutFilePrefix = @".\DataInput\MediaInfoTemplate";

      private const string MediaDownloadToolName_ClipConverter = "ClipConverter.cc";
      private const string MediaDownloadToolName_AceThinker = @"AceThinker.com";
      private const string MediaDownloadToolName_KeepVid = @"KeepVid.com";

      private void Form1_Load(object sender, EventArgs e)
      {
         //var downloadToolDefault = ConfigurationManager.AppSettings["DownloadToolDefault"];
         //txtDownloadTool.Text = downloadToolDefault;
         CmbDownloadTool.Items.Add(MediaDownloadToolName_ClipConverter);
         CmbDownloadTool.Items.Add(MediaDownloadToolName_AceThinker);
         CmbDownloadTool.Items.Add(MediaDownloadToolName_KeepVid);
         CmbDownloadTool.SelectedIndex = 0;

         txtMediaFolderBase.Text = ConfigurationManager.AppSettings["BaseTargetMediaDirPathDefault"];

         CmbMediaDescFileType.Items.Add(MediaDescFileTypeEnum.Text.ToString());
         CmbMediaDescFileType.Items.Add(MediaDescFileTypeEnum.MarkDown.ToString());
         CmbMediaDescFileType.SelectedIndex = (int)MediaDescFileTypeEnum.MarkDown - 1;


         var asmbName = Assembly.GetEntryAssembly().GetName();
         this.Text = $"{asmbName.Name}_v{asmbName.Version}";
      }

      private void btnDo_Click(object sender, EventArgs e)
      {
         try
         {
            var uriYouTube = new Uri(txtUrlSource.Text);
            //this.txtSourceMediaId.Text = MediaFile.GetYouTubeId(uriYouTube);

            var fileTypeEnum = (MediaDescFileTypeEnum)this.CmbMediaDescFileType.SelectedIndex + 1;
            if (!Enum.IsDefined(fileTypeEnum.GetType(), fileTypeEnum))
            {
               throw new ApplicationException($"Unknown MediaFile type with index [{(int)fileTypeEnum}]");
            }

            var mediaDescInfoFilePath = GetMediaDescTemplateFilePath(fileTypeEnum);

            var mfi = new MediaFile(txtMediaFolderBase.Text, mediaDescInfoFilePath, txtMediaDirRelativeWithoutYoutubeId.Text, uriYouTube);

            //TODO: how to download Youtube file programmatically? or perhaps how to command keepvid.com programmatically?

            var keyValuePairDict = new Dictionary<string, string>
         {
            {"__FILE-NAME-WITHOUT-PATH__", mfi.FileNameWithoutPostFix},
            {"__DOWNLOAD-TOOL__", CmbDownloadTool.Text},
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
         catch (Exception ex)
         {
            MessageBox.Show($"Exception Thrown:\n\n{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
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

      private FileInfo GetMediaDescTemplateFilePath(MediaDescFileTypeEnum mediaDescFileTypeEnum)
      {
         var filePath = MediaInfoFileTemplateTxtPathWithoutFilePrefix;

         switch (mediaDescFileTypeEnum)
         {
            case MediaDescFileTypeEnum.MarkDown:
               {
                  filePath = $"{filePath}.md";
                  break;
               }
            case MediaDescFileTypeEnum.Text:
               {
                  filePath = $"{filePath}.txt";
                  break;
               }
            default:
               {
                  throw new ApplicationException($"Unexpected Media Description file Type [{mediaDescFileTypeEnum:G}{mediaDescFileTypeEnum:D}]");
               }
         }

         var fiMediaDesc = new FileInfo(filePath);


         if (!fiMediaDesc.Exists)
         {
            throw new ApplicationException($"Unexpected Media Description file Type [{mediaDescFileTypeEnum:G}{mediaDescFileTypeEnum:D}]");
         }
         else
         {
            return fiMediaDesc;
         }
      }
   }
}
