using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas : MonoBehaviour
{
    [SerializeField] public GameObject ClockPrefab = null;

    void Start()
    {
        Vector3 DefaultPosition = (transform.position - new Vector3(+715, 0));

        for (int i = 0; i < 12; i++)
        {
            GameObject clock = Instantiate(ClockPrefab, new Vector3(), Quaternion.identity, transform);
            clock.GetComponent<Clock>().AddHour = i;
            clock.transform.position = DefaultPosition+ new Vector3(0+(128*i), 0);
        }
    }
}
