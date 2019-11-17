using System;
using System.Collections.Generic;
using System.IO;
using MediaInfoDotNet;
using MediaInfoDotNet.Models;
using NUnit.Framework;

namespace Tjl.MediaInfo
{
   internal class MediaFileTestInstance
   {
      internal MediaFileTestInstance(string filePath)
      {

         if (!Path.IsPathRooted(filePath))
         {
            filePath = Path.Combine(TestContext.CurrentContext.TestDirectory, filePath);
         }

         if (!File.Exists(filePath))
         {
            throw new ApplicationException($"{nameof(filePath)}=[{filePath}] doesn't exist.'");
         }

         this.FilePathAbs = filePath;
      }

      protected internal void TestProperties(MediaFile mediaFileActual)
      {
         Assert.AreEqual(this.InfoUrl, mediaFileActual.InfoUrl, $"ERROR in {nameof(mediaFileActual.InfoUrl)}");
         Assert.AreEqual(this.HasStreams, mediaFileActual.HasStreams, $"ERROR in {nameof(mediaFileActual.HasStreams)}");
         Assert.AreEqual(this.InfoCodecs, mediaFileActual.InfoCodecs, $"ERROR in {nameof(mediaFileActual.InfoCodecs)}");
         Assert.AreEqual(this.InfoParameters, mediaFileActual.InfoParameters, $"ERROR in {nameof(mediaFileActual.InfoParameters)}");
         Assert.AreEqual(this.InfoVersion, mediaFileActual.InfoVersion, $"ERROR in {nameof(mediaFileActual.InfoVersion)}");
         Assert.AreEqual(this.Inform, mediaFileActual.Inform, $"ERROR in {nameof(mediaFileActual.Inform)}");
         Assert.AreEqual(this.InformComplete, mediaFileActual.InformComplete, $"ERROR in {nameof(mediaFileActual.InformComplete)}");

         Assert.IsNotNull(mediaFileActual.General, $"ERROR in {nameof(mediaFileActual.General)}"); //*TODO: test GeneralStream in more detail.

         Assert.IsNotNull(mediaFileActual.Menu, $"ERROR in {nameof(mediaFileActual.Menu)}");
         Assert.AreEqual(this.MenuStreamsQty, mediaFileActual.Menu.Count, $"ERROR in {nameof(mediaFileActual.Menu)}.Count");   //*TODO: test MenuStreams in more detail.

         Assert.IsNotNull(mediaFileActual.Text, $"ERROR in {nameof(mediaFileActual.Text)}");
         Assert.AreEqual(this.TextStreamsQty, mediaFileActual.Text.Count, $"ERROR in {nameof(mediaFileActual.Text)}.Count");   //*TODO: test TextStreams in more detail.

         Assert.IsNotNull(mediaFileActual.Other, $"ERROR in {nameof(mediaFileActual.Other)}");
         Assert.AreEqual(this.OtherStreamsQty, mediaFileActual.Other.Count, $"ERROR in {nameof(mediaFileActual.Other)}.Count");   //*TODO: test OtherStreams in more detail.

         Assert.IsNotNull(mediaFileActual.Video, $"ERROR in {nameof(mediaFileActual.Video)}");
         Assert.AreEqual(this.VideoStreamsQty, mediaFileActual.Video.Count, $"ERROR in {nameof(mediaFileActual.Video)}.Count");   //*TODO: test VideoStreams in more detail.

         Assert.IsNotNull(mediaFileActual.Audio, $"ERROR in {nameof(mediaFileActual.Audio)}");
         Assert.AreEqual(this.AudioStreamsQty, mediaFileActual.Audio.Count, $"ERROR in {nameof(mediaFileActual.Audio)}.Count");   //*TODO: test AudioStreams in more detail.

         Assert.IsNotNull(mediaFileActual.Image, $"ERROR in {nameof(mediaFileActual.Image)}");
         Assert.AreEqual(this.ImageStreamsQty, mediaFileActual.Image.Count, $"ERROR in {nameof(mediaFileActual.Image)}.Count");   //*TODO: test ImageStreams in more detail.

      }

      protected internal string FilePathAbs { get; }

      protected internal string InfoUrl { get; protected set; }

      protected internal bool HasStreams { get; protected set; }

      protected internal string InfoCodecs { get; protected set; }

      protected internal string InfoParameters { get; protected set; }

      protected internal string InfoVersion { get; protected set; }

      protected internal string Inform { get; protected set; }

      protected internal bool InformComplete { get; protected set; }

      //protected internal List<MenuStream> Menu { get; protected set; }
      protected internal int MenuStreamsQty { get; protected set; }
      protected internal int OtherStreamsQty { get; protected set; }
      protected internal int TextStreamsQty { get; protected set; }
      protected internal int VideoStreamsQty { get; protected set; }
      protected internal int AudioStreamsQty { get; protected set; }
      protected internal int ImageStreamsQty { get; protected set; }
   }
}
