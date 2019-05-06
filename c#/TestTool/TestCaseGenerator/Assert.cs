using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCaseGenerator
{
    public struct AssertParameters
    {
        public string name;
        public string value;
        public string operate;
        public string epsilon;

        public AssertParameters(string pName, string pValue, string pOperate, string pEpsilon)
        {
            name = pName;
            value = pValue;
            operate = pOperate;
            epsilon = pEpsilon;
        }
    }

    public class Assert
    {
        private List<AssertParameters> assertParameters;

        public Assert()
        {
            assertParameters = new List<AssertParameters>();
        }

        public string Name { get; set; }
        public void AddParameter(AssertParameters dataParam)
        {
            assertParameters.Add(dataParam);
        }
        public List<AssertParameters> GetListParam()
        {
            return assertParameters;
        }
    }
}
