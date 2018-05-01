using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {

    public LvlManager lvlManager;

    // Use this for initialization
    void Start()
    {
        lvlManager = FindObjectOfType<LvlManager>();
    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.name == "Player")
        {
            lvlManager.currentCheckPoint = gameObject;
        }
    }
}
