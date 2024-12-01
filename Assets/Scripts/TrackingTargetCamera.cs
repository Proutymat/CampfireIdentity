using UnityEngine;

public class TrackingTargetCamera : MonoBehaviour
{

    private Vector3 targetPos;

    [SerializeField] private GameObject npc1;
    [SerializeField] private GameObject npc2;
    [SerializeField] private GameObject npc3;
    [SerializeField] private GameObject player;

    private void Start()
    {
        targetPos = player.transform.position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            targetPos = npc1.transform.position;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            targetPos = npc2.transform.position;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            targetPos = npc3.transform.position;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            targetPos = player.transform.position;
        }

        transform.position = targetPos;

    }
}
