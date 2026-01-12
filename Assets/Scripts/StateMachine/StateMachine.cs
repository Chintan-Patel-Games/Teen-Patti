using System;
using System.Collections.Generic;

namespace TeenPatti.StateMachine
{
    public class StateMachine<TOwner>
    {
        protected TOwner Owner;
        protected IState<TOwner> currentState;
        protected Enum currentStateKey;
        protected Dictionary<Enum, IState<TOwner>> States = new();

        public StateMachine(TOwner Owner) => this.Owner = Owner;

        public void Update() => currentState?.UpdateState();

        // Changes state internally
        private void ChangeStateInternally(IState<TOwner> newState)
        {
            if (currentState == newState) return;

            currentState?.OnExitState();
            currentState = newState;
            currentState?.OnEnterState();
        }

        // Global method to change state
        public void ChangeState(Enum newState)
        {
            if (currentStateKey != null && currentStateKey.Equals(newState))
                return;

            currentStateKey = newState;
            ChangeStateInternally(States[newState]);
        }

        public Enum GetCurrentStateKey() => currentStateKey;
    }
}