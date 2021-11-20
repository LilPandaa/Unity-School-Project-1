using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManage : MonoBehaviour
{
	public bool gameHasEnded = false;
	public Text deadText;
	public  GameObject completeLevelUI;
	
	public float restartDelay = 1f;

	void Start()
	{
		completeLevelUI.SetActive(false);
	}

	public void CompleteLevel()
	{
		completeLevelUI.SetActive(true);
	}

	public void EndGame()
	{
		if (gameHasEnded == false)
		{
			deadText.gameObject.SetActive(true);
			gameHasEnded = true;
			Invoke("Restart", restartDelay);
			
		}
		
	}

	void Restart ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}

