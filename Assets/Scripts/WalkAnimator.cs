using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkAnimator : MonoBehaviour
{
    public MeshFilter characterModel;
    public Mesh[] modelToChangeTo;

    private bool walkDelayCheck;

    private int walkCycle;

    private int timer = 0;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Walk animation
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            if (timer  > 60) 
            {
                characterModel.mesh = modelToChangeTo[0];
                timer++;
            }
            else
            {
                characterModel.mesh = modelToChangeTo[1];
                timer++;
            }
            if (timer > 120)
            {
                timer = 0;
            }

        }
        //Changes to attack pose
        else if (Input.GetKey(KeyCode.Space))
        {
            characterModel.mesh = modelToChangeTo[3];
        }
        //Returns to idle
        else
        {
            characterModel.mesh = modelToChangeTo[2];
        }
    }
}
