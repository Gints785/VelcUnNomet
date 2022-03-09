using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	// Uzglabā ainā esošo kanvu
	public Canvas kanva;

	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;



	[HideInInspector]
	public Vector2 atkrKoord;
	[HideInInspector]
	public Vector2 artoKoord;
	[HideInInspector]
	public Vector2 bussKoord;


	public AudioSource skanasAvots;

	public AudioClip[] skanaAtskanot;

	[HideInInspector]
	public bool valistahaVieta = false;

	public GameObject pedejaijsVilktais = null;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
