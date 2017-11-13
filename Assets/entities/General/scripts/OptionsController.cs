using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OptionsController : MonoBehaviour {
	public Slider volumeSlider;
	public Slider difficultSlider;
	public LevelManager levelManager;
	
	private MusicManager musicManager;
	
	void Start(){
		musicManager = GameObject.FindObjectOfType<MusicManager>();
		volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
		difficultSlider.value = PlayerPrefsManager.GetDifficulty();
	}
	
	void Update(){
		musicManager.ChangeVolume(volumeSlider.value);
		Debug.Log(difficultSlider.value);
	}
	
	public void SaveAndExit(){
		PlayerPrefsManager.SetMasterVolume(volumeSlider.value);
		PlayerPrefsManager.SetDifficulty(difficultSlider.value);
		levelManager.LoadLevel("01 Start");
	}
	public void SetDefaults(){
		volumeSlider.value = 0.8f;
		difficultSlider.value = 2f;
	}
}
