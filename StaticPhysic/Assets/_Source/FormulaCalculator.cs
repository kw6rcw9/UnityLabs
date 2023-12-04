using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using Data;
using UnityEngine;

public class FormulaCalculator
{
   private PhysicConstSO _consts;
   private static  double _gr;
   private static  double _g;
   

   public FormulaCalculator(PhysicConstSO consts)
   {
      _consts = consts;
      _gr = _consts.Gr;
      _g = _consts.G;

   }

   public static double FirstFormulaCalculate(double m1, double m2, double r)
   {
      return _gr * m1 * m2 / Math.Pow(r, 2);
   }
   public static double SecondFormulaCalculate(double m, double u)
   {
      return _g * m * u;
   }
}
