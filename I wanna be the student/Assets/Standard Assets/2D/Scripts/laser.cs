﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour {

    [SerializeField]private int time_on = 0;
    [SerializeField]private int time_off = 0;

    // Use this for initialization
    void Start () {
        InvokeRepeating("beam_anable", 0, time_off);
        InvokeRepeating("beam_disable", time_on, time_off);
    }
	
	// Update is called once per frame
	void Update () {

    }

    void beam_anable()
    {
        gameObject.transform.Find("beam").GetComponent<SpriteRenderer>().enabled = true;
        gameObject.transform.Find("beam").GetComponent<PolygonCollider2D>().enabled = true;
    }

    void beam_disable()
    {
        gameObject.transform.Find("beam").GetComponent<SpriteRenderer>().enabled = false;
        gameObject.transform.Find("beam").GetComponent<PolygonCollider2D>().enabled = false;
    }
}
