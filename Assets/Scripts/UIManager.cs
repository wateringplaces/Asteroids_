using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI tiempo;
    private TextMeshProUGUI puntuacion;
    public TextMeshProUGUI vidas;
    public GameObject GameOver;
    public ParticleSystem particulasMuerte;
    public GameObject gameOverUI;
    public int score;


        public void Update()
    {
        tiempo.text = Time.time.ToString("00.00");
            if (GameManager.instance.lives <= 0)

            {
            GameOver.SetActive(true);
            }

    }

}

