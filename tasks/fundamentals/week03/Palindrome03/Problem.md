# Palindrome

A palindrome is a word that is also the same word, whether it is read left-to-right or right-to-left.

The following are examples of palindromes:

* racecar
* tat
* bob
* deed

What is not a palindrome:

* dog
* cat


You will need to implement the following static method to show if a word is a palindrome or not.

```
public static bool IsPalindrome(string line)
```

The method above, will require you to check to see if the word is the same left-to-right and right-to-left.

However, there are rules to solving this problem:

* You can only use one for/while loop
* Do not attempt reverse the string
* Do not use recursion.
* Do create a duplicate string

## How to run tests

You can run the test cases by using `dotnet test` from your command line interface. These should
check the method and validate it against the test cases.