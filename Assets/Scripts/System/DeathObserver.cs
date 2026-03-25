using System;
using System.Diagnostics;
using Zenject;

public sealed class DeathObserver : IInitializable, IDisposable
{
    private readonly ICharacter character;
    private readonly GameManager gameManager;

    public DeathObserver(ICharacter character, GameManager gameManager)
    {
        this.character = character;
        this.gameManager = gameManager;
    }

    void IInitializable.Initialize()
    {
        this.character.OnDeath += this.OnDeath;
    }

    void IDisposable.Dispose()
    {
        this.character.OnDeath -= this.OnDeath;
    }

    public void OnDeath()
    {
        this.gameManager.FinishGame();
    }

}
