using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Classes
{
    public class Code
    {
        private string name, type, codeText;
        private int id;

        public string Name { get => name; }
        public string Type { get => type; }
        public string CodeText { get => codeText; }
        public int ID { get => id; }

        public void setName(string Name) { 
            name = Name.Replace("'","''");
        }

        public void setType(string Type) {
            type = Type.Replace("'", "''");
        }

        public void setCodeText(string CodeText) {
            codeText = CodeText.Replace("'", "''");
        }

        public Code(string Name) {
            setName(Name);
        }
        public Code(int Id,string Name,string Type,string Code) {
            id = Id;
            setName(Name);
            setType(Type);
            setCodeText(Code);

        }
    }
}
