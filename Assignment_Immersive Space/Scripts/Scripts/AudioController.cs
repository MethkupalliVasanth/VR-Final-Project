using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {

	public AudioClip[] songs;
	public AudioSource audioSource;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!audioSource.isPlaying) {
			audioSource.clip = songs[Random.Range (0, songs.Length)];
			audioSource.Play();
		}
	}
}
