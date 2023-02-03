using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Unity.UI;
using Unity.VisualScripting;

public class EnemyCounter : MonoBehaviour
{
    public enum alphaValue
    {
        shrinking,
        growing
    }
    private TextMeshProUGUI count;
    private int enemyCount;
    private alphaValue _alphaValue;
    private float maxAplha, minAlpha, currentAlpha;
    
    // Start is called before the first frame update
    void Start()
    {
        count = GetComponentInChildren<TextMeshProUGUI>();
        maxAplha = 1f;
        minAlpha = 0.2f;
        currentAlpha = maxAplha;
        _alphaValue = alphaValue.shrinking;
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        count.text = enemyCount + "/6";
    }

    public int getEnemyCount()
    {
        return enemyCount;
    }
}
