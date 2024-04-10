using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpanwBoss : MonoBehaviour
{
    public Transform spawnBoss;
    public Transform prefabBoss;
    private void Start()
    {
        Instantiate(prefabBoss, spawnBoss);
    }
}
