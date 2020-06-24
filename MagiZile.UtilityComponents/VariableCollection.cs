using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagiZile.UtilityComponents
{
    public class VariableCollection<T>
    {
        Dictionary<string, T> variables = new Dictionary<string, T>();
        string name = "";

        public VariableCollection(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public void AddVariable(string varName, T value)
        {
            variables.Add(varName, value);
        }

        public void RemoveItem(string item)
        {
            variables.Remove(item);
        }

        public Dictionary<string, T> GetItems()
        {
            return variables;
        }
    }
}
