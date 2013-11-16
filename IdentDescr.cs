using System.Collections.Generic;
namespace MathExpr
{
  public class IdentDescr
  {
      //public const int VAR = 1;

      public enum VarType { var, parametr, ret_value }; // var or parametr
      
      public string name
      {
          get;
          set;
      }
      public DataType dataType = new DataType();

      public VarType varType;
      public LinkedList<Parametr> parametrs; // list of parametrs

      /*
    public int Type {
      get;
    }
       */
  }
}
