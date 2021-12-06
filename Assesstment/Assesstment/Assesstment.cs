using System;

namespace Assesstment
{
    public class Calculator
    {

        public int Sum(string input="0"){
            char delimiter=',';
            var stringSplit = input.Split(delimiter);
            var result=0;
            foreach(var @char in stringSplit){
                result+= Int32.Parse(@char.ToString());
            }
        return result;
        }
      
    }
}
