namespace SemiMarkovProcess
{
    /// <summary>
    /// State interface
    /// </summary>
    public interface IState
    {
        uint StateNumber { get; set; }
        int StateValue { get; set; }
        event StateHandler NextState;
        double TimeInState { get; }
        IDistribution Distribution { get; set; }
        void StateActivity(IProcess process);
        double StartDistribution { get; set; }
    }

    /// <summary>
    /// State implementation of IState
    /// </summary>
    public class State : IState
    {
        public State(uint number, IDistribution distribution, int stateValue)
        {
            if(distribution == null)
            {
                distribution = new ExponentialDistribution(1,0);
            }
            StateNumber = (uint)number;
            Distribution = distribution;
            StateValue = stateValue;
        }
        public State()
        {
            StateNumber = 0;
            Distribution = new ExponentialDistribution();
        }

        public uint StateNumber { get; set; }
        public double StartDistribution { get; set; }
        public int StateValue { get; set; }
        public event StateHandler NextState;
        public double TimeInState
        {
            get { return Distribution.GetDistributionValue(); }
        }
        public IDistribution Distribution { get; set; }
        public void StateActivity(IProcess process)
        {
            NextState(process.ChangeState(this));
        }
    }
}
