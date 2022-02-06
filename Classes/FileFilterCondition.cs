namespace Utilities.Classes
{
    public class FileFilterCondition
    {
        int id, idFileFilter;
        string type,condition;

        public int Id { get => id; }
        public int IdFileFilter { get => idFileFilter; }
        public string Type { get => type; set => type = value; }
        public string Condition { get => condition; set => condition = value; }

        public FileFilterCondition(int id, int idFileFilter,string type,string condition) {
            this.id = id;
            this.idFileFilter = idFileFilter;
            Type = type;
            Condition = condition;
        }
        public void SetConditionLowerCase() {
            Condition = Condition.ToLower();
        }
    }
}
