Feature: Employee
	Test employee pages working correctly
@TestEmployee
Scenario: Create Employee with details 
	Given I am on the EA website
	When I click login link 
	When I enter login details
	| UserName | Password |
	| Admin    | password |
	And I click submit button
	Then I am logged in successfully
	When I click employeelist
	When I click createnew button
	And I enter employee details 
	| Name      | Salary | DurationWorked | Grade | Email            |
	| AutoUser1 | 5200   | 30             | 1     | autoUser1@ea.com |
	And I click create button