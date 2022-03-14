using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NomesanasVieta : MonoBehaviour,IDropHandler {

	private float vietasZrot, velkObjZrot, rotacijasStarpiba, xIzmeruStarp, yIzmeruStarp;
	private Vector2 vietasIzm, velkObjIzm;


	public Objekti objektuSkripts;

	public void OnDrop(PointerEventData notikums){
		if (notikums.pointerDrag != null) {
			if (notikums.pointerDrag.tag.Equals (tag)) {
				vietasZrot = notikums.pointerDrag.GetComponent<RectTransform> ().eulerAngles.z;
				velkObjZrot = GetComponent<RectTransform> ().eulerAngles.z;

				rotacijasStarpiba = Mathf.Abs (vietasZrot - velkObjZrot);

				vietasIzm = notikums.pointerDrag.GetComponent<RectTransform> ().localScale;
				velkObjIzm = GetComponent<RectTransform> ().localScale;
				xIzmeruStarp = Mathf.Abs (vietasIzm.y - velkObjIzm.x);
				yIzmeruStarp = Mathf.Abs (vietasIzm.x - velkObjIzm.y);

				if ((rotacijasStarpiba <= 6 || rotacijasStarpiba >= 354 && rotacijasStarpiba <= 360) && (xIzmeruStarp <= 0.1 && yIzmeruStarp <= 0.1)) {
					objektuSkripts.valistahaVieta = true;

					notikums.pointerDrag.GetComponent<RectTransform> ().anchoredPosition = GetComponent<RectTransform> ().anchoredPosition;

					notikums.pointerDrag.GetComponent<RectTransform> ().localRotation = GetComponent<RectTransform> ().localRotation;

					notikums.pointerDrag.GetComponent<RectTransform> ().localScale = GetComponent<RectTransform> ().localScale;

					switch (notikums.pointerDrag.tag) {

					case "Atkritumi":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaAtskanot [1]);
						break;

					case "Slimnica":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaAtskanot [2]);
						break;

					case "Skola":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaAtskanot [3]);
						break;
					case "Civil":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaAtskanot [4]);
						break;
					case "Buv":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaAtskanot [5]);
						break;
					case "Civil2":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaAtskanot [6]);
						break;
					case "Eks":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaAtskanot [7]);
						break;
					case "Pol":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaAtskanot [8]);
						break;
					case "Buv2":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaAtskanot [9]);
						break;
					case "trak":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaAtskanot [10]);
						break;
					case "Uguns":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaAtskanot [11]);
						break;

					default:
						Debug.Log ("Nedefinets tags!");
						break;
					}
				}
			} else {
				objektuSkripts.valistahaVieta = false;
				objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaAtskanot[0]);


				switch (notikums.pointerDrag.tag) {

				case "Atkritumi":
					objektuSkripts.atkritumuMasina.GetComponent<RectTransform> ().localPosition = objektuSkripts.atkrKoord;
					break;

				case "Slimnica":
					objektuSkripts.atraPalidziba.GetComponent<RectTransform> ().localPosition = objektuSkripts.artoKoord;
					break;

				case "Skola":
					objektuSkripts.autobuss.GetComponent<RectTransform> ().localPosition = objektuSkripts.bussKoord;
					break;
				case "Civil":
					objektuSkripts.masina.GetComponent<RectTransform> ().localPosition = objektuSkripts.masinKoord;
					break;
				case "Buv":
					objektuSkripts.cementamasina.GetComponent<RectTransform> ().localPosition = objektuSkripts.cementKoord;
					break;
				case "Civil2":
					objektuSkripts.masina.GetComponent<RectTransform> ().localPosition = objektuSkripts.masin2Koord;
					break;
				case "Eks":
					objektuSkripts.ekskavators.GetComponent<RectTransform> ().localPosition = objektuSkripts.EksKoord;
					break;
				case "Pol":
					objektuSkripts.policija.GetComponent<RectTransform> ().localPosition = objektuSkripts.polKoord;
					break;
				case "Buv2":
					objektuSkripts.traktors.GetComponent<RectTransform> ().localPosition = objektuSkripts.trakKoord;
					break;
				case "trak":
					objektuSkripts.traktors2.GetComponent<RectTransform> ().localPosition = objektuSkripts.trak2Koord;
					break;
				case "Uguns":
					objektuSkripts.ugunsdzeseji.GetComponent<RectTransform> ().localPosition = objektuSkripts.ugunKoord;
					break;

				default:
					Debug.Log ("Nedefinets tags!");
					break;
				}
			}
		}
	}
}
