using UnityEngine;
using System.Collections;

public class PCInputMan : InputMan {

	void Update () {
        
        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.Space))
            Jump = true;
        else 
            Jump = false;

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            Dodge = true;
        else 
            Dodge = false;
	}
}
