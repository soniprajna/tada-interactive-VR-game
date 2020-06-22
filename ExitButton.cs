using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class ExitButton : MonoBehaviour
{
  bool enabled;
  public Button exitButton;
  
  // Use this for initialization
  void Start()
  {
    //Create variable of type Button and when clicked, run the onClick function.
    Button exitBtn = exitButton.GetComponent<Button>();
    exitBtn.onClick.AddListener(onClick);
  }
  
  // Update is called once per frame
  void Update()
  {
  }
  
  //Function on what to do when button is clicked
  void onClick()
  {
    Debug.Log("Pressed Exit");
    Application.Quit();
  }
}
