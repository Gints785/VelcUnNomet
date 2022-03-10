using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	// Uzglabā ainā esošo kanvu
	public Canvas kanva;

	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;
	public GameObject masina;


	[HideInInspector]
	public Vector2 atkrKoord;
	[HideInInspector]
	public Vector2 artoKoord;
	[HideInInspector]
	public Vector2 bussKoord;
	[HideInInspector]
	public Vector2 masinKoord;


	public AudioSource skanasAvots;

	public AudioClip[] skanaAtskanot;

	[HideInInspector]
	public bool valistahaVieta = false;

	public GameObject pedejaijsVilktais = null;
	// Use this for initialization
	void Start () {
		atkrKoord = atkritumuMasina.GetComponent<RectTransform> ().localPosition;
		artoKoord = atraPalidziba.GetComponent<RectTransform> ().localPosition;
		bussKoord = autobuss.GetComponent<RectTransform> ().localPosition;
		masinKoord = masina.GetComponent<RectTransform> ().localPosition;
	}
	
	// Update is called once per frame

}
