Feature: TMFeature

As a turnUp portal Admin user
I would like to create,edit and delete time and material records
So that I can manage employees time and materials successfully


@regression
Scenario:  create time record with data
	Given I logged into TurnUp portal successfully
	When I create a time record
	Then The record should be created successfully

