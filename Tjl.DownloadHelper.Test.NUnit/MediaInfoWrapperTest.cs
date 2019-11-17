using System.IO;
using NUnit.Framework;
using Tjl.DownloadHelper.Core;

namespace Tjl.DownloadHelper.Test.Unit.Ms
{
   public class MediaInfoWrapperTest
   {
      [SetUp]
      public void Setup()
      {
      }

      [TestFixture]
      public class MediaInfoDotNetTest
      {
         public static string MediaFilePathPic_Jpg_01 = Path.Combine(TestContext.CurrentContext.TestDirectory, @".\DataInput\TestPic01.jpg");
         public static string MediaFilePathAudio_Mp3_01 = Path.Combine(TestContext.CurrentContext.TestDirectory, @".\DataInput\Adam Holzman_1997_The Big Picture_10of12_Comrad Russell.mp3");
         public static string MediaFilePathAudio_Mp4_01 = Path.Combine(TestContext.CurrentContext.TestDirectory, @".\DataInput\Jamiroquai__1993__Live at Club Citta Tokyo 1993__Interview Part 2__YouTube_gqjUbrURjFE.mp4");

         const string ExpectedUrlInfo = "http://MediaArea.net/MediaInfo";

         [Test]
         public void MediaInfo__MediaFile__Init__ValidJpg()
         {

            var miw = MediaInfo.;
            var mediaFile = miw.GetMediaInfo(MediaFilePathAudio_Mp3_01);
            Assert.AreEqual("asdsad", mediaFile.album, nameof(MediaFile.album));
            Assert.AreEqual("asdsad", mediaFile.miGetString("Album"), $"{nameof(mediaFile.miGetString)} 'Album'";
         }

      }
   }