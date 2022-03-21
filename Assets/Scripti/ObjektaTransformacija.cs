using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjektaTransformacija : MonoBehaviour {

	public Objekti objektuSkripts;
	//Skripts kas lauj parvietot obejuktus.
	void Update () {
		if (objektuSkripts.pedejaijsVilktais != null) {
			if (Input.GetKey (KeyCode.Z)) {
				objektuSkripts.pedejaijsVilktais.GetComponent<RectTransform> ().transform.Rotate (0, 0, Time.deltaTime * 9f);
			}
			if (Input.GetKey (KeyCode.X)) {
				objektuSkripts.pedejaijsVilktais.GetComponent<RectTransform> ().transform.Rotate (0,0,-Time.deltaTime * 9f);
			}
			if (Input.GetKey (KeyCode.UpArrow)) {
				if (objektuSkripts.pedejaijsVilktais.GetComponent<RectTransform> ().transform.localScale.y < 0.8f){
					objektuSkripts.pedejaijsVilktais.GetComponent<RectTransform> ().transform.localScale
					= new Vector2(objektuSkripts.pedejaijsVilktais.GetComponent<RectTransform>().transform.localScale.x,
					objektuSkripts.pedejaijsVilktais.GetComponent<RectTransform> ().transform.localScale.y+0.001f);		
				}
			}
			if (Input.GetKey (KeyCode.DownArrow)) {
				if (objektuSkripts.pedejaijsVilktais.GetComponent<RectTransform> ().transform.localScale.y > 0.3f){
					objektuSkripts.pedejaijsVilktais.GetComponent<RectTransform> ().transform.localScale
					= new Vector2(objektuSkripts.pedejaijsVilktais.GetComponent<RectTransform>().transform.localScale.x,
					objektuSkripts.pedejaijsVilktais.GetComponent<RectTransform> ().transform.localScale.y-0.001f);
				}
			}
			if (Input.GetKey (KeyCode.LeftArrow)) {
				if (objektuSkripts.pedejaijsVilktais.GetComponent<RectTransform> ().transform.localScale.x > 0.3f){
					objektuSkripts.pedejaijsVilktais.GetComponent<RectTransform> ().transform.localScale
					= new Vector2(objektuSkripts.pedejaijsVilktais.GetComponent<RectTransform>().transform.localScale.x - 0.001f,
						objektuSkripts.pedejaijsVilktais.GetComponent<RectTransform> ().transform.localScale.y);
				}
			}
			if (Input.GetKey (KeyCode.RightArrow)) {
				if (objektuSkripts.pedejaijsVilktais.GetComponent<RectTransform> ().transform.localScale.x < 0.8f){
					objektuSkripts.pedejaijsVilktais.GetComponent<RectTransform> ().transform.localScale
					= new Vector2(objektuSkripts.pedejaijsVilktais.GetComponent<RectTransform>().transform.localScale.x + 0.001f,
						objektuSkripts.pedejaijsVilktais.GetComponent<RectTransform> ().transform.localScale.y);
				}
			}









		}
	}
}
