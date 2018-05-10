﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlManager : MonoBehaviour {

    public GameObject currentCheckPoint;

    private PlayerController player;

    public GameObject deathParticle;
    public GameObject respawnParticle;
    public GameObject spikes;
    public float respawnDealy;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.G))
        {
            BoxCollider2D[] theSpikes = spikes.GetComponentsInChildren<BoxCollider2D>();
            foreach(BoxCollider2D trigger in theSpikes)
            {
                trigger.enabled = (!trigger.enabled );
            }
        }
	}

    public void RespawnPlayer(){

        StartCoroutine("RespawnPlayerCo");
        
    }

    public IEnumerator RespawnPlayerCo()
    {
        Instantiate(deathParticle, player.transform.position, player.transform.rotation);
        player.enabled = false;
        player.GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(respawnDealy);
        player.transform.position = currentCheckPoint.transform.position;
        player.enabled = true;
        player.GetComponent<Renderer>().enabled = true;
        Instantiate(respawnParticle, currentCheckPoint.transform.position, currentCheckPoint.transform.rotation);
    }
}
