using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BossStatus : MonoBehaviour
{
    
    public float vidaAtual;  

    float valorMoedas;

    UpgradesSystem coins;
    Animator animator;
    

    private void Start()
    {
        coins = GameObject.FindWithTag("Coins").GetComponent<UpgradesSystem>();
        animator = GetComponent<Animator>();
        vidaAtual = GameManager.vidaTotal;
        valorMoedas = Random.Range(GameManager.coinsRewardsMin,GameManager.coinsRewardsMax);
    }
    public void ReceberDano(float dano) 
    {
        vidaAtual -= dano;
        animator.SetBool("Damage",true);
        Death();
        
    }
    void Death()
    {
        if (vidaAtual <= 0) 
        {
          GameManager.bossDie = true;
          coins.GetCoin(valorMoedas);  
          Destroy(gameObject);
        }
        
    }
    void DisableAnimation() 
    {
        animator.SetBool("Damage", false);
    }
}
