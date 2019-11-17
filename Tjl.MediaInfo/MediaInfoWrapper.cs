using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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