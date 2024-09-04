using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // Implement your solution here
        int left = 0;
        int right = A.Length - 1;
        int maxLeft = 0;
        int maxRight = 0;
        int waterHeight = 0;

        while(left < right){
            if(A[left] < A[right]){
                maxLeft = Math.Max(maxLeft, A[left]);
                waterHeight = Math.Max(waterHeight, maxLeft - A[left]);
                left++;
            } else {
                maxRight = Math.Max(maxRight, A[right]);
                waterHeight = Math.Max(waterHeight, maxRight - A[right]);
                right--;
            }
        }
        return waterHeight;
    }
}