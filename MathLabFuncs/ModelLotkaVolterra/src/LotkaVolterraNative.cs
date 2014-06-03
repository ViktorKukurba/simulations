/*
* MATLAB Compiler: 4.14 (R2010b)
* Date: Thu May 08 00:53:01 2014
* Arguments: "-B" "macro_default" "-W"
* "dotnet:ModelLotkaVolterra,LotkaVolterra,0.0,private" "-T" "link:lib" "-d"
* "D:\Aspiranture\Dis_project\simulations\MathLabFuncs\ModelLotkaVolterra\src" "-w"
* "enable:specified_file_mismatch" "-w" "enable:repeated_file" "-w"
* "enable:switch_ignored" "-w" "enable:missing_lib_sentinel" "-w" "enable:demo_license"
* "-v"
* "class{LotkaVolterra:D:\Aspiranture\Dis_project\simulations\MathLabFuncs\MLV.m,D:\Aspira
* nture\Dis_project\simulations\MathLabFuncs\MLV_SAP.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace ModelLotkaVolterraNative
{
  /// <summary>
  /// The LotkaVolterra class provides a CLS compliant, Object (native) interface to the
  /// M-functions contained in the files:
  /// <newpara></newpara>
  /// D:\Aspiranture\Dis_project\simulations\MathLabFuncs\MLV.m
  /// <newpara></newpara>
  /// D:\Aspiranture\Dis_project\simulations\MathLabFuncs\MLV_SAP.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class LotkaVolterra : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Compiler Runtime
    /// instance.
    /// </summary>
    static LotkaVolterra()
    {
      if (MWMCR.MCRAppInitialized)
      {
        Assembly assembly= Assembly.GetExecutingAssembly();

        string ctfFilePath= assembly.Location;

        int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

        ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

        string ctfFileName = "ModelLotkaVolterra.ctf";

        Stream embeddedCtfStream = null;

        String[] resourceStrings = assembly.GetManifestResourceNames();

        foreach (String name in resourceStrings)
        {
          if (name.Contains(ctfFileName))
          {
            embeddedCtfStream = assembly.GetManifestResourceStream(name);
            break;
          }
        }
        mcr= new MWMCR("",
                       ctfFilePath, embeddedCtfStream, true);
      }
      else
      {
        throw new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the LotkaVolterra class.
    /// </summary>
    public LotkaVolterra()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~LotkaVolterra()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the MLV M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MLV()
    {
      return mcr.EvaluateFunction("MLV", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the MLV M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MLV(Object t)
    {
      return mcr.EvaluateFunction("MLV", t);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the MLV M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MLV(Object t, Object x)
    {
      return mcr.EvaluateFunction("MLV", t, x);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the MLV M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <param name="a">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MLV(Object t, Object x, Object a)
    {
      return mcr.EvaluateFunction("MLV", t, x, a);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the MLV M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <param name="a">Input argument #3</param>
    /// <param name="b">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MLV(Object t, Object x, Object a, Object b)
    {
      return mcr.EvaluateFunction("MLV", t, x, a, b);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the MLV M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <param name="a">Input argument #3</param>
    /// <param name="b">Input argument #4</param>
    /// <param name="c">Input argument #5</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MLV(Object t, Object x, Object a, Object b, Object c)
    {
      return mcr.EvaluateFunction("MLV", t, x, a, b, c);
    }


    /// <summary>
    /// Provides a single output, 6-input Objectinterface to the MLV M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <param name="a">Input argument #3</param>
    /// <param name="b">Input argument #4</param>
    /// <param name="c">Input argument #5</param>
    /// <param name="d">Input argument #6</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MLV(Object t, Object x, Object a, Object b, Object c, Object d)
    {
      return mcr.EvaluateFunction("MLV", t, x, a, b, c, d);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the MLV M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] MLV(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "MLV", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the MLV M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] MLV(int numArgsOut, Object t)
    {
      return mcr.EvaluateFunction(numArgsOut, "MLV", t);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the MLV M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] MLV(int numArgsOut, Object t, Object x)
    {
      return mcr.EvaluateFunction(numArgsOut, "MLV", t, x);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the MLV M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <param name="a">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] MLV(int numArgsOut, Object t, Object x, Object a)
    {
      return mcr.EvaluateFunction(numArgsOut, "MLV", t, x, a);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the MLV M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <param name="a">Input argument #3</param>
    /// <param name="b">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] MLV(int numArgsOut, Object t, Object x, Object a, Object b)
    {
      return mcr.EvaluateFunction(numArgsOut, "MLV", t, x, a, b);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the MLV M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <param name="a">Input argument #3</param>
    /// <param name="b">Input argument #4</param>
    /// <param name="c">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] MLV(int numArgsOut, Object t, Object x, Object a, Object b, Object c)
    {
      return mcr.EvaluateFunction(numArgsOut, "MLV", t, x, a, b, c);
    }


    /// <summary>
    /// Provides the standard 6-input Object interface to the MLV M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <param name="a">Input argument #3</param>
    /// <param name="b">Input argument #4</param>
    /// <param name="c">Input argument #5</param>
    /// <param name="d">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] MLV(int numArgsOut, Object t, Object x, Object a, Object b, Object c, 
                  Object d)
    {
      return mcr.EvaluateFunction(numArgsOut, "MLV", t, x, a, b, c, d);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the MLV_SAP M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MLV_SAP()
    {
      return mcr.EvaluateFunction("MLV_SAP", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the MLV_SAP M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MLV_SAP(Object t)
    {
      return mcr.EvaluateFunction("MLV_SAP", t);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the MLV_SAP M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MLV_SAP(Object t, Object x)
    {
      return mcr.EvaluateFunction("MLV_SAP", t, x);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the MLV_SAP M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <param name="a">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MLV_SAP(Object t, Object x, Object a)
    {
      return mcr.EvaluateFunction("MLV_SAP", t, x, a);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the MLV_SAP M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <param name="a">Input argument #3</param>
    /// <param name="b">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MLV_SAP(Object t, Object x, Object a, Object b)
    {
      return mcr.EvaluateFunction("MLV_SAP", t, x, a, b);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the MLV_SAP M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <param name="a">Input argument #3</param>
    /// <param name="b">Input argument #4</param>
    /// <param name="c">Input argument #5</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MLV_SAP(Object t, Object x, Object a, Object b, Object c)
    {
      return mcr.EvaluateFunction("MLV_SAP", t, x, a, b, c);
    }


    /// <summary>
    /// Provides a single output, 6-input Objectinterface to the MLV_SAP M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <param name="a">Input argument #3</param>
    /// <param name="b">Input argument #4</param>
    /// <param name="c">Input argument #5</param>
    /// <param name="d">Input argument #6</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MLV_SAP(Object t, Object x, Object a, Object b, Object c, Object d)
    {
      return mcr.EvaluateFunction("MLV_SAP", t, x, a, b, c, d);
    }


    /// <summary>
    /// Provides a single output, 7-input Objectinterface to the MLV_SAP M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <param name="a">Input argument #3</param>
    /// <param name="b">Input argument #4</param>
    /// <param name="c">Input argument #5</param>
    /// <param name="d">Input argument #6</param>
    /// <param name="alpha">Input argument #7</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MLV_SAP(Object t, Object x, Object a, Object b, Object c, Object d, 
                    Object alpha)
    {
      return mcr.EvaluateFunction("MLV_SAP", t, x, a, b, c, d, alpha);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the MLV_SAP M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] MLV_SAP(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "MLV_SAP", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the MLV_SAP M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] MLV_SAP(int numArgsOut, Object t)
    {
      return mcr.EvaluateFunction(numArgsOut, "MLV_SAP", t);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the MLV_SAP M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] MLV_SAP(int numArgsOut, Object t, Object x)
    {
      return mcr.EvaluateFunction(numArgsOut, "MLV_SAP", t, x);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the MLV_SAP M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <param name="a">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] MLV_SAP(int numArgsOut, Object t, Object x, Object a)
    {
      return mcr.EvaluateFunction(numArgsOut, "MLV_SAP", t, x, a);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the MLV_SAP M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <param name="a">Input argument #3</param>
    /// <param name="b">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] MLV_SAP(int numArgsOut, Object t, Object x, Object a, Object b)
    {
      return mcr.EvaluateFunction(numArgsOut, "MLV_SAP", t, x, a, b);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the MLV_SAP M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <param name="a">Input argument #3</param>
    /// <param name="b">Input argument #4</param>
    /// <param name="c">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] MLV_SAP(int numArgsOut, Object t, Object x, Object a, Object b, 
                      Object c)
    {
      return mcr.EvaluateFunction(numArgsOut, "MLV_SAP", t, x, a, b, c);
    }


    /// <summary>
    /// Provides the standard 6-input Object interface to the MLV_SAP M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <param name="a">Input argument #3</param>
    /// <param name="b">Input argument #4</param>
    /// <param name="c">Input argument #5</param>
    /// <param name="d">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] MLV_SAP(int numArgsOut, Object t, Object x, Object a, Object b, 
                      Object c, Object d)
    {
      return mcr.EvaluateFunction(numArgsOut, "MLV_SAP", t, x, a, b, c, d);
    }


    /// <summary>
    /// Provides the standard 7-input Object interface to the MLV_SAP M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <param name="a">Input argument #3</param>
    /// <param name="b">Input argument #4</param>
    /// <param name="c">Input argument #5</param>
    /// <param name="d">Input argument #6</param>
    /// <param name="alpha">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] MLV_SAP(int numArgsOut, Object t, Object x, Object a, Object b, 
                      Object c, Object d, Object alpha)
    {
      return mcr.EvaluateFunction(numArgsOut, "MLV_SAP", t, x, a, b, c, d, alpha);
    }


    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
