using UnityEngine;
using System.Collections;

public class ComprobarSiMenu : MonoBehaviour {
	public GameObject CanvasMenu;
	public GameObject Cannon;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (CanvasMenu.GetComponent<Canvas> ().enabled) {
			Cannon.GetComponent<cannon2> ().enabled = false;
		} else {
			Cannon.GetComponent<cannon2> ().enabled = true;
		}
	}
}
