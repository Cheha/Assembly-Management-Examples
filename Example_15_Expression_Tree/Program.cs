using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ExpressionTreeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Comment
            //Func<int, bool> test = i => i > 5;
            //Console.WriteLine(test(3));
            //Console.WriteLine(test(8));
            //Expression<Func<int, bool>> test = i => i > 5;
            //Console.WriteLine(test.Body);

            //BinaryExpression binary = (BinaryExpression)test.Body;
            //Console.WriteLine(binary.Left);
            //Console.WriteLine(binary.NodeType);
            //Console.WriteLine(binary.Right);
            #endregion
            Console.ReadLine();
        }
    }
}
