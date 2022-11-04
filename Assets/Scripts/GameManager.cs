using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI puntuacion;
    public static GameManager instance;
    public int lives = 3;
    public int points = 0;


    private void Awake()
    {
        instance = this;
    }

}
