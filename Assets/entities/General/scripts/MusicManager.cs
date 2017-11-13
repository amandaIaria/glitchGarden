using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip[] levelMusicArray;
	
	private AudioSource audioSource;
	
	// Use this for initialization
	void Awake(){
		DontDestroyOnLoad(gameObject);
	}
	
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	void OnLevelWasLoaded(int level){
		AudioClip thisLevelMusic = levelMusicArray[level]; 
		if(thisLevelMusic){
			audioSource.clip = thisLevelMusic;
			audioSource.loop = true;
			audioSource.Play ();
		}
	}
}
