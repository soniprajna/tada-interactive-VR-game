using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class dontdestroy : MonoBehaviour {
  public int score = 0;
  public Text messageText;
  public Text scoreText;
  
  // Use this for initialization
  void Start () {
    DontDestroyOnLoad(transform.gameObject);
  }

  // Update is called once per frame
  void Update () {
    score = Attach.scoreCtr;
    //Code executed once loop has run 10 times (game ends)
    if (ColourManager.numCtr >= 10)
    {
      if (score >= 7)
      {
        Debug.Log("Score > 7");
        messageText.text = "Well Done!";
        scoreText.text = "Score: " + score + "/10";
      }
      else
      {
        Debug.Log("Score < 7");
        messageText.text = "Good Effort!";
        scoreText.text = "Score: " + score + "/10";
      }
    }
  }
}
