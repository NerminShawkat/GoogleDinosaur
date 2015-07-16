using UnityEngine;
using System.Collections;

public class SpriteSelector : MonoBehaviour {
    public Sprite[] Sprites;
	// Use this for initialization
	void Start () {
        GetComponent<SpriteRenderer>().sprite = Sprites[Random.Range(0, Sprites.Length)];
	}
}
