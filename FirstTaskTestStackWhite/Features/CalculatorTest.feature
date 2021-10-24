Feature: CalculatorTest
	Simple calculator for adding numbers

@mytag
Scenario: Adding numbers
	Given open the calculator and closing instances
	When enter 12
	When add with 999
	When remember the result M plus
	When enter 19
	When add with a number in memory MR
	Then result is 1030
	Given click the OK button