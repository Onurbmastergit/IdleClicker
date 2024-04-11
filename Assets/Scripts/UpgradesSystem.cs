using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradesSystem : MonoBehaviour
{
    public static int moedas = 100;
    public static int levelWeapons = 1;
    public static float damage = 10;
    public static int buy = 10;
    Animator animator;
    public TextMeshProUGUI coins;
    public TextMeshProUGUI coins2;
    public TextMeshProUGUI levelEx;
    public TextMeshProUGUI damageLvl;
    public TextMeshProUGUI buyLvl;

    private void Start()
    {
        animator = GetComponent<Animator>();
        coins.text = moedas.ToString();
    }
    private void Update()
    {
        levelEx.text = "Nível Atual: "+levelWeapons.ToString();
        damageLvl.text = "Damage: "+damage.ToString();
        buyLvl.text = buy.ToString();
        coins.text = moedas.ToString();
    }

    public void GetCoin(int valor) 
    {
        coins2.text = "+" +valor.ToString();
        animator.SetBool("Coins", true);
        moedas += valor;

    }

    public void DisableAnimation() 
    {
        animator.SetBool("Coins", false);
    }
    public void ComprarLevel() 
    {
        if (moedas >= buy)
        {
            animator.SetBool("Coins", true);
            coins2.text = "-" + buy.ToString();
            
            levelWeapons++;
            damage += levelWeapons;
            buy = (int)damage * 2;
            moedas -= buy;
            
        }
    }
    public void Compra2x() 
    {
    
    }
    public void Compra4x()
    {

    }
    public void CompraMax()
    {

    }
}
