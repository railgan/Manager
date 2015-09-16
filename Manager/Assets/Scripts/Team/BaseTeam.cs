using UnityEngine;
using System.Collections;

public class BaseTeam {

	//Identifying Variables
	public string teamName{get;set;}
	public int teamID{ get; set;}
	public int teamRating{ get; set; }
	public int memberCount{ get; set; }

	//constructor
	public BaseTeam (string teamName, int teamID, int teamRating, int memberCount)
	{
		this.teamName = teamName;
		this.teamID = teamID;
		this.teamRating = teamRating;
		this.memberCount = memberCount;
	}
	
}
