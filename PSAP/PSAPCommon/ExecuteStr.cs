using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Text;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP
{
    class ExecuteStr
    {
        public static Object Execute(String code)
        {
            CSharpCodeProvider provider = new CSharpCodeProvider();
            CompilerParameters parameters = new CompilerParameters();
            CompilerResults results = provider.CompileAssemblyFromSource(parameters, BuildCode(code));
            MethodInfo methodInfo = results.CompiledAssembly.GetType("Type.string").GetMethod("T");
           

            return methodInfo.Invoke(null, null);

        }
        static string BuildCode(String code)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("using System;");
            builder.Append("using WeifenLuo.WinFormsUI.Docking;");
            builder.Append("using System.Collections.Generic;");
            builder.Append("using System.ComponentModel;");
            builder.Append("using System.Data;");
            builder.Append("using System.Drawing;;");
            builder.Append("using System.Text;");
            builder.Append("using System.Windows.Forms;");

            builder.Append("public class C{ public static Object T(){");
            builder.Append(code);
            builder.Append("}}");
            return builder.ToString();
        }
    }
}
