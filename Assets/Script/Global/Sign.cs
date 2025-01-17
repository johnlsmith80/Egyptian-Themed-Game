﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sign : MonoBehaviour
{
    public GameObject dialogBox;
    public Text dialogText;
    public string dialog;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player")) {    
            dialogBox.SetActive(true);
        }

    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player")) {
            dialogBox.SetActive(false);
        }
    }

}
