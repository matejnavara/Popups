using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupScript : MonoBehaviour
{
    public void ClosePopup()
    {
        Destroy(gameObject);
    }
}
