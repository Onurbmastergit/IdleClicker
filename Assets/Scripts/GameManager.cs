using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool bossDie;
    int levelDificuldade;

    SpanwBoss spanwBoss;

    public static float vidaBase = 10;
    public static int coins = 50;
    public static float vidaTotal;
    public static int coinsRewardsMin = 5;
    public static int coinsRewardsMax = 20;
    private void Start()
    {
        vidaBase = vidaBase * (UpgradesSystem.moedas/100 * 1);
        coins = coins * (UpgradesSystem.moedas /100 * 1);
        vidaTotal = vidaBase;
        spanwBoss = GameObject.FindWithTag("Respawn").GetComponent<SpanwBoss>();
        SpawnarBoss();
    }
    private void Update()
    {
        if (bossDie) 
        {
            vidaBase = vidaBase * (UpgradesSystem.moedas/100 * 1);
            coins = coins * (UpgradesSystem.moedas/100 * 1);
            vidaTotal = vidaBase;
            SpawnarBoss();
        }
    }
    void SpawnarBoss() 
    {
        spanwBoss.SpawnarBoss();
    }
}
