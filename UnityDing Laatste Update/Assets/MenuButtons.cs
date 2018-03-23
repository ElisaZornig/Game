using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour {


	public void MenuBack ()
	{

		SceneManager.LoadScene("Menu");
	}
	public void QuitGame()
	{
		Debug.Log("Quit!");
		Application.Quit();
	}
}
