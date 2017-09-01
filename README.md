# ProjectEuler
A collection of all my solutions to Project Euler. I will be slowly adding them to this solution as I re-build them so they are all written in C#. I will provide three C# projects to each problem. 

* A console application
* A class library
* A unit testing project

I will also below, break down breify each problem and hope to answer any queries you may have about a problem.

## Problems
Below I will write a brief description of the problem, its answer and how I solved it. Feel free to contact me for further queries if you need help.

### Problem 1 - Multiples of 3 and 5

#### The Problem
"If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
Find the sum of all the multiples of 3 or 5 below 1000."

#### The Answer
: 233168 

#### Solution
I solved the problem by first calculating all natural numbers of three and five up to 50. This leaves you with the following:

* 0, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42, 45
* 0, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50

Once written down, you begin to notice a pattern within the numbers. Every 5th natural number of three is a multiple of 5. Though this number is always the third natural number of 5.

Using the rule defined, we can create two for loops; One counting all the natural numbers of 3 and one counting all the natural numbers of 5. When counting all the natural numbers of three though I decide to skip the numbers that were both natural numbers of 3 and 5 and catch these within the next loop that was calculating the natural numbers of 5. The reason of this is to remove the risk of duplication due to the fact within a List<int> (.NET core 1.1), I have no ability to remove duplications. Once completed we do a sum of all numbers within the list and there is the answer.
