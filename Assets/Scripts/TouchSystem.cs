using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchSystem : MonoBehaviour
{
    public BossStatus status;
    int toques = 0;

    void Update()
    {
        if (status== null) 
        {
            status = GameObject.FindWithTag("Boss").GetComponent<BossStatus>();
        }
        if (Input.GetMouseButtonDown(0)) 
        {
            OlhaALapada();
        }
    }

    public void OlhaALapada() 
    {
        status.ReceberDano(10);
    }
}
