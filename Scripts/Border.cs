using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Border : MonoBehaviour
{
    public int score;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "" + score;
    }

    void OnTriggerEnter(Collider other)
    {
        
    }
    void OnTriggerExit(Collider other)
    {//фу, проверка по тагам :)
        if (other.tag == "Block"){
            score += 1;
            //Destroy(other.gameObject);
        }
    }
}
//нашиши мне Famtosha#8035