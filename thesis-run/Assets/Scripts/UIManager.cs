using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	public GameObject settingsPanel;

	public void Settings(){
		settingsPanel.SetActive (true);
	}

	public void SettingsClose() {
		settingsPanel.SetActive (false);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
