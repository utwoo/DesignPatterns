namespace MementoPattern
{
    public class Memento
    {
        private readonly string _state;

        public Memento(string state)
        {
            this._state = state;
        }

        public string GetState()
        {
            return _state;
        }
    }
}