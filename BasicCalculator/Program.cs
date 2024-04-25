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
        private int currentIndex = 0;

        public int calculate(String inputStr){
            int currentTotal = 0;
            
            while(currentIndex < inputStr.Length){
                char currentCharacter = inputStr[currentIndex];

                if(Char.IsDigit(currentCharacter)){
                    currentTotal += currentCharacter;
                }
                if(inputStr[currentIndex] == ')'){
                    return currentTotal;
                }
            }

            currentIndex++; 
            return 0;
        }
    }
}
