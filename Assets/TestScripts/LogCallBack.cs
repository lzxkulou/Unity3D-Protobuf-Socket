﻿using UnityEngine;
using System.Collections;

public class LogCallBack : MonoBehaviour {

	// Use t s for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnEnable() {
        Application.RegisterLogCallback( HandleLog );
    }

    void HandleLog( string logString, string stackTrace, LogType type ) {
        Debug.Log( logString + "    " + stackTrace + "    " + type );
    }
}
