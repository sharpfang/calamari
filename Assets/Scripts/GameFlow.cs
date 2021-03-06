﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlow : MonoBehaviour
{
    public GameObject WorldControllerReference;
    public GameObject CameraControllerReference;

    public int LevelLength;
    public int EnemyCount;
    public int CarCount;
    

    void Awake()
    {
        WorldControllerReference.GetComponent<WorldController>().GenerateLevel(LevelLength, EnemyCount, CarCount);
    }

	void Start() {
		CameraControllerReference.GetComponent <CameraController>().PauseFor (3f);
		AkSoundEngine.PostEvent ("Narrator_Ready", gameObject);
		Invoke ("PlayGoSound", 3f);
        //AkSoundEngine.PostEvent ("Play_StartLevel_Music", gameObject);
        //Invoke ("PlayIngameMusic", 2.5f);

	    Cursor.visible = false;
	}


	void Update() {
		
	}


	private void PlayGoSound(){
		AkSoundEngine.PostEvent ("Narrator_Go", gameObject);
	}

	private void PlayIngameMusic(){
		AkSoundEngine.PostEvent ("Play_InGame_Music", gameObject);
	}
}
