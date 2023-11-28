﻿namespace Revisions_Lib
{
    public class Revisions
    {
        public FileDetails CheckForRevisions(string fileName)
        {
            FileDetails fileDetails = new FileDetails();

            //assuming filenames do not contain multiple underscores before and after the revision number
            if (fileName.Contains("_"))
            {
                string[] fileSplit = fileName.Split('_');

                if (fileSplit.Length == 2 && int.TryParse(fileSplit[1].Replace(".pdf", ""), out int revisionNumber))
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