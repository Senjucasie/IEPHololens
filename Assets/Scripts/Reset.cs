using System.Collections;
using UnityEngine;
public class Reset : ApplicationState
{
    private readonly float _delay; 

    public Reset(ApplicationManager _manager,float delay):base(_manager)
    {
        _delay = delay;
    }
    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update( )
    {
        _applicationManager.Car.transform.localScale = _applicationManager.DefaultScale;
        _applicationManager.AudiRadial.enabled = true;
        _applicationManager.StartCoroutine(Delay(_delay));
    }
    
    private IEnumerator Delay(float delay)
    {
        yield return new WaitForSeconds(delay);
        _applicationManager.AudiRadial.enabled = false;
        _applicationManager.Menu.transform.position = _applicationManager.Menutransform.position;
        _applicationManager.Menu.transform.rotation = _applicationManager.Menutransform.rotation;
    }
}
