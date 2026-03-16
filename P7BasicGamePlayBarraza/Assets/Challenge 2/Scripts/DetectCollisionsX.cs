using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    public GameObject dog;
    private void OnTriggerEnter(Collider dog)
    {
        Destroy(gameObject);
    }
}
