using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HighScore : MonoBehaviour {

    Text text;
	// Use this for initialization
	void Start () {
        
        text = GetComponent<Text>();
        text.text = PlayerPrefs.GetInt("HighScore").ToString().PadLeft(5, '0');
	}

    public void UpdateHighScore()
    {
        text.text = PlayerPrefs.GetInt("HighScore").ToString().PadLeft(5, '0');
    }
}
