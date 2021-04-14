
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRTK
{
    public class Rock : MonoBehaviour
    {
        public FireworksManager fireworksManager;
        //public GameObject blood;
        private VRTK_InteractableObject io;
        public GameObject spawnPoint;
        private bool hitGround;
        private enum rockState
        {
            Grounded,
            Flying,
            Held
        };
        rockState rock;

        private int consecHits;

        //private bool isUsing;
        //private bool isFlying;

        // Use this for initialization
        void Start()
        {
            hitGround = false;
            fireworksManager = GameObject.FindGameObjectWithTag("Fireworks").GetComponent<FireworksManager>();
            //isUsing = false;
            //isFlying = false;
            io = GetComponent<VRTK_InteractableObject>();
            rock = rockState.Grounded;
        }

        // Update is called once per frame
        void Update()
        {
            /**
            if (io.IsGrabbed())
            {
                rock = rockState.Held;
                //Debug.Log("Picked Up");
            }
            //Debug.Log(rock);
            */

        }



        private void OnCollisionEnter(Collision collision)
        {
            
            if (collision.gameObject.tag.Equals("Bird"))
            {
                BirdUp snailDown = collision.gameObject.GetComponent<BirdUp>();
                lb_Bird bird = collision.gameObject.GetComponent<lb_Bird>();
                if (snailDown.isAlive())
                {
                    //Instantiate()
                    consecHits++;
                    snailDown.KillBird();
                    bird.KillBird();
                    Debug.Log("Hit Birds " + consecHits + " Times");
                    if (consecHits == 2)
                    {
                        fireworksManager.setOff();
                    }
                }
            } else if (collision.gameObject.tag.Equals("Ground") && !hitGround)
            {
                hitGround = true;
                StartCoroutine("waitToReset");
                consecHits = 0;
                //rock = rockState.Grounded;
            } else
            {
                consecHits = 0;
            }
        }

        IEnumerator waitToReset()
        {
            yield return new WaitForSeconds(5f);
            hitGround = false;
            this.gameObject.transform.position = spawnPoint.transform.position;
        }
    }

}
