using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProcessModeling.Classes
{
    /// <summary>
    /// Class that describes state parameters: stateValue, timeInState, distribution function, switching function
    /// </summary>
    public class StateClass
    {
        //property describes Value in State
        private sbyte stateValue;
        public sbyte StateValue
        {
            get { return stateValue; }
            set { stateValue = value; }
        }
        //property describes Time being in State
        private double timeInState;
        public double TimeInState
        {
            get { return timeInState; }
            set { timeInState = value; }
        }
        //method that choose start state, using start distribution
        public sbyte FirstStateChoice(double[] startDistributionMatrix,double rnd)
        {
            sbyte firstState;            
            double x = rnd;
            if (x < startDistributionMatrix[0]) firstState = -1;
            else if (x < startDistributionMatrix[0] + startDistributionMatrix[0]) firstState = 0;
            else firstState = 1;
            return firstState;
        }
        //method that choose states, using matrix of switchings
        public sbyte Switch(double[,] TransitionMatrix,double rnd)
        {
            sbyte newState;
            double x = rnd;
            if (x < TransitionMatrix[this.StateValue+1, 0]) newState = -1;
            else if (x < TransitionMatrix[this.StateValue+1, 0] + TransitionMatrix[this.StateValue+1, 0]) newState = 0;
            else newState = 1;
            return newState;
        }
    }
}
