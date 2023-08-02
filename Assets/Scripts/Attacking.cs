using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacking : MonoBehaviour
{
    private bool killable = false;

    GameObject enemyGameObject = null;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (killable == true && Input.GetKey(KeyCode.Space))
        {
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            killable = true;
            
            Destroy(other.gameObject);
        }
    }
}
