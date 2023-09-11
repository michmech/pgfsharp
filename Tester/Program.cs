using System;
using System.IO;
using System.Linq;
using System.Linq.Expressions;

namespace Tester {
    internal class Program {
        static void Main(string[] args) {

            //Path to Foods.pdg in the repo's root, or your own PGF file:
            string path = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\Foods.pgf");
            
            PGFSharp.PGF gr = PGFSharp.PGF.ReadPGF(path);
            PGFSharp.Concr eng = gr.Languages["FoodsEng"];

            //Parse:
            //PGFSharp.Expr e = eng.Parse("this pizza is expensive").First().Item1;
            //Console.WriteLine(e.ToString());

            //Linearize:
            //PGFSharp.Expr e = PGFSharp.Expr.ReadExpr("Pred (This Pizza) Expensive");
            //foreach(string s in eng.LinearizeAll(e)) Console.WriteLine(s);

            //Bracketed linearize:
            //{
            //    PGFSharp.Expr e = PGFSharp.Expr.ReadExpr("Pred (This Pizza) Expensive");
            //    PGFSharp.Bracket b = eng.BracketedLinearize(e);
            //    Console.WriteLine(b);
            //}

            //Functions by return type:
            //foreach(string funName in gr.FunctionsByCat("Kind")) {
            //    Console.WriteLine($"fun {funName}");
            //}

            //All functions in the abstract grammar:
            //foreach(string funName in gr.Functions) {
            //    string typeSig = gr.FunctionType(funName).ToString();
            //    Console.WriteLine($"fun {funName} : {typeSig}");
            //}

            //The argument types of one function:
            //{
            //    PGFSharp.Type type = gr.FunctionType("Pred");
            //    foreach(PGFSharp.Type hypothesis in type.Hypotheses) {
            //        Console.WriteLine($"argument type: {hypothesis.ToString()}");
            //    }
            //}

            Console.Write("Press Enter to close this window.");
            Console.ReadLine();
        }
    }
}
