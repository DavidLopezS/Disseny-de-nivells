using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlManager : MonoBehaviour {

    public GameObject currentCheckPoint;

    private PlayerController player;

    public GameObject endParticle;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RespawnPlayer(){
        player.transform.position = currentCheckPoint.transform.position;
    }
}
