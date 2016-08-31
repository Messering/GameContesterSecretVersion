using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;

namespace GameContester.Web.Models
{
    public class GameViewModel
    {
       // [DataType(DataType.MultilineText)]
        public string Code { get; set; }

     //   public CompilerResults Executor { get; set; }

      /*  public void Compile()
        {
            CSharpCodeProvider provider = new CSharpCodeProvider();
            Executor = provider.CompileAssemblyFromSource(new CompilerParameters(), Code);
            if (Executor.Errors.HasErrors)
            {
                StringBuilder sb = new StringBuilder();

                foreach (CompilerError error in Executor.Errors)
                {
                    sb.AppendLine(String.Format("Error ({0}): {1}", error.ErrorNumber, error.ErrorText));
                }

                throw new InvalidOperationException(sb.ToString());
            }
        }

        public void Run()
        {
            object o = Executor.CompiledAssembly.CreateInstance("Foo.Bar");
            MethodInfo mi = o.GetType().GetMethod("Main");
            mi.Invoke(o, null);
        }
    */
    }
}