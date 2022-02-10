

public abstract class ApplicationState 
 {

    protected readonly ApplicationManager _applicationManager;

    public ApplicationState(ApplicationManager applicationmanager)
     {
        _applicationManager = applicationmanager;
     }

    public virtual void Enter() { }

    public virtual void Update() { }

    public virtual void Exit() { }
 }
