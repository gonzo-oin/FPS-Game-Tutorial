using System;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class Diaper : MonoBehaviour
{
    PhotonView PV;
    private void OnCollisionEnter(Collision other)
    {
        other.gameObject.GetComponent<IDamageable>()?.TakeDamage(20);
        PhotonNetwork.Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Awake()
    {
        PV = GetComponent<PhotonView>();
    }

    private void FixedUpdate()
    {
        // TODO: destroy when out of bounds
        // var bounds = new Bounds(Vector3.zero, new Vector3(20,20,20));
        // if (!bounds.Contains(gameObject.transform.position))
        // {
        //     PhotonNetwork.Destroy(gameObject);
        // }
    }
}
