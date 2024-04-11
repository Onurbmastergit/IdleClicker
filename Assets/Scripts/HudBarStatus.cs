using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;

public class HudBarStatus : MonoBehaviour
{
    BossStatus status;
    public Image LifeBar;
    public TextMeshProUGUI contador;

    private void Start()
    {
        status = GetComponent<BossStatus>();
    }

    private void Update()
    {
        float fillAmount = status.vidaAtual / GameManager.vidaTotal;
        LifeBar.fillAmount = fillAmount;
        contador.text = status.vidaAtual.ToString();
    }
}
