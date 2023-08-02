using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject playerGameObject;
    private PlayerStats playerStats;

    public bool pickUpKey = false;


    // Start is called before the first frame update
    void Start()
    {
        playerStats = playerGameObject.GetComponent<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pickUpKey == true)
        {
            playerStats.currentKeys++; //Adds key to PlayerStats script.
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == playerGameObject) //Checks that player is the one entering the trigger
        {
            pickUpKey = true;
        }

    }
}
