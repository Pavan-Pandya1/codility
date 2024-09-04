using System;
using System.Text.RegularExpressions;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(string S) {

        int maxLength = 0;
        String[] words = S.Split(' ');

        foreach(String word in words){
            if(isAlphanumeric(word) && isEvenLetters(word) && isOddDigit(word)){
                maxLength = Math.Max(maxLength, word.Length);
            }
        }
        return maxLength > 0 ? maxLength : -1;
    }

    public bool isAlphanumeric(String word) {
        return Regex.IsMatch(word, @"^[a-zA-Z0-9]+$");
    }

    public bool isEvenLetters(String word) {
        int letterCount = 0;
        foreach(char c in word) {
            if(char.IsLetter(c)){
                letterCount++;
            }
        }
        return letterCount % 2 == 0;
    }

    public bool isOddDigit(String word) {
        int digitCount = 0;
        foreach(char c in word){
            if(char.IsDigit(c)){
                digitCount++;
            }
        }

        return digitCount % 2 != 0;
    }
}