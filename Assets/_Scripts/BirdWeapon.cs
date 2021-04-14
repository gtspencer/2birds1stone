using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// NOT a wepon for a bird, but a weapon to kill them.
public class BirdWeapon : MonoBehaviour
{

    public int weaponCost;
    public bool unlocked;
    
    public enum WeaponType
    {
        Rock, //Base "weapon"
        SlingShot,
        PebbleShooter, //Small pistol with projectile rocks
        SpaceRock, //Rocks with no gravity
        RockLauncher, //RPG Equivalent
        RockyGun, //Minigun with rocks, new name?
        MeteorShower //What is sounds like
    }

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void unlock()
    {
        unlocked = true;
    }

    public int getWeaponCost()
    {
        return weaponCost;
    }
}
