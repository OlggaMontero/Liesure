using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deliver : MonoBehaviour {

    public GameObject player;
    public float nHab;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x > player.transform.position.x -0.3 && transform.position.x < player.transform.position.x + 0.3
            && transform.position.y > player.transform.position.y - 0.3 && transform.position.y < player.transform.position.y + 0.3)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("AHHHHHHHHHHHH");
            }
            
        }

        


    }
}
