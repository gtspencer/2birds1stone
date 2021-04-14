using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdUp : MonoBehaviour {

    private bool alive;
    public ParticleSystem ps;
    //public GameObject childBird;
    //public GameObject deadBird;
    // public BirdCounter bc;

	// Use this for initialization
	void Start () {
        alive = true;
        // bc = GameObject.FindWithTag("Counter").GetComponent<BirdCounter>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void KillBird()
    {
        Debug.Log("Dead");
        PlayerManager.Instance.addKill();
        // bc.addKill();
        alive = false;
        //Rigidbody rb = gameObject.AddComponent<Rigidbody>();
        //MeshCollider mc = gameObject.GetComponent<MeshCollider>();
        //mc.convex = true;
        //ps.Play();

        //Destroy(GetComponent<Animator>())
        //StartCoroutine("waitToDestroy");
    }

    public bool isAlive()
    {
        return alive;
    }

    public void setAlive(bool a)
    {
        alive = a;
    }

    IEnumerator waitToDestroy()
    {
        yield return new WaitForSeconds(5f);
        Destroy(this.gameObject);
        //birdUp.setAlive(true);
        //Revive();

    }
}
