using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningScript : MonoBehaviour
{
  // Start is called before the first frame update
  public float speed = 10.0f;
  public bool isGrounded = false;
  public int lives = 4;
  string playerName = "user";
  private string enemyName = "Computer";
  void Start()
  {
    print("Let's start Scripting ...");
    print("speed = " + speed);
    print("isGrounded = " + isGrounded);
    print("lives = " + lives);
    print("playerName = " + playerName);
    print("enemyName = " + enemyName);
  }

  // Update is called once per frame
  void Update()
  {

  }
}
