using UnityEngine;
using System.Collections;

public class ObstacleDestroyer : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.transform.parent)
        {
            Destroy(Other.transform.parent.gameObject);
            GameMan.GameManager.liveObstacles.Remove(Other.transform.parent.gameObject);


        }
        else
        {
            Destroy(Other.gameObject); 
            GameMan.GameManager.liveObstacles.Remove(Other.gameObject);

        }
    }
}
