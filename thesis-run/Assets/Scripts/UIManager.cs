using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	public GameObject settingsPanel;

	public void Settings(){
		settingsPanel.SetActive (true);
	}

	public void SettingsClose() {
		settingsPanel.SetActive (false);
	}

	public void StartGame() {
		SceneManager.LoadScene ("Level01");
	}

	public void RestartGame() {
		SceneManager.LoadScene ("Level01");
	}

	public void ShowMenu() {
		SceneManager.LoadScene ("menu");
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
