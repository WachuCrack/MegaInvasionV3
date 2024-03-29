using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PowerUps : MonoBehaviour
{
    public static event Action OnCollected;
    public static int total;

    private void Awake()
    {
        total++;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localRotation = Quaternion.Euler(90f, Time.time * 100f, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnCollected?.Invoke();
            Destroy(gameObject);
        }
    }
}
