using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Jāimport, lai lietotu visus I interfeisus
using UnityEngine.EventSystems;


public class DragDropSkirpts : MonoBehaviour,IPointerDownHandler,IBeginDragHandler, IDragHandler,IEndDragHandler{
	//Velkamajam objektam piestriprināta kompenente
	private CanvasGroup kanvasGrupa;
	//Priekš pārvietojuma objekta atrašanas vietas uzglabāšana
	private RectTransform velkObjRectTransf;

	public Objekti objektuSkripts;

	// Use this for initialization
	void Start () {
		//Piekļust objekta piestiprinātajai CanvasGroup komponentei
		kanvasGrupa = GetComponent<CanvasGroup>();
		//pieklust objekta RectTransofrm komponentei
		velkObjRectTransf = GetComponent<RectTransform>();
	}
	public void OnPointerDown(PointerEventData notikums){
		Debug.Log ("Uzklikšķināts uz velkama objekta!");
	}

	public void OnBeginDrag(PointerEventData notikums){
		Debug.Log ("Uzsākta vilkšana!");
		kanvasGrupa.alpha = 0.6f;
		kanvasGrupa.blocksRaycasts = false;
	}

	public void OnDrag(PointerEventData notikums){
		Debug.Log ("Notiekt vilkšana!");

		velkObjRectTransf.anchoredPosition += notikums.delta / objektuSkripts.kanva.scaleFactor;
	}

	public void OnEndDrag(PointerEventData notikums){
		Debug.Log ("Beigta objekta Vilkšana!");
		kanvasGrupa.alpha = 1f;


		if (objektuSkripts.valistahaVieta == false) {
			kanvasGrupa.blocksRaycasts = true;
		} else {
			objektuSkripts.pedejaijsVilktais = null;
		}

	}
}
