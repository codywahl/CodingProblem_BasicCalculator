using System;

namespace BasicCalculator
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            Solution mySolution = new Solution();
            Console.WriteLine(mySolution.calculate("(12 + 1) - (1)"));
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
                    // don't change the opperand's current value when there is a blank space, and move to the next character
                }
                else if(char.IsDigit(currentChar)){
                    int currentCharValue = (int)char.GetNumericValue(currentChar);

                    // account for a number being more than a single digit
                    if(opperand > 0){
                        opperand = 10 * opperand + currentCharValue;
                    }
                    // account for single digit numbers
                    else{
                        opperand = currentCharValue;
                    }
                }
                else if(currentChar == '('){
                    opperand = calculate(inputStr);
                }
                else if(currentChar == ')'){
                    break;                    
                }
                else if(currentChar == '+'){
                    currentTotal += unaryOperator * opperand;
                    unaryOperator = 1;
                    opperand = 0;
                }
                else if(currentChar == '-'){
                    currentTotal += unaryOperator * opperand;
                    unaryOperator = -1;
                    opperand = 0;
                }
                else{
                    throw new Exception("The character encountered was invalid.");
                }
            }

            return currentTotal += unaryOperator * opperand;
        }
    }
}
