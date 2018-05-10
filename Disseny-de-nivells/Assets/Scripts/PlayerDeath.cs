using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour {

    public LvlManager lvlManager;

	// Use this for initialization
	void Start () {
        lvlManager = FindObjectOfType<LvlManager>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
            lvlManager.RespawnPlayer();
	}

    void OnTriggerEnter2D(Collider2D other){
        
        if(other.name == "Player")
        {
            lvlManager.RespawnPlayer();
        }
    }
}
