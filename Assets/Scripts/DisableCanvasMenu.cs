using UnityEngine;
using System.Collections;

public class DisableCanvasMenu : MonoBehaviour {

	private Canvas canvasMenu;
	public void DisableCanvas(GameObject CanvasMenu) {
		CanvasMenu.GetComponent<Canvas>().enabled = !CanvasMenu.GetComponent<Canvas>().enabled;
	}
}
