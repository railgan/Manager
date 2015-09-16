using UnityEngine;
using System.Collections;

public class BasePlayer {
	//Identifying Variables
	public string playerName{get;set;}
	public int playerID{ get; set; }
	public int teamID{ get; set;}

	//Comparing Variables
	public int macro{get;set;}
	public int micro{get;set;}
	public int strategy{get;set;}
	public int multitasking{ get; set; }
	public int scouting { get; set; }
	public int score {get;set;}
	public int performance {get;set;}

	//Constructor
	public BasePlayer (string playerName, int playerID, int teamID, int macro,
	                   int micro, int strategy, int multitasking, int scouting, int score, int performance)
	{
		this.playerName = playerName;
		this.playerID = playerID;
		this.teamID = teamID;
		this.macro = macro;
		this.micro = micro;
		this.strategy = strategy;
		this.multitasking = multitasking;
		this.scouting = scouting;
		this.score = score;
		this.performance = performance;
	}


}
