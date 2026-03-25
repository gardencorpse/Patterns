using UnityEngine;
using Zenject;

public sealed class MoveController : ITickable
{
    private readonly IMoveInput _moveInput;
    private readonly ICharacter _character;

    public MoveController(IMoveInput moveInput, ICharacter character)
    {
        this._moveInput = moveInput;
        this._character = character;
    }

    void ITickable.Tick()
    {
        _character.Move(this._moveInput.GetDirection(), Time.deltaTime);
    }
}
