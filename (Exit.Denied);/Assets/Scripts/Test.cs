using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{

    [Header("Variables")]
    public float activatedOffset = 0.1f;
    public LayerMask layerMask;
    public string objectTag;

    [Header("Values -- DO NOT ALTER")]
    public bool activated = false;

    void Start()
    {
        Debug.Log("SCRIPT STARTED.");
    }

    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.layer);
        if (collision.gameObject.CompareTag(objectTag))
        {
            activated = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - activatedOffset, transform.position.z);
            Debug.Log("Activated.");
        }
    }

    void OnCollisionExit(Collision collision)
    {
        Debug.Log("Collision exit.");
        if (collision.gameObject.CompareTag(objectTag))
        {
            activated = false;
            transform.position = new Vector3(transform.position.x, transform.position.y + activatedOffset, transform.position.z);
            Debug.Log("De-activated.");
        }
    }

}