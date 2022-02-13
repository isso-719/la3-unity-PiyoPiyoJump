using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 6, 0);
            GetComponent<AudioSource>().Play();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Game Over!");
        SceneManager.LoadScene("GameOver");
    }

    private void OnTriggerEnter(Collider other)
    {
        score++;
        Debug.Log("Score: " + score);
        scoreText.text = "Score: " + score.ToString();
    }
}
