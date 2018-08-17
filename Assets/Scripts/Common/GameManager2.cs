using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager2 : MonoBehaviour {

	public void MainMenu()
	{
		SceneManager.LoadScene("Menu", LoadSceneMode.Single);
	}
}
