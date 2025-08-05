##Minesweeper Algorithm Competition

###Overview
This repository contains the source code for the Minesweeper Algorithm Competition.
Unlike traditional Minesweeper, the objective here is to find as many mines as possible.
Develop your own mine detection algorithm and compete to achieve the highest score!

###Game Screen
<img width="1002" height="656" alt="image" src="https://github.com/user-attachments/assets/45967952-c2b5-40a2-b6c5-b2df4e2ad1a6" />

###How to Participate
Implement your solution in the participant project provided in this solution.

Submit the resulting DLL file to the organizer.

All submitted DLLs will be pre-validated for potential cheating or abuse before the competition.

Submissions must be received at least 48 hours before the competition start time.

###Development Guidelines
<img width="485" height="589" alt="image" src="https://github.com/user-attachments/assets/5c4d5372-dd88-459a-811e-c36154d299af" />

Note: Only C# is allowed for this competition.

**Required Methods**
GetName()

Returns the participant's name.

**GetImage()**

Returns an image used for player identification in the game.

**Initialize(int width, int height)**

Called once at the start of each game. The map's width and height are provided as parameters.

**GetPosition(MineType[] mineField)**

Called alternately for each of the two players.
If a player successfully finds a mine, they get another turn. Turns continue until the player fails to find a mine.
Returns the coordinate (as a linear array index) of the tile to reveal.
The current map status is provided as a parameter.

###Restrictions###
Use of external communications or any libraries that maliciously or directly manipulate the algorithm is prohibited.
All other forms of pure computation are allowed.

**Allowed Examples:**

- Creating threads to compute during the opponent's turn
- Multi-threaded computation
- Writing fast computation libraries in C++ (source code must be submitted separately)

**Prohibited Examples:**

- Code using Socket/Pipe/Disk IO
- Runtime reflection
- Main loader memory access
- Attaching threads to the main process
- External algorithm libraries for mine detection (subject to organizer's review)

##MineType Enum Information##

public enum MineType
{
    NUMBER_0 = 0, // No adjacent mines
    NUMBER_1,     // 1 adjacent mine
    NUMBER_2,     // 2 adjacent mines
    NUMBER_3,     // 3 adjacent mines
    NUMBER_4,     // 4 adjacent mines
    NUMBER_5,     // 5 adjacent mines
    NUMBER_6,     // 6 adjacent mines
    NUMBER_7,     // 7 adjacent mines
    NUMBER_8,     // 8 adjacent mines
    CHECKED_1,    // Mine found by Player 1
    CHECKED_2,    // Mine found by Player 2
    NONE,         // Empty
    RESERVED_0    // Reserved (not used, will be announced if used in the future)
}
