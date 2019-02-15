# Word Counter Program
## by Tanner Damron

## Description
A program that takes a word and a sentence from the user, and checks how many times that word appears throughout the entire sentence.

## Specifications

#### Behavior: Takes user input of single letter and single letter sentence and returns number of matches
* Input: "t" and "t"
* Output: "1 Match"
* This is the simplest behavior because it is only one letter and only a one letter sentence to compare the original letter to.

#### Behavior: Takes user input of single letter and two single letter sentences and returns number of matches
* Input: "t" and "t t"
* Output: "2 Matches"
* This is the next behavior because it is one letter and two one letter sentences to compare the original letter to.

#### Behavior: Takes user input of single letter and a long sentence and returns number of matches
* Input: "t" and "I saw a t and I didn't know it was there"
* Output: "1 Match"
* This is the next behavior because it is one letter and one long sentence to compare the original letter to.

#### Behavior: Takes user input of single letter and a long sentence with multiples of the original letter and returns number of matches
* Input: "t" and "I saw a t and ate the t"
* Output: "2 Matches"
* This is the next behavior because it is one letter and one long sentence with multiples of the original letter in it to compare the original letter to.

#### Behavior: Takes user input of single word and a long sentence with a single instance of the word and returns number of matches
* Input: "cat" and "I saw a cat"
* Output: "1 Match"
* This is the next behavior because it is a whole word and one sentence to compare the original word to.

#### Behavior: Takes user input of single word and a long sentence with multiples of the original word and returns number of matches
* Input: "cat" and "I saw a cat and that cat was fat"
* Output: "2 Matches"
* This is the next behavior because it is a whole word and one sentence with multiples of the original word to compare the original word to. 

#### Behavior: Takes user input of single word and a long sentence with multiples of the original word and words with the original word being used at the beginning of the word and returns number of matches
* Input: "cat" and "I saw a cat cathedral and that cat cathedral was fat"
* Output: "2 Matches"
* This is the next behavior because it is a whole word and one sentence with multiples of the original word to compare the original word to, and words added with "cat" at the beginning of the word but the program will not count that as a match (ie cathedral).


### Setup Instructions
* Clone repository
* Add it to your desktop using "git clone""(repository link).""
* Open in preferred text editor to see all code used

### Known Bugs
* No known bugs

### Languages/Libraries Used
* C#
* .NET

### GitHub Repository Link
https://github.com/tannerdamron/csharp-WordCounter

Copyright (c) 2019 Tanner Damron.