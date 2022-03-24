# LinkGroup.DemoTests

Date : 24/03/2022
Name : Sriranjani Vaidhyanathan

Tools Used:
Microsoft Visual Studio Enterprise 2019
Specflow - Version 3.9.58
NUnit - Version 3.13.2
Selenium.Webdriver - Version 4.1.0
Browser - Chrome

Tests:
Features - 2
1. LinkGroup feature with 2 scenarios (Smoke test and Contact test)
2. Fund Solutions feature with 1 scenario consisting of 3 tests for each of the Jurisdictions

All tests run on desktop version of the Chrome browser and I have included mobile version also for the LinkGroup feature tests. 
Tags :
@desktop - covers all 5 tests 
@mobile - covers 2 scenarios in LinkGroup feature
@lgtests - Link group tests in desktop and mobile mode (4)
@fstest - Fund solutions tests (1 test with 3 scenarios)
@smoke - Smoke test in Link Group feature

Tests can be run from the Test Explorer in visual studio by selecting the appropriate trait/category.

Report:
Specflow LivingDoc html report can be created by running the following from the project folder in the command line tool after the test run.

livingdoc test-assembly "path to the dll file in the project folder" -t "path to the TestExecution.json file in the project folder"

Issues noticed in the Tech Test document:
1. Page numbers are wrong
2. Spelling mistake in the second feature - 'Found solutions' instead of 'Fund solutions'
3. Date - I received the document on 21st March but the date on it was 22nd March (Could be a feature too so not sure on this)

