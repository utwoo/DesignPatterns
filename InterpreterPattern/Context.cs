namespace InterpreterPattern
{
    public class Context
    {
        public Context(string statement)
        {
            this.Statement = statement;
        }
        
        public string Statement { get; set; }
        public int  Data { get; set; }
    }
}