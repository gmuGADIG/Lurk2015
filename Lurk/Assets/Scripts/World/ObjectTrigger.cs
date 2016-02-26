using UnityEngine;
using System.Collections;

public class ObjectTrigger : MonoBehaviour
{
    public GameObject platforms;

    // Use this for initialization
    void Start()
    {

    }

    // Need the Lightable script here
    void OnTriggerEnter2D(Collider2D col)
    {
        Flammable lighter = col.gameObject.GetComponent<Flammable>();
        if (lighter && lighter.lit == true)
        {
            platforms.SetActive(true);
        }

    }
}