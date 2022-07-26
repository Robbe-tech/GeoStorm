using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    [HideInInspector]
    public string ObjectID;
    private void Awake()
    {
        ObjectID = name + transform.position.ToString() + transform.eulerAngles.ToString();
    }
    void Start()
    {
        for (int i = 0; i < Object.FindObjectsOfType<DontDestroy>().Length; i++)
        {
            if (Object.FindObjectsOfType<DontDestroy>()[i] != this)
            {
                if (Object.FindObjectsOfType<DontDestroy>()[i].ObjectID == ObjectID)
                {
                    Destroy(gameObject);
                }
            }
        }
        DontDestroyOnLoad(gameObject);
    }
}
