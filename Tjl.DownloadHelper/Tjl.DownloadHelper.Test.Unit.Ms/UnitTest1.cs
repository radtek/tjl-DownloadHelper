using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tjl.DownloadHelper.Test.Unit.Ms
{
   [TestClass]
   public class UnitTest1
   {
      public const string MediaFilePathPic_Jpg_01 = @"DataInput\TestPic01.jpg";
      public const string MediaFilePathAudio_Mp3_01 = @"DataInput\Adam Holzman_1997_The Big Picture_10of12_Comrad Russell.mp3";
      public const string MediaFilePathAudio_Mp4_01 = @"DataInput\Jamiroquai__1993__Live at Club Citta Tokyo 1993__Interview Part 2__YouTube_gqjUbrURjFE.mp4";

      const string ExpectedUrlInfo = "http://MediaArea.net/MediaInfo";

      [TestMethod]
      public void MediaInfo__MediaFile__Init__ValidJpg()
      {
         
         var mio = new MediaInfoDotNet.MediaFile(MediaFilePathPic_Jpg_01);
         Assert.AreEqual(ExpectedUrlInfo, mio.InfoUrl, nameof(MediaInfoDotNet.MediaFile.InfoUrl));
      }

      [TestMethod]
      public void MediaInfo__MediaFile__Init__ValidMp3()
      {
         var mio = new MediaInfoDotNet.MediaFile(MediaFilePathAudio_Mp3_01);
         Assert.AreEqual(ExpectedUrlInfo, mio.InfoUrl, nameof(MediaInfoDotNet.MediaFile.InfoUrl));
      }

      [TestMethod]
      public void MediaInfo__MediaFile__Init__ValidMp4()
      {
         var mio = new MediaInfoDotNet.MediaFile(MediaFilePathAudio_Mp4_01);
         Assert.AreEqual(ExpectedUrlInfo, mio.InfoUrl, nameof(MediaInfoDotNet.MediaFile.InfoUrl));
      }
   }
}