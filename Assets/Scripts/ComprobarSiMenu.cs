using UnityEngine;
using System.Collections;

public class ComprobarSiMenu : MonoBehaviour {
	public GameObject CanvasMenu;
	public GameObject Cannon;

	void Update () {

		if (CanvasMenu.GetComponent<Canvas> ().enabled) {
			Cannon.GetComponent<cannon2> ().enabled = false;
		} else {
			Cannon.GetComponent<cannon2> ().enabled = true;
		}
	}
}
