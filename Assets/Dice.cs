﻿using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using System.Collections;

public class Dice : MonoBehaviour
{

    Text writeText;
    public Sprite[] sprites;
    Image randomImg;

    // Use this for initialization
    void Start()
    {   
        randomImg = GameObject.Find("DiceImage").GetComponent<Image>();
    }

    public void WriteToTextField()
    {
        int rndDice = Random.Range(1, 7);
        randomImg.sprite = sprites[rndDice - 1];
    }
}

