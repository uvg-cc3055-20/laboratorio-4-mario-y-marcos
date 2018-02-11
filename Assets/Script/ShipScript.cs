using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipScript : MonoBehaviour {
    /*Atributos de los movimientos de la nave*/
    Rigidbody2D rigidbody;
    private float speed = 10f;

    /*Use this for initialization*/
    void Start () {
        rigidbody = GetComponent<Rigidbody2D>();
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("floor"))
        {
            jumping = false;
        }
    }
    /* Update is called once per frame*/
    void Update () {
        float movX = Input.acceleration.x;
        rigidbody.transform.Translate(Vector2.right * speed * movX * Time.deltaTime);
	}

}
