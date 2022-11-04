using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{

    public int score = 100;
    public TextMeshProUGUI puntuacion;


    // Start is called before the first frame update
    void Update()
    {
        puntuacion.text = score.ToString();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider2D other)
    {
        UnityEngine.Debug.Log("Collider is Working");
        if (other.gameObject.tag == "scoreup")
        {
            score++;
        }
    }
}
