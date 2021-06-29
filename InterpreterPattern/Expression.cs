using System.Collections.Generic;

namespace InterpreterPattern
{
    public abstract class Expression
    {
        private readonly Dictionary<string, int> _table = new Dictionary<string, int>(9);

        protected Expression()
        {
            _table.Add("一", 1);
            _table.Add("二", 2);
            _table.Add("三", 3);
            _table.Add("四", 4);
            _table.Add("五", 5);
            _table.Add("六", 6);
            _table.Add("七", 7);
            _table.Add("八", 8);
            _table.Add("九", 9);
        }

        public virtual void Interpret(Context context)
        {
            if (context.Statement.Length == 0) return;

            foreach (var key in _table.Keys)
            {
                var value = _table[key];
                if (context.Statement.EndsWith(key + GetPostfix()))
                {
                    context.Data += value * Multiplier();
                    context.Statement = context.Statement.Substring(0, context.Statement.Length - this.GetLength());
                }

                if (context.Statement.EndsWith("零"))
                {
                    context.Statement = context.Statement.Substring(0, context.Statement.Length - 1);
                }

                if (context.Statement.Length == 0)
                {
                    return;
                }
            }
        }

        protected abstract string GetPostfix();
        protected abstract int Multiplier();

        protected virtual int GetLength()
        {
            return this.GetPostfix().Length + 1;
        }
    }

    public class OneExpression : Expression
    {
        protected override string GetPostfix()
        {
            return "";
        }

        protected override int Multiplier()
        {
            return 1;
        }

        protected override int GetLength()
        {
            return 1;
        }
    }

    public class TenExpression : Expression
    {
        protected override string GetPostfix()
        {
            return "十";
        }

        protected override int Multiplier()
        {
            return 10;
        }

        protected override int GetLength()
        {
            return 2;
        }
    }

    public class HundredExpression : Expression
    {
        protected override string GetPostfix()
        {
            return "百";
        }

        protected override int Multiplier()
        {
            return 100;
        }

        protected override int GetLength()
        {
            return 2;
        }
    }

    public class ThousandExpression : Expression
    {
        protected override string GetPostfix()
        {
            return "千";
        }

        protected override int Multiplier()
        {
            return 1000;
        }

        protected override int GetLength()
        {
            return 2;
        }
    }
}