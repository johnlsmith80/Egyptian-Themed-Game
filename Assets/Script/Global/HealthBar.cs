﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

    public Image hpImage;
    public Image hpEffectImage;
    [HideInInspector] public float hp;
    [SerializeField] public float maxHp;
    [SerializeField] private float hurtSpeed = 0.005f;
    // Start is called before the first frame update
    void Start() {
        hp = maxHp;
    }

    // Update is called once per frame
    void Update() {
        hpImage.fillAmount = hp / maxHp;
        if (hpEffectImage.fillAmount > hpImage.fillAmount) {
            hpEffectImage.fillAmount -= hurtSpeed;
        } else {
            hpEffectImage.fillAmount = hpImage.fillAmount;
        }
    }
}
