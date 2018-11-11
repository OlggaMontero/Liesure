using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    public PlayerController player;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "MainGround")
        {
            Destroy(gameObject, 0.01f);
            
        }

        if (col.gameObject.tag == "Player")
        {
            if (player.carry == true)
            {
                player.carry = false;
                //Debug.Log(player.carry);
                Debug.Log("Se te ha caído la maleta " + player.nMaleta);
            }

            else
            {
                Debug.Log("Menos mal que no tenías ninguna maleta encima...");
            }

            Destroy(gameObject, 0.01f);
            
        }
    }
}
