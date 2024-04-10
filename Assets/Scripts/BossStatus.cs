using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BossStatus : MonoBehaviour
{
    
    public float vidaAtual;
    
    public float vidaTotal;

    int valorMoedas;

    UpgradesSystem coins;
    Animator animator;

    private void Start()
    {
        coins = GameObject.FindWithTag("Coins").GetComponent<UpgradesSystem>();
        animator = GetComponent<Animator>();
        vidaTotal = Random.Range(100,200);
        valorMoedas = Random.Range(50,100);
        vidaAtual = vidaTotal;
    }
    private void Update()
    {
        
    }
    public void ReceberDano(int dano) 
    {
        vidaAtual -= dano;
        animator.SetBool("Damage",true);
        Death();
        
    }
    void Death()
    {
        if (vidaAtual <= 0) 
        {  
          coins.GetCoin(valorMoedas);  
          Destroy(gameObject);
        }
        
    }
    void DisableAnimation() 
    {
        animator.SetBool("Damage", false);
    }
}
