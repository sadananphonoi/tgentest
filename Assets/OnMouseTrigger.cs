using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseTrigger : MonoBehaviour
{
    public GameObject ActivePopup;

    private void OnMouseDown()
    {
        ActivePopup.SetActive(true);
    }


}
