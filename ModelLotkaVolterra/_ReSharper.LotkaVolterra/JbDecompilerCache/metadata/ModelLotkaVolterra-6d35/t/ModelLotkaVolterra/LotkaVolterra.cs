// Type: ModelLotkaVolterra.LotkaVolterra
// Assembly: ModelLotkaVolterra, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// Assembly location: D:\Aspiranture\Dis_project\simulations\MathLabFuncs\ModelLotkaVolterra\src\ModelLotkaVolterra.dll

using MathWorks.MATLAB.NET.Arrays;
using System;

namespace ModelLotkaVolterra
{
    public class LotkaVolterra : IDisposable
    {
        public LotkaVolterra();

        #region IDisposable Members

        public void Dispose();

        #endregion

        ~LotkaVolterra();
        protected virtual void Dispose(bool disposing);
        public MWArray MLV();
        public MWArray MLV(MWArray t);
        public MWArray MLV(MWArray t, MWArray x);
        public MWArray MLV(MWArray t, MWArray x, MWArray a);
        public MWArray MLV(MWArray t, MWArray x, MWArray a, MWArray b);
        public MWArray MLV(MWArray t, MWArray x, MWArray a, MWArray b, MWArray c);
        public MWArray MLV(MWArray t, MWArray x, MWArray a, MWArray b, MWArray c, MWArray d);
        public MWArray[] MLV(int numArgsOut);
        public MWArray[] MLV(int numArgsOut, MWArray t);
        public MWArray[] MLV(int numArgsOut, MWArray t, MWArray x);
        public MWArray[] MLV(int numArgsOut, MWArray t, MWArray x, MWArray a);
        public MWArray[] MLV(int numArgsOut, MWArray t, MWArray x, MWArray a, MWArray b);
        public MWArray[] MLV(int numArgsOut, MWArray t, MWArray x, MWArray a, MWArray b, MWArray c);
        public MWArray[] MLV(int numArgsOut, MWArray t, MWArray x, MWArray a, MWArray b, MWArray c, MWArray d);
        public void MLV(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn);
        public void WaitForFiguresToDie();
    }
}
