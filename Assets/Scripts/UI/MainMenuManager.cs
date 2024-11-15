using Unity.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
	public string startScene = "sampleScene";
	public void StartGame()
	{
		SceneManager.LoadScene(startScene);
	}
}
