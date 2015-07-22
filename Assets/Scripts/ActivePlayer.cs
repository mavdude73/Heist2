using UnityEngine;
using System.Collections;

public class ActivePlayer : MonoBehaviour {


	public bool isPlayer1 = true;
	public bool isPlayer2 = false;
	public bool isPlayer3 = false;


	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Alpha1))
		   {
			isPlayer1 = true;
			isPlayer2 = false;
			isPlayer3 = false;
		}
		if(Input.GetKeyDown(KeyCode.Alpha2))
		   {
			isPlayer1 = false;
			isPlayer2 = true;
			isPlayer3 = false;
		}
		if(Input.GetKeyDown(KeyCode.Alpha3))
		   {
			isPlayer1 = false;
			isPlayer2 = false;
			isPlayer3 = true;
		}
	}



}
