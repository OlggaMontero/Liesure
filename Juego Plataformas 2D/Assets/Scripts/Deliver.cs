using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deliver : MonoBehaviour {

    public PlayerController player;
    public float nHab;

    private bool inside;

    // Use this for initialization
    void Start () {
        inside = false;
        //player = gameObject.GetComponent<PlayerController>(); //Poder acceder a las variables públicas de player
    }

    void Update()
    {
        if (inside == true && Input.GetKeyDown(KeyCode.Space))
        {
            if (player != null)                             //Hay que tener cuidado con las referencias NULL
            {
                if (player.carry == true)
                {
                    player.carry = false;
                    //Debug.Log(player.carry);
                    Debug.Log("Has entregado la maleta " + player.nMaleta + " en la habitación " + nHab);
                }

                else
                {
                    Debug.Log("No tienes ninguna maleta encima");
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





    // Update is called once per frame
    /* void Update () {
         if (transform.position.x > player.transform.position.x -0.3 && transform.position.x < player.transform.position.x + 0.3
             && transform.position.y > player.transform.position.y - 0.3 && transform.position.y < player.transform.position.y + 0.3)
         {
             if (Input.GetKeyDown(KeyCode.Space))
             {
                 Debug.Log("AHHHHHHHHHHHH");
             }

         }
     }*/



}
