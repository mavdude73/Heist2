using UnityEngine;
using System.Collections;

public class KeyPickup : MonoBehaviour
{
	//public AudioClip keyGrab;                       // Audioclip to play when the key is picked up.
	
	
	private GameObject player;                      // Reference to the player.
	private PlayerInventory playerInventory;        // Reference to the player's inventory.
//	private GameObject playerChild;
	
	void Awake ()
	{
		// Setting up the references.
		player = GameObject.FindGameObjectWithTag("Player1");
		playerInventory = player.GetComponent<PlayerInventory>();
	}
	
	
	void OnTriggerEnter (Collider other)
	{

		if(other.gameObject == player)
		{
			playerInventory.hasKey = true;
			Destroy(gameObject);
		}



	}
}