using UnityEngine;
using System.Collections;

public class MenuEnJuego : MonoBehaviour {
	private int a = 0;

	public GameObject CanvasMenu;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetKeyDown ("escape"))&&(a == 0)) {
			print ("pulsada el escape");
			CanvasMenu.GetComponent<Canvas>().enabled = !CanvasMenu.GetComponent<Canvas>().enabled;
			a = 1;
		}
		if (Input.GetKeyUp ("escape")) {
			a = 0;
		}


	}
}
