using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireworksManager : MonoBehaviour {

    public List<ParticleSystem> pm;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setOff()
    {
        foreach (ParticleSystem em in pm)
        {
            em.Play();
        }
    }
}
