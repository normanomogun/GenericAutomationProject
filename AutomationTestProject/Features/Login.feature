Feature: Login
	In order to test login, i need to enter login details and login

@mytest
Scenario: Login with valid Credentials
	Given I am on the EA website
	When I click login link 
	When I enter login details
	| UserName | Password |
	| Admin    | password |
	And I click submit button
	Then I am logged in successfully
