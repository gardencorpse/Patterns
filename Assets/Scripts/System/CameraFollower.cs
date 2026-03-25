using UnityEngine;
using Zenject;

public class CameraFollower : MonoBehaviour
{
    [Inject]
    private Camera _targetCamera;
    [Inject]
    private ICharacter character;

    [SerializeField]
    private Vector3 _offset;

    private void LateUpdate()
    {
        var cameraPosition = this.character.GetPosition() + this._offset;
        this._targetCamera.transform.position = cameraPosition;
    }
}
