using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tp : MonoBehaviour
{
    public GameObject portal;
    private GameObject puck;


    void Start()
    {
        puck = GameObject.FindWithTag("Puck");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Puck")
        {
            puck.transform.position = new Vector2(portal.transform.position.x, portal.transform.position.y);
        }
    }
}
