using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_FromTO : MonoBehaviour
{

    public GameObject clickedVFX;
    public GameObject glowVFX;
    public GameObject origin;
 
    public void SpawnClickedVFX(){
        if (clickedVFX != null){
            var vfx = Instantiate(clickedVFX, origin.transform.position, Quaternion.identity) as GameObject;
            vfx.transform.SetParent(origin.transform);
            var ps = vfx.GetComponent<ParticleSystem>();
            Destroy(vfx, ps.main.duration + ps.main.startLifetime.constantMax);
        }

    }
}
