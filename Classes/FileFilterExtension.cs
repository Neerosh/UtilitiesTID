namespace Utilities.Classes
{
    public class FileFilterExtension
    {
        int id, idFileFilter;
        string extension;

        public int Id { get => id; }
        public int IdFileFilter { get => idFileFilter; }
        public string Extension { get => extension; set => extension = value; }

        public FileFilterExtension(int id, int idFileFilter,string extension) {
            this.id = id;   
            this.idFileFilter = idFileFilter;
            Extension = extension;
        }
        public void SetExtensionLowerCase() {
            Extension = Extension.ToLower();
        }
    }
}
