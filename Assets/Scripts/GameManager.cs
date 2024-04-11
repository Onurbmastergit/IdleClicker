using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool bossDie;
    int levelDificuldade;

    SpanwBoss spanwBoss;

    public static float valorMinimo = 20;
    public static float valorMaximo = 45;
    public static float vidaTotal;
    public static int coinsRewardsMin = 5;
    public static int coinsRewardsMax = 20;
    private void Start()
    {
        vidaTotal = Random.Range(valorMinimo, valorMaximo);
        spanwBoss = GameObject.FindWithTag("Respawn").GetComponent<SpanwBoss>();
        SpawnarBoss();
    }
    private void Update()
    {
        if (bossDie) 
        {
            levelDificuldade++;
            coinsRewardsMin *= levelDificuldade;
            coinsRewardsMax *= levelDificuldade;
            valorMaximo *= levelDificuldade/4f;
            valorMinimo *= levelDificuldade/4f;
            vidaTotal = Random.Range(valorMinimo, valorMaximo);
            SpawnarBoss();
        }
    }
    void SpawnarBoss() 
    {
        spanwBoss.SpawnarBoss();
    }
}
