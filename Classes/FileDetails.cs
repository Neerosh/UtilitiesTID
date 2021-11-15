namespace Utilities.Classes
{
    public class FileDetails
    {
        public FileDetails(string fileName, string fileHash) {
            FileName = fileName;
            FileHash = fileHash;
        }
        public string FileName { get; set; }
        public string FileHash { get; set; }
    }
}
