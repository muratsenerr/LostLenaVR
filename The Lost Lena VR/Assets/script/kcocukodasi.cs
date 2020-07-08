using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kcocukodasi : MonoBehaviour
{
    public int code4;

    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.name == "player1")
        {
            foreach (kcocukodasi tp in FindObjectsOfType<kcocukodasi>())
            {
                if (tp.code4 == code4 && tp != this)
                {
                    Vector3 position = tp.gameObject.transform.position;
                    position.y += 2;
                    collider.gameObject.transform.position = position;

                }
            }
        }

        SceneManager.LoadScene("vrscrean06");
    }
}
