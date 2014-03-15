using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace SemiMarkovProcess
{
    /// <summary>
    /// Semi-Markov process API
    /// </summary>
    public interface IProcess
    {
        /// <summary>
        /// Gets the states.
        /// </summary>
        /// <value>
        /// The states.
        /// </value>
        List<IState> States { get; }
        IState ChangeState(IState state);
        List<Transition> TransitionMatrix { get; set; }
        IState State { get; set; }
        List<StartDistribution> StartDistributions { get; set; }
        double CurrentTimeMoment { get; set; }
        List<ProcessMoment> ProcessMoments { get; set; }
    }


    /// <summary>
    /// Implementation of Semi-Markov process API
    /// </summary>
    public class Process : IProcess
    {
        public Process(IState state)
        {
            CurrentTimeMoment = 0;
            ProcessMoments = new List<ProcessMoment>();
            if(state ==null)
            {
                state = GetFirstState();
            }
            OnNextState(state);
        }

        public Process(List<IState> states, List<Transition> transitions, List<StartDistribution> startDistributions, ConditionOfEndProcess conditionOfEndProcess,ulong conditionParam)
        {
            CurrentTimeMoment = 0;
            States = states;
            TransitionMatrix=transitions ?? GetDefaultTransitionMatrix();
            ProcessMoments = new List<ProcessMoment>();
            ConditionOfEndProcess = conditionOfEndProcess;
            _conditionParam = conditionParam;
            StartDistributions =startDistributions ?? GetDefaultStartDistribution();
            State = GetFirstState();
        }

        public ConditionOfEndProcess ConditionOfEndProcess { get; set; }
        private List<Transition> _transitionMatrix;
        public List<Transition> TransitionMatrix
        {
            get
            {
                if (_transitionMatrix == null || _transitionMatrix.Count==0)
                    _transitionMatrix = GetDefaultTransitionMatrix();
                return _transitionMatrix;
            }
            set { _transitionMatrix = value; }
        }
        private List<Transition> GetDefaultTransitionMatrix()
        {
            var list = new List<Transition>();
            foreach (var state in States)
            {
                list.AddRange(States.Select(t => new Transition()
                                                     {
                                                         FromState = state, ToState = t, Probability = (double) 1/States.Count
                                                     }));
            }
            return list;

        }
        private void OnNextState(IState state)
        {
            if(state == null) throw new NullReferenceException("state");
            State = state;
            this.CurrentTimeMoment += State.TimeInState;
            var moment = new ProcessMoment()
            {
                StartMoment = this.CurrentTimeMoment,
                TimeInState = State.TimeInState,
                StateValue = State.StateValue
            };
            this.ProcessMoments.Add(moment);
        }
        private readonly Random _globalRandom = new Random();
        private List<IState> _states;

        public List<IState> States
        {
            get { return _states; }
            set
            {
                _states = value;
                foreach (var s in States)
                {
                    s.NextState += new StateHandler(OnNextState);
                }
            }
        }
        public double CurrentTimeMoment { get; set; }
        public List<ProcessMoment> ProcessMoments { get; set; } 
        public IState State { get; set; }
        private List<StartDistribution> _startDistributions;

        public List<StartDistribution> StartDistributions
        {
            get { return _startDistributions ?? (_startDistributions = GetDefaultStartDistribution()); }
            set { _startDistributions = value; }
        }

        private List<StartDistribution> GetDefaultStartDistribution()
        {
            return States.Select(state => new StartDistribution()
                                              {
                                                  State = state, Probability = (double) 1/States.Count
                                              }).ToList();
        }

        public IState ChangeState(IState state)
        {
            var random = _globalRandom.NextDouble();
            Console.WriteLine(random);
            double probability = 0;
            foreach (var tansition in TransitionMatrix.Where(i=>i.FromState == State))
            {
                probability += tansition.Probability;
                if (random < probability)
                {
                    ProcessMoments.Add(new ProcessMoment()
                                           {
                                               StateValue = State.StateValue,
                                               TimeInState = State.Distribution.GetDistributionValue(),
                                               StartMoment = ProcessMoments.Count>0? ProcessMoments.Last().EndMoment:0
                                           });
                    this.State = tansition.ToState;
                    return tansition.ToState;
                }
            }
            return null;
        }
        private IState GetFirstState()
        {
            var random = _globalRandom.NextDouble();
            Console.WriteLine(random);
            double probability = 0;
            foreach (var stateDistribution in StartDistributions)
            {
                probability += stateDistribution.Probability;
                if (random < probability) return stateDistribution.State;
            }
            return null;
        }
        public List<ProcessMoment> SimulateProcess()
        {
            if (IsProcessReadyToStart())
            {
                if (ConditionOfEndProcess == ConditionOfEndProcess.Time) TimeSimulation();
                else TransitionsSimulation();
                return ProcessMoments;
            }
            return null;
        }
        private bool IsProcessReadyToStart()
        {
            if (StartDistributions == null || StartDistributions.Count == 0) return false;
            if (States == null || States.Count == 0) return false;
            if (TransitionMatrix == null || TransitionMatrix.Count != States.Count * States.Count) return false;
            if (this.ConditionOfEndProcess == ConditionOfEndProcess.Time && this._conditionParam == 0) return false;
            if (this.ConditionOfEndProcess == ConditionOfEndProcess.TransitionsAmount && this._conditionParam == 0)
                return false;
            return true;
        }
        private readonly ulong _conditionParam;
        private void TimeSimulation()
        {
            while (ProcessMoments.Count == 0||ProcessMoments.Last().EndMoment < _conditionParam)
            {
                ChangeState(this.State);
            }
        }
        private void TransitionsSimulation()
        {
            for (ulong i = 0; i < _conditionParam;i++ )
            {
                ChangeState(this.State);
            }
        }
    }

    

    public delegate void StateHandler(IState state);
    
    public class Transition
    {
        public IState FromState { get; set; }
        public IState ToState { get; set; }
        public double Probability { get; set; }
    }

    public class StartDistribution
    {
        public IState State { get; set; }
        public double Probability { get; set; }
    }

    public class ProcessMoment
    {
        public int StateValue { get; set; }
        public double StartMoment { get; set; }
        public double TimeInState { get; set; }
        public int ModelingID { get; set; }
        public Modeling Modeling { get; set; }
        public double EndMoment
        {
            get { return StartMoment + TimeInState; }
        }
        public string Description
        {
            get { return string.Format("ID={0};",ModelingID); }
        }
    
    }

    public enum ConditionOfEndProcess
    {
        [Description("Час")]
        Time=0,
        [Description("Кількість переходів")]
        TransitionsAmount=1,
    }

    [Serializable]
    public class Point
    {
        public double Time { get; set; }
        public double Value { get; set; }
    }


    public class Points
    {
        public List<Point> AllPoints { get; set; }
        public Points()
        {
            AllPoints = new List<Point>();
        }

    }

    public class Modeling
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    
}
