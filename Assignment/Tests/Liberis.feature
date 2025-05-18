Feature: Liberis
	A feature file will validate the partner type and select the partner type and validate it landed on correct page or not

@mytag
Scenario: Validate it navigate successfully when selected I'm a Broker partner type
	Given User launch liberis application
	And User open Get a Demo page
	And User verified below partners on Partner Selection page
		| Partners                |
		| I'm a Broker            |
		| I'm an ISO              |
		| I'm a Strategic Partner |
	When User clicked Get a Demo button by selecting I'm a Broker parter
	Then User successfully navigates to Liberis page

Scenario: Validate error message when clicked on Get Demo without selecting the partner type
	Given User launch liberis application
	And User open Get a Demo page
	And User verified below partners on Partner Selection page
	| Partners                |
	| I'm a Broker            |
	| I'm an ISO              |
	| I'm a Strategic Partner |
	When User clicked Get a Demo button without selecting partner
	Then User validate the error message