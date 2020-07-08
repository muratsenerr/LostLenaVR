using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oyunici : MonoBehaviour
{
    //ekrandaki yazı
    public Text objectiveText;

    // şu anki yapmamız gerken
    public string currentObj;

    //görevler

    public string[] objectives;
    void Start()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {

        if (this.gameObject.tag == "Görev1")
        {
            objectiveText.text = objectives[1];
            currentObj = objectives[1];
        }

        if (this.gameObject.tag == "Görev2")
        {
            objectiveText.text = objectives[2];
            currentObj = objectives[2];
        }

        if (this.gameObject.tag == "Görev3")
        {
            objectiveText.text = objectives[3];
            currentObj = objectives[3];
        }

        if (this.gameObject.tag == "Görev4")
        {
            objectiveText.text = objectives[4];
            currentObj = objectives[4];
        }

    }
    
}
