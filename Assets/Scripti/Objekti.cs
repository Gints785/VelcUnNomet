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
	public GameObject cementamasina;
	public GameObject masina2;
	public GameObject ekskavators;
	public GameObject policija;
	public GameObject traktors;
	public GameObject traktors2;
	public GameObject ugunsdzeseji;



	[HideInInspector]
	public Vector2 atkrKoord;
	[HideInInspector]
	public Vector2 artoKoord;
	[HideInInspector]
	public Vector2 bussKoord;
	[HideInInspector]
	public Vector2 masinKoord;
	[HideInInspector]
	public Vector2 cementKoord;
	[HideInInspector]
	public Vector2 masin2Koord;
	[HideInInspector]
	public Vector2 EksKoord;
	[HideInInspector]
	public Vector2 polKoord;
	[HideInInspector]
	public Vector2 trakKoord;
	[HideInInspector]
	public Vector2 trak2Koord;
	[HideInInspector]
	public Vector2 ugunKoord;



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
		cementKoord = cementamasina.GetComponent<RectTransform> ().localPosition;
		masin2Koord = masina2.GetComponent<RectTransform> ().localPosition;
		EksKoord = ekskavators.GetComponent<RectTransform> ().localPosition;
		polKoord = policija.GetComponent<RectTransform> ().localPosition;
		trakKoord = traktors.GetComponent<RectTransform> ().localPosition;
		trak2Koord = traktors2.GetComponent<RectTransform> ().localPosition;
		ugunKoord = ugunsdzeseji.GetComponent<RectTransform> ().localPosition;
	}
	
	// Update is called once per frame

}
