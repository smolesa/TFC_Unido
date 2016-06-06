using UnityEngine;
using System.Collections;

public class Muerte : MonoBehaviour {
	public Texture2D caramuerte;
	private Renderer textureRenderer;
	void Start (){
		textureRenderer = GetComponent<Renderer> ();
	}
	void OnCollisionEnter(Collision collision){
		if (GameObject.Find ("balaCannon(Clone)") != null) {
			if (collision.gameObject.name == "balaCannon(Clone)") {
				Destroy (gameObject, 2.5f);
				textureRenderer.material.mainTexture = caramuerte;
			}
		}

	}
}