using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public bool gameover;
    public int score;
    public static GameController instance;
    public float spawn = 4f;
    public float elapsed = 0f;
   
	// Use this for initialization
	void Start () {
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {

        if(ShipScript.gameover == false)
        {
            if (elapsed < spawn)
            {
                elapsed += Time.deltaTime;
            }
        }
        
	}
}
