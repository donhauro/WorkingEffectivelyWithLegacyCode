using System.Collections.Generic;
using System.IO;

namespace SproutOutMethod.Version1
{
    public class FileUpdateManager
    {
            public void AppendFilesWithText(IList<string> filePath, string textToAppend)
            {
                foreach (var file in filePath)
                {
                    if (File.Exists(file) && string.IsNullOrEmpty(textToAppend))
                        File.AppendAllText(file, textToAppend);
                }
                NotifyThatFilesHaveChangedByEmail(filePath);
        }

        private void NotifyThatFilesHaveChangedByEmail(IList<string> filePath)
        {
            // Send Mail;
        }
    }
}
