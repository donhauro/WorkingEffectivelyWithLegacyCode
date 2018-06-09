using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SproutOutMethod.Version2
{
    public class FileUpdateManager
    {
        public void AppendFilesWithText(IList<string> filePath, string textToAppend)
        {
            var uniqueFileList = GetUniqueFileList(filePath);
            foreach (var file in uniqueFileList)
            {
                if (File.Exists(file) && string.IsNullOrEmpty(textToAppend))
                    File.AppendAllText(file, textToAppend);
            }
            NotifyThatFilesHaveChangedByEmail(filePath);
        }

        private IList<string> GetUniqueFileList(IEnumerable<string> filePath)
        {
            return filePath.Distinct().ToList();
        }

        private void NotifyThatFilesHaveChangedByEmail(IList<string> filePath)
        {
            // Send Mail;
        }
    }
}
