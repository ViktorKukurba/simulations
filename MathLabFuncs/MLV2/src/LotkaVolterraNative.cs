/*
* MATLAB Compiler: 5.1 (R2014a)
* Date: Wed Jul 15 01:03:46 2015
* Arguments: "-B" "macro_default" "-W" "dotnet:MLV2,LotkaVolterra,0.0,private" "-T"
* "link:lib" "-d" "D:\Aspiranture\Dis_project\simulations\MathLabFuncs\MLV2\src" "-w"
* "enable:specified_file_mismatch" "-w" "enable:repeated_file" "-w"
* "enable:switch_ignored" "-w" "enable:missing_lib_sentinel" "-w" "enable:demo_license"
* "-v"
* "class{LotkaVolterra:D:\Aspiranture\Dis_project\simulations\MathLabFuncs\MLV2.m,D:\Aspir
* anture\Dis_project\simulations\MathLabFuncs\MLV_SAP2.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace MLV2Native
{

  /// <summary>
  /// The LotkaVolterra class provides a CLS compliant, Object (native) interface to the
  /// MATLAB functions contained in the files:
  /// <newpara></newpara>
  /// D:\Aspiranture\Dis_project\simulations\MathLabFuncs\MLV2.m
  /// <newpara></newpara>
  /// D:\Aspiranture\Dis_project\simulations\MathLabFuncs\MLV_SAP2.m
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
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

          int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "MLV2.ctf";

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
        catch(Exception ex)
        {
          ex_ = new Exception("MWArray assembly failed to be initialized", ex);
        }
      }
      else
      {
        ex_ = new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the LotkaVolterra class.
    /// </summary>
    public LotkaVolterra()
    {
      if(ex_ != null)
      {
        throw ex_;
      }
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
    /// Provides a single output, 0-input Objectinterface to the MLV2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MLV2()
    {
      return mcr.EvaluateFunction("MLV2", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the MLV2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MLV2(Object t)
    {
      return mcr.EvaluateFunction("MLV2", t);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the MLV2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MLV2(Object t, Object x)
    {
      return mcr.EvaluateFunction("MLV2", t, x);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the MLV2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <param name="a">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MLV2(Object t, Object x, Object a)
    {
      return mcr.EvaluateFunction("MLV2", t, x, a);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the MLV2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <param name="a">Input argument #3</param>
    /// <param name="b">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MLV2(Object t, Object x, Object a, Object b)
    {
      return mcr.EvaluateFunction("MLV2", t, x, a, b);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the MLV2 MATLAB function.
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
    public Object MLV2(Object t, Object x, Object a, Object b, Object c)
    {
      return mcr.EvaluateFunction("MLV2", t, x, a, b, c);
    }


    /// <summary>
    /// Provides a single output, 6-input Objectinterface to the MLV2 MATLAB function.
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
    public Object MLV2(Object t, Object x, Object a, Object b, Object c, Object d)
    {
      return mcr.EvaluateFunction("MLV2", t, x, a, b, c, d);
    }


    /// <summary>
    /// Provides a single output, 7-input Objectinterface to the MLV2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <param name="a">Input argument #3</param>
    /// <param name="b">Input argument #4</param>
    /// <param name="c">Input argument #5</param>
    /// <param name="d">Input argument #6</param>
    /// <param name="j">Input argument #7</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MLV2(Object t, Object x, Object a, Object b, Object c, Object d, Object 
                 j)
    {
      return mcr.EvaluateFunction("MLV2", t, x, a, b, c, d, j);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the MLV2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] MLV2(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "MLV2", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the MLV2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] MLV2(int numArgsOut, Object t)
    {
      return mcr.EvaluateFunction(numArgsOut, "MLV2", t);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the MLV2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] MLV2(int numArgsOut, Object t, Object x)
    {
      return mcr.EvaluateFunction(numArgsOut, "MLV2", t, x);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the MLV2 MATLAB function.
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
    public Object[] MLV2(int numArgsOut, Object t, Object x, Object a)
    {
      return mcr.EvaluateFunction(numArgsOut, "MLV2", t, x, a);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the MLV2 MATLAB function.
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
    public Object[] MLV2(int numArgsOut, Object t, Object x, Object a, Object b)
    {
      return mcr.EvaluateFunction(numArgsOut, "MLV2", t, x, a, b);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the MLV2 MATLAB function.
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
    public Object[] MLV2(int numArgsOut, Object t, Object x, Object a, Object b, Object c)
    {
      return mcr.EvaluateFunction(numArgsOut, "MLV2", t, x, a, b, c);
    }


    /// <summary>
    /// Provides the standard 6-input Object interface to the MLV2 MATLAB function.
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
    public Object[] MLV2(int numArgsOut, Object t, Object x, Object a, Object b, Object 
                   c, Object d)
    {
      return mcr.EvaluateFunction(numArgsOut, "MLV2", t, x, a, b, c, d);
    }


    /// <summary>
    /// Provides the standard 7-input Object interface to the MLV2 MATLAB function.
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
    /// <param name="j">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] MLV2(int numArgsOut, Object t, Object x, Object a, Object b, Object 
                   c, Object d, Object j)
    {
      return mcr.EvaluateFunction(numArgsOut, "MLV2", t, x, a, b, c, d, j);
    }


    /// <summary>
    /// Provides an interface for the MLV2 function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("MLV2", 7, 2, 0)]
    protected void MLV2(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("MLV2", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the MLV_SAP2 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MLV_SAP2()
    {
      return mcr.EvaluateFunction("MLV_SAP2", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the MLV_SAP2 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MLV_SAP2(Object t)
    {
      return mcr.EvaluateFunction("MLV_SAP2", t);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the MLV_SAP2 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MLV_SAP2(Object t, Object x)
    {
      return mcr.EvaluateFunction("MLV_SAP2", t, x);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the MLV_SAP2 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <param name="a">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MLV_SAP2(Object t, Object x, Object a)
    {
      return mcr.EvaluateFunction("MLV_SAP2", t, x, a);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the MLV_SAP2 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <param name="a">Input argument #3</param>
    /// <param name="b">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MLV_SAP2(Object t, Object x, Object a, Object b)
    {
      return mcr.EvaluateFunction("MLV_SAP2", t, x, a, b);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the MLV_SAP2 MATLAB
    /// function.
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
    public Object MLV_SAP2(Object t, Object x, Object a, Object b, Object c)
    {
      return mcr.EvaluateFunction("MLV_SAP2", t, x, a, b, c);
    }


    /// <summary>
    /// Provides a single output, 6-input Objectinterface to the MLV_SAP2 MATLAB
    /// function.
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
    public Object MLV_SAP2(Object t, Object x, Object a, Object b, Object c, Object d)
    {
      return mcr.EvaluateFunction("MLV_SAP2", t, x, a, b, c, d);
    }


    /// <summary>
    /// Provides a single output, 7-input Objectinterface to the MLV_SAP2 MATLAB
    /// function.
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
    public Object MLV_SAP2(Object t, Object x, Object a, Object b, Object c, Object d, 
                     Object alpha)
    {
      return mcr.EvaluateFunction("MLV_SAP2", t, x, a, b, c, d, alpha);
    }


    /// <summary>
    /// Provides a single output, 8-input Objectinterface to the MLV_SAP2 MATLAB
    /// function.
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
    /// <param name="j">Input argument #8</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object MLV_SAP2(Object t, Object x, Object a, Object b, Object c, Object d, 
                     Object alpha, Object j)
    {
      return mcr.EvaluateFunction("MLV_SAP2", t, x, a, b, c, d, alpha, j);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the MLV_SAP2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] MLV_SAP2(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "MLV_SAP2", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the MLV_SAP2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] MLV_SAP2(int numArgsOut, Object t)
    {
      return mcr.EvaluateFunction(numArgsOut, "MLV_SAP2", t);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the MLV_SAP2 MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <param name="x">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] MLV_SAP2(int numArgsOut, Object t, Object x)
    {
      return mcr.EvaluateFunction(numArgsOut, "MLV_SAP2", t, x);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the MLV_SAP2 MATLAB function.
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
    public Object[] MLV_SAP2(int numArgsOut, Object t, Object x, Object a)
    {
      return mcr.EvaluateFunction(numArgsOut, "MLV_SAP2", t, x, a);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the MLV_SAP2 MATLAB function.
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
    public Object[] MLV_SAP2(int numArgsOut, Object t, Object x, Object a, Object b)
    {
      return mcr.EvaluateFunction(numArgsOut, "MLV_SAP2", t, x, a, b);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the MLV_SAP2 MATLAB function.
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
    public Object[] MLV_SAP2(int numArgsOut, Object t, Object x, Object a, Object b, 
                       Object c)
    {
      return mcr.EvaluateFunction(numArgsOut, "MLV_SAP2", t, x, a, b, c);
    }


    /// <summary>
    /// Provides the standard 6-input Object interface to the MLV_SAP2 MATLAB function.
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
    public Object[] MLV_SAP2(int numArgsOut, Object t, Object x, Object a, Object b, 
                       Object c, Object d)
    {
      return mcr.EvaluateFunction(numArgsOut, "MLV_SAP2", t, x, a, b, c, d);
    }


    /// <summary>
    /// Provides the standard 7-input Object interface to the MLV_SAP2 MATLAB function.
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
    public Object[] MLV_SAP2(int numArgsOut, Object t, Object x, Object a, Object b, 
                       Object c, Object d, Object alpha)
    {
      return mcr.EvaluateFunction(numArgsOut, "MLV_SAP2", t, x, a, b, c, d, alpha);
    }


    /// <summary>
    /// Provides the standard 8-input Object interface to the MLV_SAP2 MATLAB function.
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
    /// <param name="j">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] MLV_SAP2(int numArgsOut, Object t, Object x, Object a, Object b, 
                       Object c, Object d, Object alpha, Object j)
    {
      return mcr.EvaluateFunction(numArgsOut, "MLV_SAP2", t, x, a, b, c, d, alpha, j);
    }


    /// <summary>
    /// Provides an interface for the MLV_SAP2 function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("MLV_SAP2", 8, 2, 0)]
    protected void MLV_SAP2(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("MLV_SAP2", numArgsOut, ref argsOut, argsIn, varArgsIn);
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

    private static Exception ex_= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
