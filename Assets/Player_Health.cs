using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Health : MonoBehaviour {

	public int health;
	public bool hasDied;

	// Use this for initialization
	void Start () {
		hasDied = false;		
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y < -6.5) {
			
			hasDied = true;
		}

		if (hasDied) {
			StartCoroutine ("Die");
		}
		
	}

	IEnumerator Die(){
		Debug.Log ("Player has fallen.");
		Debug.Log ("Player has died.");
		SceneManager.LoadScene ("MainGame");
		yield return null;
	}
}
