using UnityEngine;
using System.Collections;

public class MoveObstacle : MonoBehaviour {
    public float Speed;
    public float MaxSpeed;
    Rigidbody2D rigidbdy;
	// Use this for initialization
	void Start () {
        rigidbdy = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        float newSpeed = Speed * GameMan.GameManager.speedFactor;
        float speed = newSpeed < MaxSpeed ? newSpeed : MaxSpeed;
        rigidbdy.velocity = Vector2.right * -1 * speed;
	}
}
