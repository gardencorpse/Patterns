using UnityEngine;
using Zenject;

public class MoveController : MonoBehaviour
{
    private IMoveInput _moveInput;
    private ICharacter _character;

    [Inject]
    public void Construct(ICharacter character, IMoveInput moveInput)
    {
        this._character = character;
        this._moveInput = moveInput;
    }

    private void Update()
    {
        _character.Move(this._moveInput.GetDirection(), Time.deltaTime);
    }
}
