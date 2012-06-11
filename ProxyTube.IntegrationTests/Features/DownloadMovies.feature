Feature: Download
	In order to watch youtube video at my work
	As a user
	I want to download youtube videos

@mytag
Scenario: Add youtube video to download
	Given I have entered a youtube id
	When I press add
	Then the result should be downloading youtube id on my screen
