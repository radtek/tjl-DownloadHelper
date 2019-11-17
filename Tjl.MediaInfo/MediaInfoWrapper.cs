using MediaInfoDotNet;

namespace Tjl.MediaInfo
{
   public class MediaInfoWrapper
   {
      public static MediaFile GetMediaInfo(string filepath)
      {
         return new MediaInfoDotNet.MediaFile(filepath);
      }
   }
}