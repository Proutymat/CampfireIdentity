using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;

public class DialogSystem : MonoBehaviour
{
    [SerializeField] private List<GameObject> answersZones;
    [SerializeField] private Dialog currentDialog;
    
    private TextMeshProUGUI dialogZone;
    
    // Start is called before the first frame update
    void Start()
    {
        dialogZone = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("SIZE " + answersZones.Count);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            dialogZone.text = currentDialog.text; // Display the dialog text
            
            int i = 0;
            int size = currentDialog.answers.Count;
            
            // Check the 4 answer zones
            foreach (GameObject answerZone in answersZones)
            {
                // If the dialog has answers, display them
                if (i < size)
                {
                    answerZone.SetActive(true);
                    answerZone.GetComponent<TextMeshProUGUI>().text = currentDialog.answers[i].text;
                }
                // Else, hide the answer zone
                else
                {
                    answerZone.SetActive(false);
                }

                i++;
            }
        }
    }
}
