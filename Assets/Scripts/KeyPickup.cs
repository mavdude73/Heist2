using UnityEngine;
using System.Collections;

public class KeyPickup : MonoBehaviour
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

		if(other.gameObject == player1)
		{
			playerInventory = player1.GetComponent<PlayerInventory>();
			playerInventory.hasKey = true;
			Destroy(gameObject);
		}
		if(other.gameObject == player2)
		{
			playerInventory = player2.GetComponent<PlayerInventory>();
			playerInventory.hasKey = true;
			Destroy(gameObject);
		}
		if(other.gameObject == player3)
		{
			playerInventory = player3.GetComponent<PlayerInventory>();
			playerInventory.hasKey = true;
			Destroy(gameObject);
		}



	}
}