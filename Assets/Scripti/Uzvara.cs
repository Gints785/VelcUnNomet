using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Uzvara : MonoBehaviour {

	public GameObject Win;
	static public bool[] Place = new bool[11];
	int parbaude = 0;
	static public bool UZV = false;


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Parbaude");
		//parbauda vietas
		for (int i = 0; 1 < Place.Length; i++) {
			if (Place [i] == true || parbaude < 11) {
				parbaude++;
			} else if (parbaude != 11) {
				parbaude = 0;
			}
		}
		if(parbaude == 11){
			Debug.Log ("Uzvareji");
			UZV = true;
			Win.SetActive(true);
		}
	}






}
