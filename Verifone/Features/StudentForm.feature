Feature: StudentForm
	Simple calculator for adding two numbers

@mytag
Scenario: Student Registration
	Given User navigate to the website "https://demoqa.com/automation-practice-form"
	And I enter First name "Henry"
	And I enter last name "John"
	And I enter Email "HenryJohn333@gmail.com"
	And I click female
	And I enter mobile number
	And i click date of birth
	And I Click day 
	And User click month drop down
	And User select month
	And User click year drop down
	And User select year
	And I Click subject 
	And I Click subject input
	And I click English
	And I click Hobbies
	And I click music
	And I click picture "house.jpg"
    And I enter current address "Flat 6 sopmaths way, london"
	And I Click city
	And I click Arts
	And I click city drop down
	And  I select state drop down
	And I click NCR
	And i click Rajasthan
	Then I click submit