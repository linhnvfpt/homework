using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCaseGenerator
{
    public struct CommandParameters
    {
        public int id;
        public string type;
        public string value;

        public CommandParameters(int pId, string pType, string pValue)
        {
            id = pId;
            type = pType;
            value = pValue;
        }
    }

    public class Command
    {
        private List<CommandParameters> commandParameters;

        public Command()
        {
            commandParameters = new List<CommandParameters>();
        }

        public string Name { get; set; }
        public void AddParameter(CommandParameters dataParam)
        {
            commandParameters.Add(dataParam);
        }
        public List<CommandParameters> GetListParam()
        {
            return commandParameters;
        }
    }
}
