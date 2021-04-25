# 10FA_SEDOL_Validator_casestudy
This is the case study for 10FA.
Its SEDOL Validator.
Where we pass 7 char SEDOL value and we get result. 

The objective of this exercise is to implement a SEDOL checker in C# based on requirements provided below. The following provides some background information around SEDOL validation:

>SEDOL stands for Stock Exchange Daily Official List, a list of security identifiers used in the United Kingdom and Ireland for clearing purposes.
>SEDOLs are seven characters in length, consisting of two parts: a six-place alphanumeric code and a trailing check digit. 

>The check digit for a SEDOL is chosen to make the total weighted sum of all seven characters a multiple of 10. 

>The check digit is computed using a weighted sum of the first six characters. 

>Letters have the value of 9 plus their alphabet position, such that B = 11 and Z = 35. 
 
>The resulting string of numbers is then multiplied by the weighting factor as follows:

>First:  1; Second: 3; Third: 1; Fourth: 7; Fifth: 3; Sixth: 9; Seventh: 1 (the check digit)

>The character values are multiplied by the weights. 
The check digit is chosen to make the total sum, including the check digit, a multiple of 10, which can be calculated from the weighted sum of the first six characters as 

>(10 − (weighted sum modulo 10)) modulo 10.

>The first character of a user defined SEDOL is a 9.

## Instructions

* This is C# Project.
* Download or Clone Project.
* There are 3 Projects under Solution.
  * SedolValidatorInterfaces : Has all interface
  * 10FA_SEDOL_Validator_casestudy : Has All logics
  * SEDOL_Checker : Windows Form to check SEDOL
 
If you want to Use Test project, you can use 10FA_SEDOL_Validator_casestudy Project DLL. It has all Logic. 

Below is the sample Code which you can use if you want to access using DLL.

      
        SedolValidationResult Result = (SedolValidationResult)new SedolValidator().ValidateSedol("1234567");
      
