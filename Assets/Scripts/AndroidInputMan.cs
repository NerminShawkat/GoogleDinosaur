using UnityEngine;
using System.Collections;

public class AndroidInputMan : InputMan {
    
	
	void Update () {
        Touch[] touches = Input.touches;
        for (int i = 0; i < Input.touchCount; i++)
        {
            Jump = (touches[i].phase == TouchPhase.Began && touches[i].position.x > Screen.width / 2);
            Dodge = (touches[i].phase != TouchPhase.Ended && touches[i].position.x < Screen.width / 2);
        }
	
	}
}
