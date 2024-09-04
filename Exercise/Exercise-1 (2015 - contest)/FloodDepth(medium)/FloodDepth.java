// you can also use imports, for example:
// import java.util.*;

// you can write to stdout for debugging purposes, e.g.
// System.out.println("this is a debug message");

//Similar to 43 Trapping rain water - classic sliding window question


class Solution {
    public int solution(int[] A) {
        // Implement your solution here
        int left = 0;
        int right = A.length - 1;
        int maxLeft = 0;
        int maxRight = 0;
        int waterHeight = 0;

        while(left < right){
            if(A[left] < A[right]){
                maxLeft = Math.max(maxLeft,A[left]);
                waterHeight = Math.max(waterHeight, maxLeft - A[left]);
                left++;
            }else{
                maxRight = Math.max(maxRight, A[right]);
                waterHeight = Math.max(waterHeight, maxRight - A[right]);
                right--;
            }
        }
        return waterHeight;
    }
}