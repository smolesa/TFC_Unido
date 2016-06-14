using UnityEngine;
using System.Collections;

public class MenuEnJuego : MonoBehaviour {
	private int a = 0;

	public GameObject CanvasMenu;
	void Update () {
		if ((Input.GetKeyDown ("escape"))&&(a == 0)) {
			CanvasMenu.GetComponent<Canvas>().enabled = !CanvasMenu.GetComponent<Canvas>().enabled;
			a = 1;
		}
		if (Input.GetKeyUp ("escape")) {
			a = 0;
		}
	}
}
