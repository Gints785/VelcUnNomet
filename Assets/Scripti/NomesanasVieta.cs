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

				default:
					Debug.Log ("Nedefinets tags!");
					break;
				}
			}
		}
	}
}
