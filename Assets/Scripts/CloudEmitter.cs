using UnityEngine;
using System.Collections;

public class CloudEmitter : MonoBehaviour {

    public GameObject Cloud;
    public float TimeMin;
    public float TimeMax;
    public float dis;
    public float minScale;
    //public float LifeTime;
    // Use this for initialization
    public void StartEmitter()
    {
        StartCoroutine(Emit());
    }
    public void StopEmitter()
    {
        StopAllCoroutines();
    }

    IEnumerator Emit()
    {
        while (true)
        {
            GameObject cloud = (GameObject)Instantiate(Cloud,
                                          new Vector2(transform.position.x, transform.position.y + Random.Range(-dis, dis)), Quaternion.identity);

            float scale = Random.Range(minScale, 1);
            cloud.transform.localScale = (scale * Vector2.one);
            //Destroy(cloud, LifeTime);
            yield return new WaitForSeconds(Random.Range(TimeMin, TimeMax));
        }
    }
}
