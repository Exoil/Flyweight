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
         
     
            if (symbolList.Where(item => item.Equals(character)).Select(item => item).FirstOrDefault() != null)
            {
                 return symbolList.Where(item => item.Equals(character)).Select(item => item).FirstOrDefault();
            }

            else
            {
                symbolList.Add(new Symbol(character));
                return symbolList.Where(item => item.Equals(character)).Select(item => item).FirstOrDefault(); ;
            }
           
        }
    }
}
