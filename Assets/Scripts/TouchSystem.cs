using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchSystem : MonoBehaviour
{
    public BossStatus status;
    public RectTransform panelRectTransform;



    void Update()
    {
        if (status == null )
        {
            status = GameObject.FindWithTag("Boss").GetComponent<BossStatus>();
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
          
            Vector2 touchPosition = Input.GetTouch(0).position;

           
            Vector2 localTouchPosition;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(panelRectTransform, touchPosition, null, out localTouchPosition);

            // Verificar se o toque ocorreu dentro da área do painel
            if (panelRectTransform.rect.Contains(localTouchPosition))
            {
                OlhaALapada();
            }
        }
    }

    public void OlhaALapada() 
    {
        status.ReceberDano(UpgradesSystem.damage);
    }
}
