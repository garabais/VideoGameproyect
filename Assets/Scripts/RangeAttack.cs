﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeAttack : MonoBehaviour
{
	public GameObject gun;
	public Transform place;
	public Animator a;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
		if(Input.GetMouseButtonDown(0)) {
			a.SetTrigger("rangeAttack");
			GameObject g = (GameObject)Instantiate(gun, place.position, place.rotation);
		}
    }

}
