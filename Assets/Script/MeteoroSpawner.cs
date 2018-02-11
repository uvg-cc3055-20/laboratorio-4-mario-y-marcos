using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoroSpawner : MonoBehaviour {
    /*Atributo para generar las columnas*/
    public GameObject meteorBrown_big4;
    public float spawn = 4f;
    public float elapsed = 0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (ShipScript.gameover == false)
        {
            if(elapsed < spawn)
            {
                elapsed += Time.deltaTime;
            }
            else
            {
                float random = Random.Range(2f, 2f);
                Instantiate(meteorBrown_big4, new Vector3(random,8,0), Quaternion.identity);
                elapsed = 0;
            }
        }
	}
}
