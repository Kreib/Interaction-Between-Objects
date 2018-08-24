using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public int Life = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnGUI()
    {
        if (Life >= 0)
        {
            GUILayout.Label("Player Life " + Life);
        }
        else
        {
            GUILayout.Label("YOU DIED");
        }

    }
}
