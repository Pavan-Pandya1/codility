// you can also use imports, for example:
// import java.util.*;

// you can write to stdout for debugging purposes, e.g.
// System.out.println("this is a debug message");

class Solution {
    public int solution(String S) {
        // Implement your solution here
        //create an array of strings and use regular expression to seprate them by spaces
        //use a for loop to go through the array and check each and every string for all 3 conditions
        //whichever passess all the 3 conditions store it's length
        //return maxLength of all the passed strings
        int maxLength = 0;
        String[] words = S.split(" ");
        for (String word : words) {
            if (isAlphanumeric(word) && hasEvenLetters(word) && hasOddDigits(word)) {
                maxLength = Math.max(maxLength , word.length());
            }
        }
        return maxLength > 0 ? maxLength : -1;
    }

    public static boolean isAlphanumeric(String word) {
        return word.matches("[a-zA-Z0-9]+");
    }

    // Method to check if the word has an even number of letters
    public static boolean hasEvenLetters(String word) {
        int letterCount = 0;
        for (char c : word.toCharArray()) {
            if (Character.isLetter(c)) {
                letterCount++;
            }
        }
        return letterCount % 2 == 0;
    }

    // Method to check if the word has an odd number of digits
    public static boolean hasOddDigits(String word) {
        int digitCount = 0;
        for (char c : word.toCharArray()) {
            if (Character.isDigit(c)) {
                digitCount++;
            }
        }
        return digitCount % 2 != 0;
    }
}
