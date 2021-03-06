# TournamentTracker
A Tournament Tracker that sets up a schedule for teams to play each other in a single-elimination style matchup.
This is my self-motivated project, I learned it from this tutorial [Course Link](https://www.youtube.com/watch?v=wfWxdh-_k_4). 
I learned to use C# to build a complete application from start to finish.  Using .net and Visual Studio, construct a tournament tracker application that is ready to launch.

## Useful for:
- Office ping pong tournaments
- Rec league playoffs
- 3v3 basketball leagues
- And many more…

## The C# technology use in this project includes:
- Multi-form WinForms application
- In-depth Class Library
- SQL Database
- Text File Storage
- Dapper
- Linq
- Interface
- Emailing from C#
- Custom Events
- Advanced Debugging

## Big Picture Design
- Structure: Windows Forms application and Class Library
- Data: SQL and/or Text File
- Users: One at a time on one application

## Data Design
- Team: TeamMembers(List<Persion>); TeamName(string)
- Person: FirstName(string); LastName(string); EmailAddress(string); CellphoneNumber(string)
- MatchupEntry: TeamCompeting(Team); Score(double); ParentMatchup(Matchup)
- Matchup: Entries(List<MatchupEntry>); Winner(Team); MatchupRound(int)
- Tournament: TournementName(string); EntryFee(decimal); EnteredTeams(List<Team>); Prizes(List<Prize>); Rounds(List<List<Matchup>>)
- Prize: PlaceNumber(int); PlaceName(string); PrizeAmount(decimal); PrizePercentage(double)

## Multi-project solution
- Solution: TournamentTracker
- Class Library: TrackerLibrary
- Windows Form Application: TrackerUI

## Tournament Dashboard (launch view)
![image](https://user-images.githubusercontent.com/29477330/110214221-78922e80-7e58-11eb-82a0-56e709f15900.png)
## Create Tournament
![image](https://user-images.githubusercontent.com/29477330/110214276-b42cf880-7e58-11eb-8e90-1531693dbac7.png)
## Create Team
![image](https://user-images.githubusercontent.com/29477330/110214489-a0ce5d00-7e59-11eb-8aa3-580becd73e47.png)
