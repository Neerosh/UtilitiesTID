namespace Utilities.Classes
{
    public class Code
    {
        private string name, type, codeText;
        private int id;

        public int ID { get => id; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string CodeText { get => codeText; set => codeText = value; }

        public Code(string Name) {
            name = Name;
        }

        public Code(int Id, string Name, string Type, string Code) {
            id = Id;
            name = Name;
            type = Type;
            codeText = Code;
        }

        public void FormatStrings() {
            if (name != null) { name = name.Replace("'", "''"); }
            if (type != null) { type = type.Replace("'", "''"); }
            if (codeText != null) { codeText = codeText.Replace("'", "''"); }
        }

        public void DeformatStrings() {
            if (name != null) { name = name.Replace("''", "'"); }
            if (type != null) { type = type.Replace("''", "'"); }
            if (codeText != null) { codeText = codeText.Replace("''", "'"); }
        }
    }
}
