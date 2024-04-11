using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerButton : MonoBehaviour
{
    public GameObject painel;

    public void CloseWindow()
    {
        painel.SetActive(false);
    }
    public void OpenWindow() 
    {
        painel.SetActive(true);
    }
}
