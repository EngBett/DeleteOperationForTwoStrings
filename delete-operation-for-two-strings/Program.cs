using System;

namespace delete_operation_for_two_strings
{

    public class Solution {
        public static int MinDistance(string word1, string word2) {
            var store = new int[word1.Length+1,word2.Length+1];
      
            for(var i=word1.Length;i>=0;i--){
                for(var j=word2.Length;j>=0;j--){

                    if(i==word1.Length || j==word2.Length) continue;

                    if(word1[i]==word2[j]){
                        store[i,j] = 1 + store[i+1,j+1];
                    }else{
                        store[i,j] = Math.Max(store[i+1,j],store[i,j+1]);
                    }
                }
            }

            return word1.Length + word2.Length - (2*store[0,0]);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "frog", str2 = "dog";
            
            Console.WriteLine(Solution.MinDistance(str1,str2));
        }
    }
}