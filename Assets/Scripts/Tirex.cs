using UnityEngine;
using System.Collections;

public class Tirex : MonoBehaviour {
    Rigidbody2D rigidbdy;
    Animator anim;
    public float jumpSpeed = 3;
    bool Grounded;
	// Use this for initialization
	void Start () {
        rigidbdy = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}

    public void StartRun()
    {
        anim.SetTrigger("Start");
    }
	// Update is called once per frame
    void Update()
    {
        anim.SetBool("TirexDie", GameMan.GameManager.Died);
        rigidbdy.isKinematic = GameMan.GameManager.Died;
        if (GameMan.GameManager.uiManager.GameRunning)
        {
            anim.SetBool("TirexIdle", !Grounded);
            anim.SetBool("TirexDodge", GameMan.GameManager.InputManager.Dodge);
            if (GameMan.GameManager.InputManager.Jump && Grounded)
                Jump();
        }
        
	}

    void Jump()
    {
        rigidbdy.velocity = Vector2.up * jumpSpeed;
        GameMan.GameManager.soundManager.Jump.Play();
    }

    void OnCollisionEnter2D(Collision2D Other)
    {
        if (Other.gameObject.tag == "Ground")
        
            Grounded = true;
        
    }
    void OnCollisionExit2D(Collision2D Other)
    {
        if (Other.gameObject.tag == "Ground")
            Grounded = false;
    }
}
