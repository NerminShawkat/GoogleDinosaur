using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
    public float Speed;
    public float MaxSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float newSpeed = Speed * GameMan.GameManager.speedFactor * Time.deltaTime;
        float speed = newSpeed < MaxSpeed ? newSpeed : MaxSpeed;
        transform.Translate(Vector3.left * speed, Space.World);
	}
}
