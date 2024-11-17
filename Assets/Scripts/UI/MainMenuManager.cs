using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
	public string startScene = "sampleScene";
	public void StartGame()
	{
		SceneManager.LoadScene(startScene);
	}
}
