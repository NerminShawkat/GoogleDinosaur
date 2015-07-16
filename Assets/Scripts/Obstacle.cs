using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {
    public float minScale = 0.5f;
    public float maxScale = 1;
    Rigidbody2D rigidbdy;
	// Use this for initialization
	void Start () {
        transform.localScale = Vector2.one * Random.Range(minScale,maxScale);
        rigidbdy = GetComponent<Rigidbody2D>();
	}
	
	void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.tag == "Player")
        {
            GameMan.GameManager.Died = true;
        }
        
    }
    void OnCollisionEnter2D(Collision2D Other)
    {
        if (Other.gameObject.tag == "Ground")
        {
            rigidbdy.isKinematic = true;
        }
    }
}
