using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class HelpButton : MonoBehaviour
{
  bool enabled;
  public Button helpButton;
  public GameObject HelpMessage;
  
  // Use this for initialization
  void Start()
  {
    //Object that displays the help message is hidden at the start
    HelpMessage.GetComponent<Renderer>().enabled = false;
    //Create variable of type Button and when clicked, run the onClick function.
    Button helpBtn = helpButton.GetComponent<Button>();
    helpBtn.onClick.AddListener(onClick);
  }
  // Update is called once per frame
  void Update(){
  
  }

  //Function on what to do when button is clicked
  void onClick()
  {
    Debug.Log("Pressed Help");
    //Object that displays help message is enabled
    HelpMessage.GetComponent<Renderer>().enabled = true;
    //hideHelp function called after 10 seconds
    Invoke("hideHelp", 10);
  }

  //Function the disable and “hide” the help message
  void hideHelp()
  {
    Debug.Log("HideHelp");
    HelpMessage.GetComponent<Renderer>().enabled = false;
  }
}
