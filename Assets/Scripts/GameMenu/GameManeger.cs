using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{

	public static GameManeger Instance;
	[SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip backgroundAudio;

	private void Start() {
		audioSource.clip = backgroundAudio;
		audioSource.loop = true;
		audioSource.Play();
	}

	private void OnEnable()
	{
		if (Instance!=null)
		{
			Destroy(gameObject);
		}
		else
		{
			Instance = this;
			DontDestroyOnLoad(this.gameObject);
		}
	}

	public void SetHighScore(int score)
	{
		PlayerPrefs.SetInt("HighScore",score);
	}

	public int GetHighScore()
	{
		return PlayerPrefs.GetInt("HighScore");
	}
}
