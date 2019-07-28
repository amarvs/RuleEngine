# RuleEngine

#App Contians Two sections

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
	3.	"RuleEngineApp.zip" file contains files which in built in release mode "ReleaseModeApp.exe" can be executed directly.
	

#Discussion
	1.	Approach and Trade-off
			*	Rules are compared with each stream of data.
			*	Fetching associated rule from each stream of data by comparing stream Source id and value type with the rule Source id and value type.
			*	Compared stream Value with the Associated rule value.
	
	2.	Runtime Perfomance
			*	Run time performnace includes DeSerealization of Json file for in comming data.
			*	DeSerealization of All the rules from the file.
			*	get the rule for each stream of data and compare the stream Value with the rule value.
			*	Stream and Rule comparison includes O(n2) complexity.
	
	3.	Improvemens.
			*	Object Serealization and DeSerealization implementation need to be improved.
			*	Performance improvementation of application.
			*	Design improvement.
	
	
	
	