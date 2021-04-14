using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class RockLauncher : MonoBehaviour
{

    public GameObject rocket;
    Rigidbody rocketRB;
    public Transform rocketCenterOfMass;
    public float thrust = 500f;
    public VRTK_InteractableObject linkedObject;
    GameObject rpg;
    // Start is called before the first frame update
    void Start()
    {
        rpg = this.gameObject;
        rocketRB = rocket.GetComponent<Rigidbody>();
        rocketRB.centerOfMass = rocketCenterOfMass.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Fire()
    {
        Debug.LogError("Fired RPG");
        rocketRB.isKinematic = false;
        rocketRB.useGravity = true;
        rocketRB.AddForce(-rpg.transform.forward * thrust);
        
    }

    protected virtual void OnEnable()
    {
        linkedObject = (linkedObject == null ? GetComponent<VRTK_InteractableObject>() : linkedObject);

        if (linkedObject != null)
        {
            linkedObject.InteractableObjectUsed += InteractableObjectUsed;
        }
    }

    protected virtual void OnDisable()
    {
        if (linkedObject != null)
        {
            linkedObject.InteractableObjectUsed -= InteractableObjectUsed;
        }
    }

    protected virtual void InteractableObjectUsed(object sender, InteractableObjectEventArgs e)
    {
        Fire();
    }
}
