using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class cannon2 : MonoBehaviour {
	public AudioClip bigshot;
	private AudioSource audio;	
	public AudioClip smallshot;
	public Transform Spawn;
	public GameObject Bala;
	public GameObject Clonbala;
	public float Potencia;
	public float Potenciaf;
	public int Cmunicion = 5;
	private Canvas CanvasInterfaz;
		
	void Update () {
		Potencia = Mathf.PingPong (Time.time*5, 40)+15;
		disparo ();
	}
	void disparo (){
		if (GameObject.Find ("balaCannon(Clone)") == null) {
			if (Cmunicion > 0) {
				if (Input.GetKeyDown ("space")) {
					audio = GetComponent<AudioSource>();
					if (Potencia > 35f){
					audio.clip = bigshot;
					audio.Play();}
					else{
					audio.clip = smallshot;
					audio.Play();}
					
					Potenciaf = Potencia;
					Clonbala = Instantiate (Bala, Spawn.transform.position, Spawn.transform.rotation) as GameObject;
					Cmunicion--;}
				}
			else {
				Debug.LogWarning ("GAME OVER");
				SceneManager.LoadScene (0);
			}

			}
		}

	}

