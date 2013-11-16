using System;
using System.Globalization;

using Antlr.Runtime;
using Antlr.Runtime.Tree;


namespace MathExpr
{
  public class Program
  {
    // "�������������������" ������ ��� ����� (� ������������ ������)
    public static readonly NumberFormatInfo NFI = new NumberFormatInfo();
    public static Context mainContext = new Context();

    public static void Main(string[] args) {  
     try {
         mainContext.upper = null;
         /*���������� ��������� �������� ������������ �������*/
        
        // � ����������� �� ������� ���������� ��������� ������ ���������
        // ���� ���� � ������, ���������� ������ ����������, ���� ����������� ����
        ICharStream input = args.Length == 1 ? (ICharStream)new ANTLRFileStream(args[0])
                                             : (ICharStream)new ANTLRReaderStream(Console.In);
        MathExprLexer lexer = new MathExprLexer(input);
        CommonTokenStream tokens = new CommonTokenStream(lexer);
        MathExprParser parser = new MathExprParser(tokens);
        ITree program = (ITree)parser.execute().Tree;
        AstNodePrinter.Print(program);
        Console.WriteLine();
        MathExprIntepreter.Execute(program, mainContext);
      }
      catch (Exception e) {
        Console.WriteLine("Error: {0}", e);
      }
    }
  }
}
