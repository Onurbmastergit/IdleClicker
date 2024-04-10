using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpgradesSystem : MonoBehaviour
{
    public int moedas = 0;
    public int levelWeapons = 0;
    Animator animator;
    public TextMeshProUGUI coins;

    private void Start()
    {
        animator = GetComponent<Animator>();
        coins.text = moedas.ToString();
    }


    public void GetCoin(int valor) 
    {
        animator.SetBool("Coins", true);
        moedas += valor;
        coins.text = moedas.ToString();
    }

    public void DisableAnimation() 
    {
        animator.SetBool("Coins", false);
    }
}
