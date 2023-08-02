using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int currentKeys; //Current keys player has.
    public int currentHealth; //Current HP player has.






    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth < 1) //Kills you when below 1 HP
        {
            Destroy(gameObject);
        }
    }
}
