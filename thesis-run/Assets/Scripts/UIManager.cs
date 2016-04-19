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

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
