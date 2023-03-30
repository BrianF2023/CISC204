using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCard : MonoBehaviour
{
    [SerializeField] GameObject cardBack;
    public void OnMouseDown()
    {
        if (cardBack.activeSelf) { cardBack.SetActive(false); }
    }
}
