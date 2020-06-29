using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RoomGenerator))]

public class GameManagerScript : MonoBehaviour
{
    private RoomGenerator rg;

    private void Start()
    {
        rg = GetComponent<RoomGenerator>();
    }
}
