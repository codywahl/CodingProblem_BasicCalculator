using System;

namespace BasicCalculator
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            Solution mySolution = new Solution();
            Console.WriteLine(mySolution.calculate("1 + 1"));
        }
    }

    public class Solution {
        private int index = 0;

        public int calculate(String inputStr){
            int currentTotal = 0;
            int opperand = 0;
            int unaryOperator = 1;
            
            while(index < inputStr.Length){
                char currentChar = inputStr[index];
                index++;

                if(currentChar == ' '){
                    // don't change the opperand's current value
                }
                else if(Char.IsDigit(currentChar)){
                    opperand = currentChar - '0';
                }
                else if(currentChar == '('){
                    // do later -- recursive call
                }
                else if(currentChar == ')'){
                    break;                    
                }
                else if(currentChar == '+' || currentChar == '-'){

                }
                else{
                    throw new Exception("The character encountered was invalid.");
                }
            }
        }
    }
}
