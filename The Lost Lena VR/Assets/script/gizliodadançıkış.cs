using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gizliodadançıkış : MonoBehaviour
{
    public int code6;

    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.name == "player1")
        {
            foreach (gizliodadançıkış tp in FindObjectsOfType<gizliodadançıkış>())
            {
                if (tp.code6 == code6 && tp != this)
                {
                    Vector3 position = tp.gameObject.transform.position;
                    position.y += 2;
                    collider.gameObject.transform.position = position;

                }
            }
        }

        SceneManager.LoadScene("vrscrean10");
    }
}
