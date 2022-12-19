using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHealth : MonoBehaviour
{
    [SerializeField]
    private GameObject spawnerHealth;

    [SerializeField]
    private float timeDown;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(mspawnHealth(timeDown,spawnerHealth));

    }


    private IEnumerator mspawnHealth ( float interval, GameObject health)
    {
        yield return new WaitForSeconds (interval);
       GameObject newHealth = Instantiate(health, new Vector3( Random.Range(-5f, 5), Random.Range(-6f, 6f), 0), Quaternion.identity );
        StartCoroutine(mspawnHealth(interval, health));
    }


}
