Feature: CreateBooking

Scenario: Submit unoccupied period
	Given the start date is 2 days from now
	And the end date is 5 days from now
	When the two dates are submitted
	Then the result should be True

Scenario: Submit occupied period
	Given the start date is 10 days from now
	And the end date is 20 days from now
	When the two dates are submitted
	Then the result should be False