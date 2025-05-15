using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClonaCubos : MonoBehaviour
{
    public GameObject cuboPrefab;
    public void clonarCubo()
    {
        Instantiate(cuboPrefab);
    }

}
