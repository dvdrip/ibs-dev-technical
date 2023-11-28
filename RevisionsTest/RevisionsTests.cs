using Revisions_Lib;

namespace RevisionsTest
{
    [TestClass]
    public class RevisionsTests
    {
        [TestMethod]
        public void CheckForRevisions_WithRevisionFileName_ReturnsCorrectFileDetails()
        {
            // Arrange
            Revisions revisions = new Revisions();
            string fileName = "file_1.pdf";

            // Act
            FileDetails result = revisions.CheckForRevisions(fileName);

            // Assert
            Assert.AreEqual(fileName, result.FileName);
            Assert.AreEqual("file_1", result.FileExpectedName);
            Assert.AreEqual(1, result.Version_ID);
            Assert.IsTrue(result.IsRevision);
        }

        [TestMethod]
        public void CheckForRevisions_WithoutRevisionFileName_ReturnsCorrectFileDetails()
        {
            // Arrange
            Revisions revisions = new Revisions();
            string fileName = "file.pdf";

            // Act
            FileDetails result = revisions.CheckForRevisions(fileName);

            // Assert
            Assert.AreEqual(fileName, result.FileName);
            Assert.AreEqual("file", result.FileExpectedName);
            Assert.AreEqual(0, result.Version_ID);
            Assert.IsFalse(result.IsRevision);
        }
    }
}