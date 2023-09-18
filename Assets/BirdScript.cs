using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public GameLogic logic;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        //gameObject.name = "WangBird";
        logic = GameObject.FindGameObjectsWithTag("logic")[0].GetComponent<GameLogic>();
        int loadedScore = PlayerPrefs.GetInt("highScore");
        logic.highScoreText.text = "High Score:" + loadedScore;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive) { 
            myRigidBody.velocity = Vector2.up * flapStrength;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision and dead");
        birdIsAlive = false;
        logic.gameOver();
    }
}
