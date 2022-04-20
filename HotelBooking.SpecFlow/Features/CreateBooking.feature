Feature: CreateBooking

Scenario: Submit start date before today
	Given the start date is -1 days from now
	And the end date is 4 days from now
	When the two dates are submitted
	Then exception is thrown

Scenario: Submit startdate after enddate
	Given the start date is 5 days from now
	And the end date is 3 days from now
	When the two dates are submitted
	Then exception is thrown

Scenario Outline: Book a room in unoccupid period
	Given the start date is <start> days from now
	And the end date is <end> days from now
	When the two dates are submitted
	Then the result should be <result>

	Examples: 
		| start | end | result |
		| 2     | 5   | True   |
		| 5     | 15  | False  |
		| 5     | 22  | False  |
		| 10    | 20  | False  |
		| 15    | 25  | False  |
		| 22    | 30  | True   |