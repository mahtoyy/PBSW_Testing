Feature: CreateBooking

Scenario: Submit unoccupied period
	Given the start date is 2 days from now
	And the end date is 5 days from now
	When the two dates are submitted
	Then the result should be True

Scenario: Submit start date before and end date during occupied period
	Given the start date is 5 days from now
	And the end date is 15 days from now
	When the two dates are submitted
	Then the result should be False

Scenario: Submit start date before and end date after occupied period
	Given the start date is 5 days from now
	And the end date is 22 days from now
	When the two dates are submitted
	Then the result should be False


Scenario: Submit occupied period
	Given the start date is 10 days from now
	And the end date is 20 days from now
	When the two dates are submitted
	Then the result should be False

Scenario: Submit start date during occupied period and end date after occupied period
	Given the start date is 15 days from now
	And the end date is 25 days from now
	When the two dates are submitted
	Then the result should be False

Scenario: Submit both start and end date after occupied period
	Given the start date is 22 days from now
	And the end date is 30 days from now
	When the two dates are submitted
	Then the result should be True

Scenario: Submit startdate before today
	Given the start date is -1 days from now
	And the end date is 4 days from now
	When the two dates are submitted
	Then exception is thrown

Scenario: Submit startdate after enddate
	Given the start date is 5 days from now
	And the end date is 3 days from now
	When the two dates are submitted
	Then exception is thrown