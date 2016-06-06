using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class cannon2 : MonoBehaviour {
	public Transform Spawn;
	public GameObject Bala;
	public GameObject Clonbala;
	public float Potencia;
	public float Potenciaf;
	public int Cmunicion = 5;

	void Update () {
		Potencia = Mathf.PingPong (Time.time*5, 40)+15;
		disparo ();
	}
	void disparo (){
		if (GameObject.Find ("balaCannon(Clone)") == null) {
			if (Cmunicion > 0) {
				if (Input.GetKeyDown ("space")) {
					Potenciaf = Potencia;
					Clonbala = Instantiate (Bala, Spawn.transform.position, Spawn.transform.rotation) as GameObject;
					Cmunicion--;
				}
			}
			else {
				Debug.LogWarning ("GAME OVER");
				SceneManager.LoadScene (0);
			}
		}

	}

}
