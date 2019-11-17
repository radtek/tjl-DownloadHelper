using NUnit.Framework;
using Tjl.MediaInfo;

namespace Tjl.DownloadHelper.Test.Unit.Ms
{
   [TestFixture]
   public class MediaInfoWrapperTest
   {
      [Test]
      public void GetMediaInfo__Image__jpg__expectedProperties()
      {
         //* Arrange
         var expectedMediaFile = new MediaFile01_Image_jpg();

         //* act
         var mediaFile = MediaInfoWrapper.GetMediaInfo(expectedMediaFile.FilePathAbs);

         //* Assert
         expectedMediaFile.TestProperties(mediaFile);
      }

      [Test]
      public void GetMediaInfo__Audio__Mp3__expectedProperties()
      {
         //* Arrange
         var expectedMediaFile = new MediaFile01_Audio_Mp3_AdamHolzman();

         //* act
         var mediaFile = MediaInfoWrapper.GetMediaInfo(expectedMediaFile.FilePathAbs);

         //* Assert
         expectedMediaFile.TestProperties(mediaFile);
      }

      [Test]
      public void GetMediaInfo__AdamHolzman__Mp3__expectedProperties()
      {
         //* Arrange
         var expectedMediaFile = new MediaFile03_Video_Mp4_Jamiroquai();

         //* act
         var mediaFile = MediaInfoWrapper.GetMediaInfo(expectedMediaFile.FilePathAbs);

         //* Assert
         expectedMediaFile.TestProperties(mediaFile);
      }

   }
}
