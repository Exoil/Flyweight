using Flyweight;
using System;
using Xunit;

namespace FlyweightTest
{
    public class UnitTest1
    {
        [Fact]
        public void SampleTextCopiedToFlyweightSymbols()
        {

            
            var symbolFacotry = new SymbolFactory();
            char[] charArraySampleTekst = "alamakota".ToCharArray();
            char[] newCharArray = new char[charArraySampleTekst.Length];

            for(int i = 0; i < charArraySampleTekst.Length; i++)
            {
                var symbol = symbolFacotry.GetSymbol(charArraySampleTekst[i]).symbol;
                newCharArray[i] = symbolFacotry.GetSymbol(charArraySampleTekst[i]).symbol;
            }

            bool token = false;

            for(int i = 0; i < charArraySampleTekst.Length; i++)
            {
                token = newCharArray[i].Equals(charArraySampleTekst[i]);
            }

            Assert.True(token);

           

        }
    }
}
