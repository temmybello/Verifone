Feature: VertoneCheckout
	For me to able to view the page 
	I need to register 

@mytag
Scenario: Vertone Registration
	Given I navigate to the website " http://automationpractice.com/index.php"
	And I click signin
	And I enter email address "Temmywealthrise@gmail.com"
	And I click create and account 
	And I click Mr 
	And I enter first name "Olatunde"
	And I enter Last name "Hammer"
	And I enter email "Temmywealthrise@gmail.com"
	And I enter password "Homes121"
	And I click day 
	#And I Select Month 
	#And I Select Year 
	And I click Sign up for our newsletter 
	And I enter User First name "Olatunde"
	And I enter User Last name "Hammer"
	And I enter company "LearnWithPride"
	And I enter address "Flat 67 Llackthorn"
	And I enter city "Leyton"
	#And I select state 
	And I enter Postal code "Sw23dl"
	#And I Select country 
	And I enter Home phone 
	And I enter Mobile phone 
	When I enter assign an address alias for future reference "Danil@yahoo.co.uk"
	Then I click register