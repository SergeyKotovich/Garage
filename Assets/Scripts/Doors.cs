using DG.Tweening;
using UnityEngine;

public class Doors : MonoBehaviour
{
    [SerializeField] private Transform _firstDoor;
    [SerializeField] private Transform _secondDoor;
    private float _duration = 2f;
    private void Awake()
    {
        OpenDoors();
    }

    private void OpenDoors()
    {
        _firstDoor.DORotate(new Vector3(0,-90,0),_duration);
        _secondDoor.DORotate(new Vector3(0, 90, 0), _duration);
    }
}