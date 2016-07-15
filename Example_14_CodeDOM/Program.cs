using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.IO;

namespace CodeDomExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = String.Empty;
            string source = File.ReadAllText(path);
            var results = CompileCsharpSource(new[] {path}, "App.exe");

            if (results.Errors.Count == 0)
            {
                Console.WriteLine("No Errors");
            }
            else {
                foreach (CompilerError error in results.Errors) {
                    Console.WriteLine(error.ErrorText);
                }
            }
            Console.ReadLine();
        }

        private static CompilerResults CompileCsharpSource(string[] sources, string output, params string[] references)
        {
            var parameters = new CompilerParameters(references, output);
            parameters.GenerateExecutable = true;
            using (var provider = new CSharpCodeProvider()) {
                return provider.CompileAssemblyFromSource(parameters, sources);
            }
        }
    }
}
