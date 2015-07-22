using UnityEngine;
using System.Collections;

public class KeyPickup : MonoBehaviour
{
	//public AudioClip keyGrab;                       // Audioclip to play when the key is picked up.
	
	
	private GameObject player1;
	private PlayerInventory playerInventory;        // Reference to the player's inventory.
//	private GameObject playerChild;
	
	void Awake ()
	{
		// Setting up the references.
		player1 = GameObject.Find ("FPSController1");

		playerInventory = player1.GetComponent<PlayerInventory>();
	}
	
	
	void OnTriggerEnter (Collider other)
	{

		if(other.gameObject == player1)
		{
			playerInventory.hasKey = true;
			Destroy(gameObject);
		}



	}
}