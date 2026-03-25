using UnityEngine;
using Zenject;

public class CameraFollower : ILateTickable
{
    private readonly Camera _targetCamera;
    private readonly ICharacter character;
    private readonly Vector3 _offset;

    public CameraFollower(Camera camera, ICharacter character, Vector3 offset)
    {
        this.character = character;
        this._targetCamera = camera;
        this._offset = offset;
    }

    void ILateTickable.LateTick()
    {
        var cameraPosition = this.character.GetPosition() + this._offset;
        this._targetCamera.transform.position = cameraPosition;
    }
}
