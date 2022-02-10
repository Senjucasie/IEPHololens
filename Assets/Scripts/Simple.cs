
public class Simple : ApplicationState
{

    public Simple(ApplicationManager applicationmanager):base(applicationmanager)
    {
     
    }


    public override void Enter()
    {
        base.Enter();
    }

    public override void Update()
    {
        _applicationManager.Menu.SetActive(false);
        _applicationManager.AudiBounds.enabled = false;
        _applicationManager.AudiCollider.enabled = false;
        _applicationManager.AudiManipulator.enabled = false;
    }

    public override void Exit()
    {
        base.Exit();
    }

   
}
