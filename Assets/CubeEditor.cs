using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[SelectionBase]
[RequireComponent(typeof(Waypoint))]
public class CubeEditor : MonoBehaviour
{
    Waypoint waypoint;

    private void Awake()
    {
        waypoint = GetComponent<Waypoint>();
    }

    private void Start()
    {
        TextMesh positionTextMesh = GetComponentInChildren<TextMesh>();
        positionTextMesh.text = "(xx,xx)";
    }

    void Update()
    {
        SnapToGrid();
        UpdateLabel();
    }

    private void UpdateLabel()
    {
        TextMesh positionTextMesh = GetComponentInChildren<TextMesh>();
        string label = "(" + waypoint.GetGridPosition().x + "," + waypoint.GetGridPosition().y + ")";
        positionTextMesh.text = label;
        name = "Cube" + label;
    }

    private void SnapToGrid()
    {
        int gridSize = waypoint.GetGridSize();
        transform.position = new Vector3(
            waypoint.GetGridPosition().x * gridSize,
            0f,
            waypoint.GetGridPosition().y * gridSize
        );
    }
}