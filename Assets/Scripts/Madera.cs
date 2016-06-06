using UnityEngine;
using System.Collections;

public class Madera : MonoBehaviour {
	int cont = 0;
	public Texture2D maderarota;
	private Renderer textureRenderer;
	void Start (){
		textureRenderer = GetComponent<Renderer> ();
	}
	void OnCollisionEnter(Collision collision){
		if (GameObject.Find ("balaCannon(Clone)") != null) {
			if (collision.gameObject.name == "balaCannon(Clone)") {
				cont ++;
				textureRenderer.material.mainTexture = maderarota;
				if (cont==2){
				Destroy (gameObject, 2f);}
			}
		}

	}
}