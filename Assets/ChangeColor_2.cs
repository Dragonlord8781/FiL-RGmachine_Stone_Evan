using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ChangeColor_2 : MonoBehaviour
{
    public Material[] material;
    Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Forge")
        {
            rend.sharedMaterial = material[1];
        }
    }
}
