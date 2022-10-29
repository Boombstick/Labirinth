using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
    public GameObject Target;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(Target);
        other.GetComponent<AgentMove>().enabled = false;
        other.GetComponent<Animator>().SetTrigger("Victory");
    }
}
