using System;
using ProcessModeling.Classes;

namespace M2
{
    public interface IState
    {
        int StateNumber { get; }
        event StateHandler NextState;
        double TimeInState();
        Distribution Distribution { get; set; }
    }

    public interface IProcess
    {
    }

    public class StateA:IState
    {
        public int StateNumber { get { return 1; } }
        public event StateHandler NextState;
        public double TimeInState()
        {
            return Distribution.GetDistributionValue();
        }

        public Distribution Distribution
        {
            get { return Distribution; }
            set { Distribution = new ExponentialDistribution(1,0);}
        }
    }

    public class StateB : IState
    {
        public int StateNumber { get { return 2; }}
        public event StateHandler NextState;
        public double TimeInState()
        {
            return Distribution.GetDistributionValue();
        }

        public Distribution Distribution
        {
            get { return Distribution; }
            set { Distribution = new ExponentialDistribution(1, 0); }
        }
    }

    public class Process : IProcess
    {
        public Process(IState state)
        {
            OnNextState(state);
        }

        public double[,] TransitionMatrix { get; set; }

        private void OnNextState(IState state)
        {
            Random random = new Random();
            double x = random.NextDouble();
            if (x < TransitionMatrix[state.StateNumber, 0]) State.NextState+=new StateHandler(OnNextState);
            else if (x < TransitionMatrix[state.StateNumber + 1, 0] + TransitionMatrix[state.StateNumber + 1, 0])
                State.NextState+=new StateHandler(OnNextState);
            else State.NextState += new StateHandler(OnNextState); ;
        }

        private IState state;

        public void TimeInState()
        {
            state.TimeInState();
        }

        public IState State
        {
            get { return state; }
            set { state = value; }
        }
    }

    public delegate void StateHandler(IState state);

}
