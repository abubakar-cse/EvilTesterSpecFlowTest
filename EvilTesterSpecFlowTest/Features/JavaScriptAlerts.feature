Feature: JavaScriptAlerts
	I am an user
	I am trying to navigate and click on the alert
	To be able to accept the alert


Scenario: Alert Action
	Given Navigate to the page
	When Windows Links and Examples page is opened
	And  I Click 'Alerts In A New Window From JavaScript' link
	And  Click Show prompt box
	Then Change the prompt and accept the alert
