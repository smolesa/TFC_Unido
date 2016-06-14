using UnityEngine;
using System.Collections;

public class Metal : MonoBehaviour {
	public AudioClip impacto;
	private AudioSource audio;
	public AudioClip impactobala;
	int cont = 0;
	public Texture2D metalroto1;
	public Texture2D metalroto2;
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
				if (cont==2){
                    textureRenderer.material.mainTexture = metalroto1;
                    }
				if (cont==3){
                    textureRenderer.material.mainTexture = metalroto2;
                    Destroy (gameObject, 2f);}
			
		}

	}
}
}