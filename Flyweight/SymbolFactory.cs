using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight
{
    public class SymbolFactory
    {
        private List<Symbol> symbolList { get; set; }


        public SymbolFactory()
        {
            symbolList = new List<Symbol>();
        }
        public Symbol GetSymbol(char character)
        {
            Symbol symbolTmp = new Symbol(character);

            if (symbolList.Contains(symbolTmp))
            {
                 return symbolList.Where(item => item.Equals(symbolTmp)).Select(item => item).FirstOrDefault();
            }

            else
            {
                symbolList.Add(symbolTmp);
                return symbolList.Where(item => item.Equals(symbolTmp)).Select(item => item).FirstOrDefault(); ;
            }
           
        }
    }
}
