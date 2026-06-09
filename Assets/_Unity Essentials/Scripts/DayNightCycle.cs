using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Header("Day Settings")]
    [SerializeField] private float secondsPerDay = 120f;

    private void Update()
    {
        if (secondsPerDay <= 0f)
        {
            return;
        }

        float degreesPerSecond = 360f / secondsPerDay;
        transform.Rotate(Vector3.right, degreesPerSecond * Time.deltaTime, Space.Self);
    }
}