﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void ResetTheGame () {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}
}
