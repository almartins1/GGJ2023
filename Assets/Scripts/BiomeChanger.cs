using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiomeChanger : MonoBehaviour
{
    public Animator animator;
    public Material[] Materials;
    public GameObject Object;
    private int BiomeIndex;

    private void Start()
    {
        BiomeIndex = 0;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {       
            FadingBiome(BiomeIndex);
        }
    }

    public void FadingBiome (int Index)
    {
        BiomeIndex = Index + 1; 
        animator.SetTrigger("Fadeout");
        animator.ResetTrigger("FadeIn");
        Debug.Log("BiomeIndex: " + BiomeIndex);
    }

    public void FadeComplete()
    {
        Object.GetComponent<MeshRenderer>().material = Materials[BiomeIndex % Materials.Length];
        animator.ResetTrigger("Fadeout");
        animator.SetTrigger("FadeIn");
    }
}
