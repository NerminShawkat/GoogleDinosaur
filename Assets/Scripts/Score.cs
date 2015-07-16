using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

    Text text;
    Animator anim;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (GameMan.GameManager.Meter % 100 == 0 && GameMan.GameManager.Meter != 0 && !GameMan.GameManager.Died)
        {
            anim.SetTrigger("Hundred");
            GameMan.GameManager.soundManager.Hundred.Play();
        }
        text.text = GameMan.GameManager.Meter.ToString().PadLeft(5, '0'); 
	}
}
