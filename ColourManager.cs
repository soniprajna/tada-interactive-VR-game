using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class ColourManager : MonoBehaviour {
  
  //Call objects or variables from other scripts
  public GameObject Ball1;
  public GameObject Ball2;
  public GameObject Ball3;
  Attach attach;
  
  public GameObject ResultsCanvas;
  
  //Set variables and initial counters for number of runs, score and previous number of runs
  //Variables can be accessed by other scripts
  public static int numCtr = 1;
  public static int prevCtr = 0;
  
  //random variable to store randomly generated number
  private int rand;
  
  //Use this for initialization
  void Start () {
    
    //Disabling the canvas game object that displays the results at the start
    ResultsCanvas.SetActive(false);
    
    //Enabling the ball game objects
    Ball1.GetComponent<Renderer>().enabled = true;
    Ball2.GetComponent<Renderer>().enabled = true;
    Ball3.GetComponent<Renderer>().enabled = true;
    
    //Initialising the ball colours to white
    Ball1.GetComponent<Renderer>().material.color = Color.white;
    Ball2.GetComponent<Renderer>().material.color = Color.white;
    Ball3.GetComponent<Renderer>().material.color = Color.white;
  }
  
  //Update is called once per frame
  void Update () {
    
    //Assign one ball to green. Run loop if hand has exited ball and number of runs has been incremented
    if ((numCtr > prevCtr) && (Attach.exitedYN))
    {
      
      //Generate random number between 1 and 3 to choose a ball
      rand = Random.Range(1, 4);
      
      //Console display to monitor code and variables
      Debug.Log("Manager Loop Executed");
      Debug.Log("Rand: " + rand);
      Debug.Log("Num: " + numCtr);
      Debug.Log("Prev: " + prevCtr);
      Debug.Log("Score: " + Attach.scoreCtr);
      //If random number = 1, change ball 1 to blue
      if (rand == 1)
      {
        //Reset colours at the start of each game round
        ResetColors ();

        //Changing the colour and tag of the randomly selected ball
        prevCtr++;
        Ball1.GetComponent<Renderer>().material.color = Color.blue;
        Ball1.tag = "Touchable";
        
        Debug.Log("Ball1");
        Debug.Log(rand);
      }
      //If random number = 2, change ball 2 to blue
      if (rand == 2)
      {
        //Reset colours at the start of each game round
        ResetColors ();

        //Changing the colour and tag of the randomly selected ball
        prevCtr++;
        Ball2.GetComponent<Renderer>().material.color = Color.blue;
        Ball2.tag = "Touchable";
        
        Debug.Log("Ball2");
        Debug.Log(rand);
      }
      //If random number = 3, change ball 3 to blue
      if (rand == 3)
      {

        //Reset colours at the start of each game round
        ResetColors ();

        //Changing the colour and tag of the randomly selected ball
        prevCtr++;
        Ball3.GetComponent<Renderer>().material.color = Color.blue;

        Ball3.tag = "Touchable";
        Debug.Log("Ball3");
        Debug.Log(rand);
      }
    }
    //Reset to white trough keyboard if need be
    if (Input.GetKeyUp(KeyCode.RightControl))
    {
      ResetColors ();
    }
    //Set loop to run 10 times
    //Once loop has run 10 times, do the following
    if (numCtr >= 11)
    {
      //Set exitedYN to false so Manager loop doesn’t run again
      Attach.exitedYN = false;
      Debug.Log("10 Trials done.");
      Debug.Log("Final Score is: " + Attach.scoreCtr + " out of " + (numCtr-1));
      //Disable ball game objects so Results canvas can be seen
 
      Ball1.GetComponent<Renderer>().enabled = false;
      Ball2.GetComponent<Renderer>().enabled = false;
      Ball3.GetComponent<Renderer>().enabled = false;
      ResultsCanvas.SetActive(true);
      //After displaying results screen for 10 seconds, go back to start screen
      Invoke("ReturnStartScreen", 10);
    }
    //Secondary exit option through the keyboard to enable exit at any point during the game
    if(Input.GetKey(KeyCode.Escape))
    {
      Application.Quit();
    }
  }
  //Function to reset ball colours and tags
  void ResetColors()
  {
    Ball1.GetComponent<Renderer>().material.color = Color.white;
    Ball2.GetComponent<Renderer>().material.color = Color.white;
    Ball3.GetComponent<Renderer>().material.color = Color.white;
    Ball1.tag = "Untagged";
    Ball2.tag = "Untagged";
    Ball3.tag = "Untagged";
  }
  //Function to return to start screen
  void ReturnStartScreen()
  {
    SceneManager.LoadScene(0);
  }
}
