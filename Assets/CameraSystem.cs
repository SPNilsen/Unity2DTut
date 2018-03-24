﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour {

	private GameObject player;

	public float xMin;
	public float xMax;
	public float yMin;
	public float yMax;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");

	}
	
	// Update is called once per frame at end of update
	void LateUpdate () {
		Debug.Log ("LateUpdate from: " + player.transform.position.x +","+ player.transform.position.y);
		float x = Mathf.Clamp (player.transform.position.x, xMin, xMax);
		float y = Mathf.Clamp (player.transform.position.y, yMin, yMax);

		gameObject.transform.position = new Vector3 (x, y, gameObject.transform.position.z);
		Debug.Log ("LateUpdate to: " + gameObject.transform.position.x +","+ gameObject.transform.position.y);
	}
}