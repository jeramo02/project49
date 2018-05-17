﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoObjetos : MonoBehaviour {

	Rigidbody2D bloque;
	public GameManager gm; 
	public bool prueba;
	void Awake () 
	{
		bloque = GetComponent<Rigidbody2D> ();
		gm = GameObject.Find ("GameManager").GetComponent<GameManager> ();
	}

	void Update () 
	{

		transform.rotation = Quaternion.identity;
		if (prueba == true) {
			if (gm.personaje == true)
				bloque.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
			else {
				bloque.constraints = RigidbodyConstraints2D.None;	
			}
		} else {
			if (gm.personaje == true)
				bloque.mass = 1000;
			else {
				bloque.mass = 10;	
			}
		}

	}
}
