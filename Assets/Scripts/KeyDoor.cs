using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{
    public GameObject playerGameObject;
    private PlayerStats playerStats;


    private bool unlockDoor = false; //This will check if the player is within the trigger.


    // Start is called before the first frame update
    void Start()
    {
        playerStats = playerGameObject.GetComponent<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        if (unlockDoor == true && playerStats.currentKeys > 0) //Checks playerStats script for keys and makes sure you are in the trigger.
        {
            Destroy(gameObject);
            playerStats.currentKeys--; //Removes one key from PlayerStats script
        }
        unlockDoor = false; //Makes sure above code only activates if you are standing in the trigger.
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == playerGameObject) //Checks that player is the one entering the trigger
        {
            unlockDoor = true;
        }
        
    }

}
