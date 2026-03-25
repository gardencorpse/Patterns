using UnityEngine;
using Zenject;

public class SceneInstaller : MonoInstaller
{
    [SerializeField]
    private Character character;

    [SerializeField]
    private MoveInput moveInput;

    [SerializeField]
    private new Camera camera;

    public override void InstallBindings()
    {
        this.Container
            .Bind<ICharacter>()
            .To<Character>()
            .FromInstance(this.character)
            .AsSingle();

        this.Container
            .Bind<IMoveInput>()
            .To<MoveInput>()
            .AsSingle();

        this .Container.Bind<Camera>().FromInstance(this.camera).AsSingle();
    }
}
