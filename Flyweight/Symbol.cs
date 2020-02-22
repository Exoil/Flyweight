using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class Symbol
    {
        public char symbol { get; set; }

        public Symbol()
        {

        }
        public Symbol(char character)
        {
            symbol = character;
        }

        public override bool Equals(object obj)
        {
            if(obj is Symbol)
            {
                var sym = obj as Symbol;

                return this.symbol.Equals(sym.symbol);
            }
            return false;
        }

        public override string ToString()
        {
            return this.symbol.ToString();
        }
    }
}
