using UnityEngine;
using System.Collections;

public class DoorKeyCheck : MonoBehaviour
{
	//public AudioClip keyGrab;                       // Audioclip to play when the key is picked up.
	
	
	private GameObject player1;
	private GameObject player2;
	private GameObject player3;
	private PlayerInventory playerInventory;   
	
	void Awake ()
	{
		player1 = GameObject.Find ("FPSController1");
		player2 = GameObject.Find ("FPSController2");
		player3 = GameObject.Find ("FPSController3");
	}



	
	void OnTriggerEnter (Collider other)
	{

		if (other.gameObject == player1 && player1.GetComponent<PlayerInventory>().hasKey == true)
		{
			player1.GetComponent<PlayerInventory>().hasKey = false;
			Destroy (gameObject);
		}

		if (other.gameObject == player2 && player2.GetComponent<PlayerInventory>().hasKey == true)
		{
			player2.GetComponent<PlayerInventory>().hasKey = false;
			Destroy (gameObject);
		}

		if (other.gameObject == player3 && player3.GetComponent<PlayerInventory>().hasKey == true)
		{
			player3.GetComponent<PlayerInventory>().hasKey = false;
			Destroy (gameObject);
		}



	}

}