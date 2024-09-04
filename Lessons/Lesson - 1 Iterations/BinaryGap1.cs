using System;
// you can also use other imports, for example:
using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int N) {

        string binary = Convert.ToString(N, 2); //I will convert this integer into binary
        int currentGap = 0; //the current gap of the zeroz
        int maxGap = 0; //the max gap of zeros

        foreach (char bit in binary) {
            if(bit == 1) {
                // As I found a '1', I will check if the current gap is larger than max gap
                if(currentGap > maxGap)
                {
                    maxGap = currentGap;
                }
                // i will reset current gap after encountering '1'
                currentGap = 0;
            } else {
                // I will increment the current gap when I encountered a '0'
                currentGap++;
            }
        }
        return maxGap;
    }
}