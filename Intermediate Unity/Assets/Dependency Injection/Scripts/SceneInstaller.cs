using Zenject;

public class SceneInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<InputControllerDI>().FromComponentInHierarchy().AsSingle();
        Container.Bind<UIControllerDI>().FromComponentInHierarchy().AsSingle();
        Container.Bind<AudioManagerDI>().FromComponentInHierarchy().AsSingle();
        Container.Bind<NotOnSceneScript>().AsSingle();
    }
}
