using System.IO;
using NUnit.Framework;

namespace Tjl.DownloadHelper.Test.Unit.Ms
{
   [TestFixture]
   public class MediaInfoDotNet_MediaFileTest
   {
      public static string MediaFilePathPic_Jpg_01 = Path.Combine(TestContext.CurrentContext.TestDirectory, @"DataInput\TestPic01.jpg");
      public static string MediaFilePathAudio_Mp3_01 = Path.Combine(TestContext.CurrentContext.TestDirectory, @"DataInput\Adam Holzman_1997_The Big Picture_10of12_Comrad Russell.mp3");
      public static string MediaFilePathAudio_Mp4_01 = Path.Combine(TestContext.CurrentContext.TestDirectory, @"DataInput\Jamiroquai__1993__Live at Club Citta Tokyo 1993__Interview Part 2__YouTube_gqjUbrURjFE.mp4");
      
      const string ExpectedUrlInfo = "http://MediaArea.net/MediaInfo";

      [Test]
      public void MediaInfo__MediaFile__Init__ValidJpg()
      {
         
         var mio = new MediaInfoDotNet.MediaFile(MediaFilePathPic_Jpg_01);
         Assert.AreEqual(ExpectedUrlInfo, mio.InfoUrl, nameof(MediaInfoDotNet.MediaFile.InfoUrl));
      }

      [Test]
      public void MediaInfo__MediaFile__Init__ValidMp3()
      {
         var mio = new MediaInfoDotNet.MediaFile(MediaFilePathAudio_Mp3_01);
         Assert.AreEqual(ExpectedUrlInfo, mio.InfoUrl, nameof(MediaInfoDotNet.MediaFile.InfoUrl));
      }

      [Test]
      public void MediaInfo__MediaFile__Init__ValidMp4()
      {
         var mio = new MediaInfoDotNet.MediaFile(MediaFilePathAudio_Mp4_01);
         Assert.AreEqual(ExpectedUrlInfo, mio.InfoUrl, nameof(MediaInfoDotNet.MediaFile.InfoUrl));
      }
   }
}