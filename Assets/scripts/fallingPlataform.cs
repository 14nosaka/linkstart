﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingPlataform : MonoBehaviour
{

    public float tempoQueda;

    private TargetJoint2D target;
    private BoxCollider2D boxcollider;
    // Start is called before the first frame update
    void Start()
    {
        target = GetComponent<TargetJoint2D>();
        boxcollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Invoke("falling", tempoQueda);
        }
    }

    void falling()
    {
        target.enabled = false;
        boxcollider.isTrigger = true;
    }
    // Metodo para verificar se a plataforma toca em algum objeto do tipo Trigger com a layer 9 e ele seja destruído
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.layer == 9)
        Destroy(gameObject);
    }


}


