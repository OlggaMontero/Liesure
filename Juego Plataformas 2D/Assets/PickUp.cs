using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    public PlayerController player;
    //public float nHab;

    private bool inside;

    // Use this for initialization
    void Start()
    {
        inside = false;
        //player = gameObject.GetComponent<PlayerController>(); //Poder acceder a las variables públicas de player
    }

    void Update()
    {
        if (inside == true && Input.GetKeyDown(KeyCode.Space))
        {
            if (player != null)                             //Hay que tener cuidado con las referencias NULL
            {
                if (player.carry == false)
                {
                    player.carry = true;
                    player.nMaleta = Random.Range(1, 10);
                    Debug.Log(player.carry);
                    Debug.Log(player.nMaleta);
                }
            }

        }

    }



    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            inside = true;

        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            inside = false;

        }
    }
}
