using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject man1;
    [SerializeField] GameObject man2;
    [SerializeField] GameObject box;
    float[,] states = { { -1f, 0.7f, -3f }, { 0f, 0.7f, -3f }, { 1f, 0.7f, -3f }, { 3f, 0.7f, -1f }, { 3f, 0.7f, 0f }, { 3f, 0.7f, 1f }, { 1f, 0.7f, 3f }, { 0f, 0.7f, 3f }, { -1f, 0.7f, 3f }, { -3f, 0.7f, 1f }, { -3f, 0.7f, 0f }, { -3f, 0.7f, -1f } };
    void Start()
    {

    }
    
    void Update()
    {
        
    }
}
