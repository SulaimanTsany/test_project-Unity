﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BoardManager : MonoBehaviour {

	public GameObject successText;
	public GameObject failedText;
	public Text health;
	public Text points;
	public Text healthText;
	public Text pointsText;
	private bool showStatus = true;
	private AudioSource source;

	void Start () {
		successText.gameObject.SetActive(false);
		failedText.gameObject.SetActive(false);
		source = GetComponent<AudioSource>();
		source.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GameOver (bool win) {
		source.Pause();
		if (win) {
			successText.gameObject.SetActive(true);
		} else {
			failedText.gameObject.SetActive(true);
		}
	}

	public void ToggleStatus() {
		if (showStatus) {
			health.gameObject.SetActive(false);
			points.gameObject.SetActive(false);
			healthText.gameObject.SetActive(false);
			pointsText.gameObject.SetActive(false);
			showStatus = false;
		} else if (!showStatus) {
			health.gameObject.SetActive(true);
			points.gameObject.SetActive(true);
			healthText.gameObject.SetActive(true);
			pointsText.gameObject.SetActive(true);
			showStatus = true;
		}
	}

	public void PlayAgain () {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
	public void MainMenu () {
		SceneManager.LoadScene("MainMenu");
	}
}
