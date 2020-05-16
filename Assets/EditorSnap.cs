using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class EditorSnap : MonoBehaviour
{
    [SerializeField] [Range(1f, 20f)] float gridSize = 10f;

    TextMesh positionTextMesh;

    private void Start()
    {
        positionTextMesh = GetComponentInChildren<TextMesh>();
        positionTextMesh.text = "(xx,xx)";
    }

    void Update()
    {
        Vector3 snapPos;
        snapPos.x = Mathf.RoundToInt(transform.position.x / gridSize) * gridSize;
        snapPos.z = Mathf.RoundToInt(transform.position.z / gridSize) * gridSize;

        transform.position = new Vector3(snapPos.x, 0f, snapPos.z);

        string label = "(" + snapPos.x / gridSize + "," + snapPos.z / gridSize + ")";
        positionTextMesh.text = label;
        name = "Cube" + label;
    }
}