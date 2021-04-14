using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private static PlayerManager _instance;
    public static PlayerManager Instance
    {
        get
        {
            return _instance;
        }
    }

    public int goldPerKill = 1;

    [Header("GameObjects")]
    public TextMesh killCounter;
    public TextMesh goldCounter;

    [System.NonSerialized]
    public int birdsKilled;
    [System.NonSerialized]
    public int coins;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addKill()
    {
        incrementKills();
        incrementGold();
    }

    void incrementKills()
    {
        birdsKilled++;
        killCounter.text = birdsKilled.ToString();
    }

    void incrementGold()
    {
        coins += goldPerKill;
        goldCounter.text = coins.ToString();
    }
}
