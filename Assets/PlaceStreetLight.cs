using UnityEngine;

public class PlaceStreetLight : MonoBehaviour
{
    public GameObject streetLightPrefab; // Assign the street light prefab in the Inspector
    public float placementDistance = 10f; // Distance from the player to place the street light

    void Update()
    {
        // Check if the player presses the placement key (e.g. left mouse button)
        if (Input.GetMouseButtonDown(0))
        {
            // Calculate the placement position
            Vector3 placementPosition = transform.position + transform.forward * placementDistance;

            // Instantiate the street light prefab at the placement position
            Instantiate(streetLightPrefab, placementPosition, Quaternion.identity);
        }
    }
}