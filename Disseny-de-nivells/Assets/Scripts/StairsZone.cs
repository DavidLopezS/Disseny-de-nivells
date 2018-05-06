using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairsZone : MonoBehaviour {


    private PlayerController thePlayer;

	// Use this for initialization
	void Start () {
        thePlayer = FindObjectOfType<PlayerController>();
	}
	
    void OnTriggerEnter2D(Collider2D other){

        if(other.name == "Player")
        {
            thePlayer.onStairs = true; 
        }

    }

    void OnTriggerExit2D(Collider2D other)
    {

        if (other.name == "Player")
        {
            thePlayer.onStairs = false;
        }

    }
}
