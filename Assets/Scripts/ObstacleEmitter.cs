using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObstacleEmitter : MonoBehaviour {
    public GameObject[] Obstacles;
    public GameObject Bat;
    public float TimeMin;
    public float TimeMax;
    public float BatUpperRange = 1;
    public float BatLowerRange = 1;
    
	// Use this for initialization
	public void StartEmitter () {
        StartCoroutine(EmitObstacles());
	}
    public void StopEmitter()
    {
        StopAllCoroutines();
    }

    IEnumerator EmitObstacles()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(TimeMin, TimeMax));
            GameObject Obs;
            if (GameMan.GameManager.Meter < 500)
                Obs = (GameObject)Instantiate(Obstacles[Random.Range(0, Obstacles.Length)], transform.position, Quaternion.identity);
            else
            {
                bool EmitBat = Random.Range(1, 101) <= 20;
                if(EmitBat)
                    Obs = (GameObject)Instantiate(Bat, new Vector2(transform.position.x, Random.Range(transform.position.y - BatLowerRange, transform.position.y + BatUpperRange)), Quaternion.identity);
                else
                    Obs = (GameObject)Instantiate(Obstacles[Random.Range(0, Obstacles.Length)], transform.position, Quaternion.identity);
            }
            GameMan.GameManager.liveObstacles.Add(Obs);
        }

    }
}
