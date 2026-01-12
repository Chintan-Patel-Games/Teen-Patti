namespace TeenPatti.StateMachine
{
    public interface IState<TOwner>
    {
        public TOwner Owner { get; set; }
        public void OnEnterState();
        public void UpdateState();
        public void OnExitState();
    }
}