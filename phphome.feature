Feature: phphome

A short summary of the feature

@tag1
Scenario: perform Homepage
	Given Navigate to homepage
	When  Fill the demo request form
	And  click on submit button 
	Then Instant demo request form submitted successfully



@tag2
Scenario: perform signup page
	Given Navigate to the homepage
	When  user click on signup button
	Then  it should navigate to registration page 

@tag3
Scenario: perform signin page
	Given Navigating to the homepage
	When  user click on the sigin button
	Then  it should display  the signin page 









