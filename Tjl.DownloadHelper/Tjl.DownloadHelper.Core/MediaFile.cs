using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Runtime.CompilerServices;
using System.Web;

namespace Tjl.DownloadHelper.Core
{
   public class MediaFile
   {
      public string MediaFileDirBase { get; }
      public string FilePathTemplate { get; }

      public Uri YouTubeUri { get; }
      public string DirTargetRelative { get; }

      public string FilePathTargetFull { get; }


      public MediaFile(string mediaFileDirBase, string filePathTemplate, string mediaDirRelativeWithoutYoutubeId, Uri youTubeUri)
      {
         MediaFileDirBase = mediaFileDirBase;
         FilePathTemplate = filePathTemplate;
         YouTubeUri = youTubeUri;

         DirTargetRelative = GetDirTargetRelative(mediaDirRelativeWithoutYoutubeId, youTubeUri);

         FilePathTargetFull = Path.Combine(mediaFileDirBase, mediaDirRelativeWithoutYoutubeId, $"{DirTargetRelative}.txt");
      }

      /// <summary>
      /// https://www.youtube.com/watch?v=SbFi2gQytq8
      /// </summary>
      /// <param name="youTubeUri"></param>
      /// <returns></returns>
      private static string GetYouTubeId(Uri youTubeUri)
      {
         //TODO: check inputs

         var query = HttpUtility.ParseQueryString(youTubeUri.Query); //TODO: check that uri is conform (or even exists?).
         var id = query.Get("v");

         return id;
      }

      public static string GetDirTargetRelative(string filenameWithoutPathAndPostfix, Uri youTubeUri)
      {
         var utId = GetYouTubeId(youTubeUri);
         return $"{filenameWithoutPathAndPostfix}__YouTube_{utId}";
      }


      private string ReplaceKeywordsInFile(string fileContentTemplate, Dictionary<string, string> keyValuePairList)
      {
         var fileContentCurr = fileContentTemplate;

         foreach (var mykeyValuePair in keyValuePairList)
         {
            fileContentCurr = fileContentCurr.Replace(mykeyValuePair.Key, mykeyValuePair.Value);
         }
         return fileContentCurr;
      }

      public void CreateFolderAndFile(Dictionary<string, string> keyValuePairList, string targetDirPath)
      {
         string fileContentTemplate = File.ReadAllText(FilePathTemplate);
         var fileContentReplaced = ReplaceKeywordsInFile(fileContentTemplate, keyValuePairList);
         var targetDir = Path.Combine(MediaFileDirBase, DirTargetRelative);
         Directory.CreateDirectory(targetDir);     //TODO: Warn if exists
         File.WriteAllText(this.FilePathTargetFull, fileContentReplaced);  //TODO: Warn if exists
      }
   }
}
