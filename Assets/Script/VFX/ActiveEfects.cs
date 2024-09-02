using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class ActiveEfects : MonoBehaviour
{
    public ParticleSystem[] vfxEffects;
    public GameObject Boss;
    public GameObject Door1;
    public GameObject Door2;

    void Start()
    {   
        Boss.SetActive(false);
        Door1.SetActive(false);
        Door2.SetActive(true);
        ActivateAllVFXOff();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            StartCoroutine(KnowBoss());
        }
    }

    public void ActivateAllVFX()
    {
        foreach (ParticleSystem vfx in vfxEffects)
        {
            vfx.Play();
        }
    }
    public void ActivateAllVFXOff()
    {
        foreach (ParticleSystem vfx in vfxEffects)
        {
            vfx.Stop();
        }
    }

    private void AppearBoos()
    {
        Boss.SetActive(true);
        Door1.SetActive(true);
        Door2.SetActive(false);
    }

    IEnumerator KnowBoss()
    {
        ActivateAllVFX();
        yield return new WaitForSeconds(1);
        AppearBoos();

    }
}
