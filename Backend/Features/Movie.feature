Feature: Movie

@mytag
Scenario Outline: Add Movie
	Given I logged in as (<UserName>,<Password>)
	And ModelState is correct
	Then the system should return <StatusCode>

Examples: 
	| Title    | Description  | Image | Director   | StatusCode | Id  | UserName | Password |
	| Rockstar | Sampal Movie | image | Imtiaz Ali | 201        |  1  | admin    | password |
	
	

