@lgtests
@mobile
Feature: LinkGroup_mobile
	Tests for the Link Group website

@smoke
Scenario:001-Smoke test
Given I have opened the 'Home' page
Then the page is displayed

Scenario:002-Contact page
Given I have opened the 'Home' page
And I have agreed to the cookie policy
When I select Contact
Then the Contact page is displayed
