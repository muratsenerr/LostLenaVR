using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class komşuevinegirme : MonoBehaviour
{
    public int code4;

    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.name == "player1")
        {
            foreach (komşuevinegirme tp in FindObjectsOfType<komşuevinegirme>())
            {
                if (tp.code4 == code4 && tp != this)
                {
                    Vector3 position = tp.gameObject.transform.position;
                    position.y += 2;
                    collider.gameObject.transform.position = position;

                }
            }
        }

        SceneManager.LoadScene("vrscrean03");
    }
}
