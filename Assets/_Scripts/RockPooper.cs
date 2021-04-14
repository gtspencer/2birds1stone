using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockPooper : MonoBehaviour {

    public List<GameObject> rocks;
    public Transform spawnPoint;
    private int currentRocks;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (currentRocks < 20)
        {
            Instantiate(rocks[1], spawnPoint);
            Instantiate(rocks[2], spawnPoint);
            Instantiate(rocks[3], spawnPoint);
            currentRocks++;
            currentRocks++;
            currentRocks++;
        }
	}
}
