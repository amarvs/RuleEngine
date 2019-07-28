# RuleEngine

App Contians Two sections

Rule:

	Inputs:
		Signal:		Source ID of the signal. (To match with the input stream signal ID) 
		Value Type:	Value type to interpret Value. (To match with the input stream value type)
		Rule:		Rule to be specified for incomming stream (Select a rule from drop down)
		Rule:		Rule to be specified for incomming stream (Select a rule from drop down)
		Value:		Value to be matched with.
		
	Actions:
		AddRule : 	AddRule will just add Rule into list view, (Will not store it into file)
		RemoveRule:	Removes the selected rule from list view.
		SetRule:	All the rules from the list view is stored into file.(updated rules are indicated in green)
		
Stream:

	Browse:	Choose a Json file for incoming stream of data (raw_data.json)
	
	Actions:
		Get All Stream Data:	Gets All the data from the json file
		Apply Rule to Stream:	Apply Stored rules to stream of data and returns the stream which violates the condition.
		
#Note
	1. 	All the data are case sensitive.
	2.	Application is executed and tested with "Visual Studio 2017" framework is targeted to ".NET Framework 4.6.1"