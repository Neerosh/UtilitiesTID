namespace Utilities.Classes
{
    public class FileFilter
    {
        int id;
        string name, notes;

        public int ID { get => id; }
        public string Name { get => name; set => name = value; }
        public string Notes { get => notes; set => notes = value; }

        public FileFilter(int id, string name, string notes) {
            this.id = id;
            Name = name;
            Notes = notes;
        }
    }
}
