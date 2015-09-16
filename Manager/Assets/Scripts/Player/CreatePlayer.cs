using UnityEngine;
using System.Collections;

public class CreatePlayer : BasePlayer {
	//Variables
	public int switchInt;




	//Methods
	public BasePlayer createNewRandomPlayer(){
	CreatePlayer player = new BasePlayer (string playerName, int playerID, int teamID, int macro,
	                                      int micro, int strategy, int multitasking, int scouting,
	                                      int score, int performance){
			//Name
			switchInt = Random.Range(1-10);
			switch(switchInt)
			{
			case 1: playerName = "Janik von Rotz";
			case 2: playerName = "Luca Kündig";
			case 3: playerName = "Stefan Beeler";
			case 4: playerName = "Reno Meyer";
			case 5: playerName = "Alexander Hauck";
			case 6: playerName = "Mike Monticoli";
			case 7: playerName = "Kevin Stadelmann";
			case 8: playerName = "Sandro Ritz";
			case 9: playerName = "Michael Lötscher";
			}

			//ID
			playerID = Random.Range (1-255





		}
		}
}
