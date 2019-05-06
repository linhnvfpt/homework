using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcadApp = Bricscad.ApplicationServices.Application;
using Bricscad.EditorInput;
using Teigha.Runtime;

namespace TestCaseGenerator
{
    public class RegisterCommand
    {
        [CommandMethod("TESTCASEGENERATOR", CommandFlags.NoHistory)]
        public static void TestCaseGenerator()
        {
            AcadApp.ShowModalDialog(new MainForm());
        }
    }
}
