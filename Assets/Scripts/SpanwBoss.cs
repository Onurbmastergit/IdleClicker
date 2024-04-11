using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpanwBoss : MonoBehaviour
{
    public Transform spawnBoss;
    public GameObject[] prefabBoss;
    public void SpawnarBoss() 
    {
        GameManager.bossDie = false;
        Instantiate(prefabBoss[0], spawnBoss);
    }
}
