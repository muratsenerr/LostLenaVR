using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadialCaouloutMenuu : MonoBehaviour
{
    public float timerDuration = 2f;

    private float lookTimer = 0f;

    private Renderer myRenderer;

    private BoxCollider myCollider;

    private bool isLookedAt = false;

    void Start()
    {
        myCollider = GetComponent<BoxCollider>();
        myRenderer = GetComponent<Renderer>();
        myRenderer.material.SetFloat("_Cutoff", 0f);
    }

    void Update()
    {
        if (isLookedAt)
        {
            lookTimer += Time.deltaTime;

            myRenderer.material.SetFloat("_Cutoff", lookTimer / timerDuration);

            if (lookTimer > timerDuration)
            {
                lookTimer = 0f;

                myCollider.enabled = false;

                Debug.Log("BUTTON HAS BEEN SELECTED!");

                gameObject.SetActive(false);
            }
        }
        else
        {
            lookTimer = 0f;
            myRenderer.material.SetFloat("_Cutoff", 0f);
        }
    }

    public void SetGazedAt(bool gazedAt)
    {
        isLookedAt = gazedAt;
    }
}
