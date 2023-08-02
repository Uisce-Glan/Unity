using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalking : MonoBehaviour
{

    //This is placed on a seperate object to fix rotation issues

    private float moveSpeed = 3;

    float cycle = 1; //Creates a loop so it keeps moving
    int walkDirection; //Checks what direction

    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        walkDirection = Random.Range(0, 4);
        cycle = Random.Range(0, 2); //Randomizes how long the enemy walks in a direktion
        Invoke("Rotation", 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddRelativeForce(Vector3.forward * 10f); //Makes the enemy move forward
    }
    private void Rotation() //This will make the enemy rotate after a semi random amount of time
    {
        if (walkDirection == 0)
        {   
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        else if (walkDirection == 1)
        {
            transform.rotation = Quaternion.Euler(0f, 90f, 0f);
        }
        else if (walkDirection == 2)
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        else if (walkDirection == 3)
        {
            transform.rotation = Quaternion.Euler(0f, 270f, 0f); //These all give a random direction for the enemy to look
            
        }
        

        cycle = Random.Range(0, 2); //Randomizes how long the enemy walks in a direction during the next cycle

        walkDirection = Random.Range(0, 4); //Generates a new direction to move in next cycle
        Debug.Log(walkDirection);
        Debug.Log(cycle + "Cycle");
        Invoke("Rotation", cycle);
    }
}
