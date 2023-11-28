namespace Revisions_Lib
{
    public class Revisions
    {
        public FileDetails CheckForRevisions(string fileName)
        {
            FileDetails fileDetails = new FileDetails();

            //assuming filenames do not contain multiple underscores before and after the revision number
            //else i will add a different approach to handle edge cases
            int lastUnderscoreIndex = fileName.LastIndexOf('_');

            if (lastUnderscoreIndex != -1)
            {
                string revisionPart = fileName.Substring(lastUnderscoreIndex + 1);

                if (int.TryParse(revisionPart.Replace(".pdf", ""), out int revisionNumber))
                {
                    fileDetails.FileName = fileName;
                    fileDetails.FileExpectedName = Path.GetFileNameWithoutExtension(fileName);
                    fileDetails.Version_ID = revisionNumber;
                    fileDetails.IsRevision = true;
                }
            }
            else
            {
                fileDetails.FileName = fileName;
                fileDetails.FileExpectedName = Path.GetFileNameWithoutExtension(fileName);
                fileDetails.Version_ID = 0;
                fileDetails.IsRevision = false;
            }

            return fileDetails;
        }

    }
}
