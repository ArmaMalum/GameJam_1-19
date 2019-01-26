using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    void OnTriggerStay(Collider col) => Debug.Log("Dead!");
    void OnTriggerEnter(Collider col) => Debug.Log("Dead!");
}
