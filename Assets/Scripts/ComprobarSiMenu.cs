using UnityEngine;
using System.Collections;

public class ComprobarSiMenu : MonoBehaviour {
	public GameObject CanvasMenu;
	public GameObject ScriptDisparar;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (CanvasMenu.GetComponent<Canvas> ().enabled) {
			print ("El menu esta activado");
			ScriptDisparar.GetComponent<cannon2> ().enabled = false;
		} else {
			ScriptDisparar.GetComponent<cannon2> ().enabled = true;
		}
	}
}
