using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
      }



      private void btnDo_Click(object sender, EventArgs e)
      {
         var uriYouTube = new Uri(txtUrlSource.Text);
         //this.txtSourceMediaId.Text = MediaInfoFile.GetYouTubeId(uriYouTube);
         var mediaInfoFileTargetBasePath = ConfigurationManager.AppSettings["BaseTargetMediaDirPathDefault"];
         var mfi = new MediaInfoFile(mediaInfoFileTargetBasePath, MediaInfoFileTemplatePath, txtMediaDirRelativeWithoutYoutubeId.Text, uriYouTube);

         //TODO: how to download Youtube file programmatically? or perhaps how to command keepvid.com programmatically?

         var keyValuePairDict = new Dictionary<string, string>();
         keyValuePairDict.Add("__FILE-NAME-WITHOUT-PATH__", mfi.DirTargetRelative);
         keyValuePairDict.Add("__DOWNLOAD-TOOL__", txtDownloadTool.Text);
         keyValuePairDict.Add("__YOUTUBE-PUBLISHER__", "IMPLEMENT_LOGIC");   //TODO: find out publisher-info using Google-API.
         keyValuePairDict.Add("__MEDIA-LENGTH__", "IMPLEMENT_LOGIC");     //TODO: find out media-format from media-file itself
         keyValuePairDict.Add("__MEDIA-FORMAT__", "IMPLEMENT_LOGIC");     //TODO: find out media-format from media-file itself
         keyValuePairDict.Add("__DOWNLOAD-DATE__", DateTime.Now.ToString("u"));
         keyValuePairDict.Add("__ADDITIONAL-INFO__", txtAdditionalInfo.Text);
         
         //TODO: Add more information from file: size, format etc.

         mfi.CreateFolderAndFile(keyValuePairDict, txtMediaDirRelativeWithoutYoutubeId.Text);
      }
   }
}
