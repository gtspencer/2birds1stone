using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdCounter : MonoBehaviour {

    private int killCount;
    public TextMesh count;

    // Use this for initialization
    void Start () {
        killCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void addKill()
    {
        killCount++;
        count.text = killCount.ToString();
    }
}
