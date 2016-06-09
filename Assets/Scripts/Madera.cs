using UnityEngine;
using System.Collections;

public class Madera : MonoBehaviour {
	public AudioClip impacto;
	private AudioSource audio;
	public AudioClip impactobala;
	int cont = 0;
	public Texture2D maderarota;
	private Renderer textureRenderer;
	void Start (){
		textureRenderer = GetComponent<Renderer> ();
	}
	void OnCollisionEnter(Collision collision){
		if (GameObject.Find ("balaCannon(Clone)") != null) {
			audio = GetComponent<AudioSource>();
			audio.clip = impacto;
			audio.Play();
			if (collision.gameObject.name == "balaCannon(Clone)") {
				audio = GetComponent<AudioSource>();
				audio.clip = impactobala;
				audio.Play();
				cont ++;
				textureRenderer.material.mainTexture = maderarota;
				if (cont==2){
				Destroy (gameObject, 2f);}
			}
		}

	}
}