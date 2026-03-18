using UnityEngine;

public class CollectorZone : MonoBehaviour
{
    public string collectableTag = "Collectable";

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag(collectableTag))
        {
            return;
        }

        other.gameObject.SetActive(false);
    }
}
