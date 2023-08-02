using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKiller : MonoBehaviour
{

    public GameObject playerGameObject;
    private PlayerStats playerStats;


    private bool playerCollision = false;

    // Start is called before the first frame update
    void Start()
    {
        playerStats = playerGameObject.GetComponent<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerCollision == true)
        {
            Destroy(transform.parent.gameObject); //Destroys the enemy when it hits the player,
            playerStats.currentHealth -= 1; //Lowers players HP by one
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == playerGameObject)
        {
            playerCollision = true;
        }
    }
}
