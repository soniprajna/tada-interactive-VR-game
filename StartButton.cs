using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class StartButton : MonoBehaviour {
  bool enabled;
  public Button startButton;
  public ColourManager colourManager;

  // Use this for initialization
  void Start () {
    //Create variable of type Button and when clicked, run the onClick function.
    Button startBtn = startButton.GetComponent<Button> ();
    startBtn.onClick.AddListener(onClick);
  }
  
  // Update is called once per frame
  void Update () {
  
  }

  //Function stating what to do when button clicked
  void onClick()
  {
    Debug.Log("Pressed Start");
    SceneManager.LoadScene(1);
  }
}
