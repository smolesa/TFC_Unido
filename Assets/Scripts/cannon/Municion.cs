using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Municion : MonoBehaviour {
	private cannon2 canon;
	private GUIText text;
	public Text balas;
	void Awake (){
		canon = GameObject.Find ("cannon").GetComponent<cannon2> ();
	}
	
	// Update is called once per frame
	void OnGUI () {
	balas.text = "Munición:  "+canon.Cmunicion;
	}
}
