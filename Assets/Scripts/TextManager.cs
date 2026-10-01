using UnityEngine;
using System.Collections;
using TMPro;

public class TextManager : MonoBehaviour
{
  [SerializeField] private TMP_Text introductionField;
   [SerializeField] private TMP_Text messageField;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Introduction());
    }
    IEnumerator Introduction() { 
        introductionField.enabled = true;
        introductionField.text = "Welcome to Space 4 8. \n Move your ship with the arrows or WASD. \n Shoot with SPACE. \n Gather pickups and cycle with 'Left CTR'.  \n  Use pickups with 'E'.";
        yield return new WaitForSeconds(5f);
        introductionField.enabled = false;
    }
   public IEnumerator ShowMessage(string message) {
        messageField.enabled = true;
        messageField.text = message;
        yield return new WaitForSeconds(3f);
        messageField.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
