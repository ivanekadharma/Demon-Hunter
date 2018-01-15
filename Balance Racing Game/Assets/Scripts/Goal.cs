using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {
	public static bool gameOver = false;
	public GameObject panel;

	void OnTriggerEnter2D (Collider2D gl)
	{
		if (gl.CompareTag("Player"))
		{
			//Debug.Log("GAME WON! :D");
			//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			gameOver = true;
			panel.SetActive (true);



		}
	}

}
