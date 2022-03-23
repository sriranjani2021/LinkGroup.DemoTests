@fstest
@desktop
Feature: LinkFundSolutions_Desktop
	Tests for the Link Fund Solutions website

	Scenario Outline: Investment managers
	Given I have opened the 'Fund Solutions' page
	When I view Funds
	Then I can select the investment managers for '<Jurisdiction>' investors
	Examples: 
	| Jurisdiction |
	| UK           |
	| Irish        |
	| Swiss        |