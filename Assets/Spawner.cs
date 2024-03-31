using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    Transform[] spawnPoints;
    [SerializeField]
    GameObject enemy;
    [SerializeField]
    int Secs;
    private void Start()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        while (true)
        {
            int num = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy, spawnPoints[num].position, Quaternion.identity);
            yield return new WaitForSeconds(Secs);
        }
    }
}
