using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class oturmaodasi : MonoBehaviour
{
    public int code3;

    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.name == "player")
        {
            foreach (oturmaodasi tp in FindObjectsOfType<oturmaodasi>())
            {
                if (tp.code3 == code3 && tp != this)
                {
                    Vector3 position = tp.gameObject.transform.position;
                    position.y += 2;
                    collider.gameObject.transform.position = position;

                }
            }
        }

        SceneManager.LoadScene("vrscrean04");
    }
}
