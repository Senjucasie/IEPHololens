

public class Expert : ApplicationState
{
    public Expert(ApplicationManager applicationmanager):base(applicationmanager)
    {
        
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Update()
    {
        _applicationManager.Menu.SetActive(true);
        _applicationManager.Option1.SetActive(false);
        _applicationManager.Option2.SetActive(false);
        _applicationManager.Keyboard.SetActive(false);
        _applicationManager.DecisionPoints.SetActive(false);
        _applicationManager.AudiBounds.enabled = true;
        _applicationManager.AudiCollider.enabled = true;
        _applicationManager.AudiManipulator.enabled = true;
    }

    public override void Exit()
    {
        base.Exit();
    }

    
}
