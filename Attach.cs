using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Attach : MonoBehaviour {
  
  //Access to variables in ColourManager script
  public Text textComponent;
  public ColourManager colourManager;
  //Variable to keep score
  public static int scoreCtr = 0;
  
  //Variable that can be accessed by other scripts - defines whether or not hand is in the ball
  public static bool exitedYN;

  //Use this for initialization
  void Start () {
    //Initialise to true so that the Manager loop runs in ColourManager script
    exitedYN = true;
  }
  
  //Update is called once per frame
  void Update () {
  
  }
  
  //Function called when user’s “index finger” enters the ball
  void OnTriggerEnter(Collider other)
  {
    //Boolean set to false so ColourManager doesn’t start a new game round
    exitedYN = false;
    //if user touches the wrong ball (not blue, therefore not tagged)
    if (other.gameObject.tag == "Untagged")
    {
      textComponent.text = "Sorry wrong ball!";
      other.gameObject.GetComponent<Renderer>().sharedMaterial.color = Color.red;
      Debug.Log("Wrong Ball");
    }
    //if user touches the correct ball (blue, therefore tagged “touchable”)
    if (other.gameObject.tag == "Touchable")
    {
      textComponent.text = "Congratulations!";
      //Increment score since correct ball
      scoreCtr++;
      other.gameObject.GetComponent<Renderer>().sharedMaterial.color = Color.green;
      other.gameObject.tag = "Untagged";
      Debug.Log("Correct Ball, scoreCtr++");
    }
  }
  
  //Function called when user’s “index finger” exits the ball
  void OnTriggerExit(Collider other)
  {
    //Boolean set to true so ColourManager starts a new game round
    exitedYN = true;
    
    other.gameObject.GetComponent<Renderer> ().sharedMaterial.color = Color.white;
    Debug.Log ("exited");
    
    //numCtr incremented so ColourManager starts a new game round (numCtr > prevCtr)
    ColourManager.numCtr++;
  }
}
