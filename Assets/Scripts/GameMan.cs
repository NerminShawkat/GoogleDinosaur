using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class GameMan : MonoBehaviour {
    public static GameMan GameManager;
    public float speedFactor;
    public int Meter;
    public int HighScore;
    public bool Died;
    public List<GameObject> liveObstacles;
    public InputMan InputManager;
    public ObstacleEmitter obstacleEmitter;
    public CloudEmitter cloudEmitter;
    public Tirex tirex;
    public UIMan uiManager;
    public SoundMan soundManager;
    void Awake()
    {
        GameManager = this;
    }
	// Use this for initialization
	void Start () {
        uiManager = GetComponent<UIMan>();
        soundManager = GetComponent<SoundMan>();
        speedFactor = 0;
        Meter = 0;
        HighScore = PlayerPrefs.GetInt("HighScore");
        liveObstacles = new List<GameObject>();
# if UNITY_STANDALONE
        InputManager = (InputMan)gameObject.AddComponent<PCInputMan>();
#elif UNITY_ANDROID
        InputManager = (InputMan)gameObject.AddComponent<AndroidInputMan>();
#endif
        //InputManager.enabled = false;
	}

    IEnumerator CountMeters()
    {
        while (true) { 
            yield return new WaitForSeconds(0.1f);
            Meter += 1;
            speedFactor += (1 / 1000f);
        }
    }
	// Update is called once per frame
    public void StartGame()
    {
        Live();
        tirex.StartRun();
    }

    void Live()
    {
        speedFactor = 1;
        cloudEmitter.StartEmitter();
        obstacleEmitter.StartEmitter();
        Meter = 0;
        StartCoroutine("CountMeters");
    }

    public void Die()
    {
        //soundManager.Jump.Stop();
        soundManager.Die.Play();
        int highscore = PlayerPrefs.GetInt("HighScore");
        PlayerPrefs.SetInt("HighScore", Meter > highscore ? Meter : highscore);
        speedFactor = 0;
        cloudEmitter.StopEmitter();
        obstacleEmitter.StopEmitter();
        StopAllCoroutines();
    }

    public void Retry()
    {
        RemoveAllObstaces();
        Live();
        Died = false;


    }

    void RemoveAllObstaces()
    {
        for (int i = 0; i <liveObstacles.Count; i++)
        {
            Destroy(liveObstacles[i]);
        }
        liveObstacles.Clear();
    }
}
