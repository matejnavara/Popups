using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupScript : MonoBehaviour
{
    private GameManager gm;

    void Start()
    {
        gm = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
    }
    public void ClosePopup()
    {
        gm.IncrementScore(1);
        Destroy(gameObject);
    }
}
