using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShoot : MonoBehaviour
{
    public GameObject m_BallPrefab;
    public Transform m_LaunchTransform;

    private void Update()
    {
        Shoot();
    }

    public void Shoot()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject ballClone = Instantiate(
                m_BallPrefab,
                m_LaunchTransform.position,
                Quaternion.identity);
        }


    }


}
