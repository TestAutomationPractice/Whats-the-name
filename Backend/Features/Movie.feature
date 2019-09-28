Feature: Movie
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: Add Movie
	Given I logged in as (<UserName>,<Password>)
	Then I add a movie  (<Title>,<Description>,<Image>,<Director>,<Rating>,<Categories>)

Examples: 
	| Title    | Description  | Image | Director   | Rating | Categories | StatusCode | Id | UserName | Password |
	| Rockstar | Sampal Movie | image | Imtiaz Ali | 4      | ABC,XYZ    | 201        |  1  | admin    | password |

