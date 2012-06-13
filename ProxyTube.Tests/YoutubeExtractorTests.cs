using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using YoutubeExtractor;

namespace ProxyTube.Tests
{
    [TestFixture]
    public class YoutubeExtractorTests
    {
        [Test]
        public void ShouldGetVideoInfos()
        {
            // Arrange 
            string link = @"http://www.youtube.com/watch?v=OEF7zYN95A4";

            // Act
            IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(link);

            // Assert
            Assert.That(videoInfos, Is.Not.Null);
        }

        [Test]
        public void ShoudlDownloadVideo()
        {
            // Arrange
            string link = @"http://www.youtube.com/watch?v=OEF7zYN95A4";
            IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(link);

            // Act
            VideoInfo video = videoInfos.First(info => info.VideoFormat == VideoFormat.Standard360);

            VideoDownloader videoDownloader = new VideoDownloader(video, "insert path" + video.Title + video.VideoExtension);
            videoDownloader.ProgressChanged += (sender, args) => Console.WriteLine(args.ProgressPercentage);
            videoDownloader.Execute();

            // Assert
        }
    }
}