namespace MementoPattern
{
    public class Originator
    {
        private string _state;

        public void SetState(string state)
        {
            this._state = state;
        }

        public string GetState()
        {
            return _state;
        }

        public Memento SaveStateToMemento()
        {
            return new Memento(_state);
        }

        public void GetStateFromMemento(Memento memento)
        {
            _state = memento.GetState();
        }
    }
}