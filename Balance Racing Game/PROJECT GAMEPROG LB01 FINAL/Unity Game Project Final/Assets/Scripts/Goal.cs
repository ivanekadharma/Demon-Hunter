using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

	public GameObject panel;

	void OnTriggerEnter2D (Collider2D gl)
	{
		if (gl.CompareTag("Player"))
		{
			panel.SetActive (true);

		}
	}

}
