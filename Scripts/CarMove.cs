using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float speed;
    public GameObject winPanel;
    public GameObject gameOverPanel;
    public GameObject startButton;

    void Start()
    {
        speed = 0;
    }
    void FixedUpdate()
    {
        rigidbody.velocity = new Vector3(0,0, speed);
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Block"){
            speed = 0;
            gameOverPanel.SetActive(true);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Finish"){
            speed = 0;
            winPanel.SetActive(true);
        }
    }

    public void StartButton(){
        speed = 18;
        startButton.SetActive(false);
    }
}
