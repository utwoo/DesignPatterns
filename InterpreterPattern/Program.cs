using System;
using System.Collections;

namespace InterpreterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var roman = "五千四百三十二"; //5432
            var context = new Context(roman);

            //Build the 'parse tree'
            var tree = new ArrayList
            {
                new OneExpression(),
                new TenExpression(),
                new HundredExpression(),
                new ThousandExpression()
            };


            //Interpret
            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }

            Console.WriteLine("{0} = {1}", roman, context.Data);
            Console.Read();
        }
    }
}