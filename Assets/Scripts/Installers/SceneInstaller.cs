using UnityEngine;
using Zenject;

public class SceneInstaller : MonoInstaller
{
    [SerializeField]
    private Vector3 cameraOffset = new Vector3(0, 3, -12);

    [SerializeField]
    private Character characterPrefab;

    [SerializeField]
    private MoveInput moveInput;

    [SerializeField]
    private new Camera camera;

    public override void InstallBindings()
    {
        this.Container
            .Bind<ICharacter>()
            .To<Character>()
            .FromComponentInNewPrefab(this.characterPrefab)
            .AsSingle();

        this.Container
            .Bind<IMoveInput>()
            .To<MoveInput>()
            .AsSingle();

        this.Container
            .Bind<Camera>()
            .FromInstance(this.camera)
            .AsSingle();

        this.Container
            .Bind<GameManager>()
            .AsSingle();

        this.Container
            .BindInterfacesTo<DeathObserver>()
            .AsCached();

        this.Container
            .BindInterfacesAndSelfTo<MoveController>()
            .AsCached();

        this.Container
            .BindInterfacesTo<CameraFollower>()
            .AsCached()
            .WithArguments(this.cameraOffset);
    }
}
