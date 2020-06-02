# _Word Count_

#### _Word Count was created to help the user find out how many times they use each word in a sentence, latest update 05/15/2020 version 1_

#### By _**Mai C.**_



## Description

_This program was designed to help the user count how many times they used each word in the inputed sentence _

## Project Specifications

| Behavior | Input | Output |
|---|---|---|
| the program takes an inputed sentence for the user to look for a repeat word| "hey there" | Sentence = "hey there"  |
| the program takes an inputed word the user is searching for in the sentence| "hey" | searchWord = "hey"  |
| the program lowercases the inputed sentence | "HEY THERE" | "hey there |
| the program checks inputs with numbers as invalid | "h3y th3r3" | "error"/"an input contains a number" |
| the program checks if the word is the sentence, if not returns an error | sentence = "hey there", searchWord = "dog" | "sentence does not contain search word"/ "not here" |
|the program checks if user inputed empty string|searchWord/sentence = ""|"error empty input"|
|if both inputs are valid, then the program returns how many times the word is repeated in the sentence|sentence = "that dog is beautiful, that dog is a boy"|searchWord = "dog : 2"|




## Setup/Installation Requirements

_In Terminal:_

* Navigate to where you want this application to be saved, i.e.:
```cd desktop``
* Clone the file from GitHub with HTTPS
```git clone https://github.com/LonleyBuzzyBee/Word-Counter.git```
* Open file in your preferred text editor
* On Mac: ```open -a {your text editor} word-counter```
* On Windows: ```word-counter```

_To Download Manually:_

* Navigate to https://github.com/LonleyBuzzyBee/Word-Counter.
* Click green "Clone or Download" button.
* Click "Download ZIP".
* Click downloaded file to unzip.
* Open folder called "word-counter-master".
* Right click "word.cs" and select your preferred browser or text editor.

## Known Bugs

_No known bugs at this time._

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/LonleyBuzzyBee/Word-Counter/issues) here on GitHub._

## Technologies Used

_C#_
_DotNet_
_MarkDown_

### License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2020 **_Mai C._**