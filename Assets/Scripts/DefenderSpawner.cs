using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] private GameObject defender;

    private void OnMouseDown()
    {
        SpawnDefender(GetSquareClicked());
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = Input.mousePosition;
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        Vector2 gridPos = SnapToGrid(worldPos);
        return gridPos;
    }

    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float newXPos = Mathf.RoundToInt(rawWorldPos.x);
        float newYPos = Mathf.RoundToInt(rawWorldPos.y);
        return new Vector2(newXPos, newYPos);
    }

    private void SpawnDefender(Vector2 roundedPos)
    {
        GameObject newDefender =
            Instantiate(defender, roundedPos, Quaternion.identity) as GameObject;
    }
}