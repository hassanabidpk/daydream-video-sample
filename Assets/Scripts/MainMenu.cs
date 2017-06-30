using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

	public GvrVideoPlayerTexture video;

	public GameObject playButton;
	public GameObject pauseButton;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnPlayClicked() {
		playButton.SetActive(false);
		pauseButton.SetActive(true);
		video.Play();
	}

	public void OnPauseClicked() {
		playButton.SetActive(true);
		pauseButton.SetActive(false);
		video.Pause();
	}
}
