﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
	public GameObject gun;
	public Transform place;
	public float delay  = 0.5f;
	public Animator a;
	private IEnumerator shoot;

    // Start is called before the first frame update
    void Start()
    {
		shoot = Shoot();
		start();
    }

	public void start(){
		StartCoroutine(shoot);
	}

	public void stop(){
		StopCoroutine(shoot);
	}

    // Update is called once per frame
    void Update()
    {
    }

	public IEnumerator Shoot() {
		while(true) {
			a.SetTrigger("Attack");
			yield return new WaitForSeconds(delay);
		}
	}

	public void Hit() {
			Instantiate(gun, place.position, place.rotation);
	}
}
