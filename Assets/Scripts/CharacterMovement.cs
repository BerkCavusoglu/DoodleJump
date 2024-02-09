using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CharacterMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D doodle;
    private float movementInput;
    public TextMeshProUGUI scoretext;
    int score;

    void Update()
    {
        scoretext.text = "Score : " + score;
        movementInput = Input.GetAxis("Horizontal");
        doodle.velocity = new Vector2(speed * movementInput, doodle.velocity.y);
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (other.gameObject.tag == "Platform")
        {
            score += Random.Range(1, 5);
        }
    }
}
