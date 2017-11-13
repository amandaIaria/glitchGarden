using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {

	const string MASTER_VOLUME_KEY = "master_volume";
	const string DIFFICULTY_KEY = "difficulty";
	const string LEVEL_KEY = "level_unlocked_";
	
	public static void SetMasterVolume(float volume){
		if(volume > 0f && volume <= 1f){
			PlayerPrefs.SetFloat (MASTER_VOLUME_KEY, volume);
		}	
		else{
			Debug.LogError("Master Volume out of range");
		}
	}
	
	public static void UnlockLevel(int level){
		if(level <= Application.levelCount -1){
			PlayerPrefs.SetInt(LEVEL_KEY + level.ToString(), 1); //use 1 for true;
		}
		else{
			Debug.LogError("The level is not in the build order");
		}
	}
	
	public static void SetDifficulty( float difficulty ){
		if(difficulty >= 1f && difficulty <= 3f){
			PlayerPrefs.SetFloat(DIFFICULTY_KEY ,difficulty);
		}
		else{
			Debug.LogError("difficulty out of range");
		}
	}
	
	public static float GetDifficulty(){
		return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
	}
	
	
	public static float GetMasterVolume(){
		return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
	}
	
	public static bool GetUnlockLevel(int level){
		int playerPrefLevel = PlayerPrefs.GetInt(LEVEL_KEY + level.ToString());
		bool unlockLevelBool = (playerPrefLevel == 1);
		
		if(level <= Application.levelCount -1){
			return unlockLevelBool;
		}
		else{
			Debug.LogError("The level is not in the build order");
			return false;
		}
	}
}
