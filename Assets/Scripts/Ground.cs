using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {
    
    public float ResetDistance;
    public GameObject Other;

    float size;
	// Use this for initialization
	void Start () {
        size = GetComponent<SpriteRenderer>().bounds.size.x;
	}
	
	// Update is called once per frame
	void Update () {
        

        if (transform.position.x <= ResetDistance)
        {

            transform.position = new Vector3(Other.transform.position.x+size
                , transform.position.y, transform.position.z);

        }
        
        
	
	}
}
