using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCard : MonoBehaviour
{
    [SerializeField] GameObject cardBack;
    public void OnMouseDown()
    {
        if (cardBack.activeSelf && controller.canReveal) 
        { 
            cardBack.SetActive(false);
            controller.CardRevealed(this);
        }
    }
    [SerializeField] SceneController controller;
    private int _id;
    public int Id
    {
        get { return _id; }
    }
    public void Unreveal()
    {
        cardBack.SetActive(true);
    }
    public void SetCard(int id, Sprite image)
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }
        
 }

