namespace Utilities.Classes
{
    public class FileFilterFile
    {
        int id, idFileFilter;
        string fileName;

        public int Id { get => id; }
        public int IdFileFilter { get => idFileFilter; }
        public string FileName { get => fileName; set => fileName = value; }

        public FileFilterFile(int id, int idFileFilter,string filename) {
            this.id = id;   
            this.idFileFilter = idFileFilter;
            FileName = filename;
        }

        public void SetFileNameLowerCase() {
            FileName = FileName.ToLower();
        }
    }
}
