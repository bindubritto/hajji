using Microsoft.AspNetCore.Mvc;

namespace hello_world.Controllers;

[ApiController]
public class MessageController : ControllerBase
{
    public readonly ServiceFactory _sf;

    public MessageController(ServiceFactory sf)
    {
        _sf = sf;
    }

    [HttpGet]
    [Route("hello-world")]
    public List<result> Get()
    {
        List<result> obj= new List<result>();
        for(int i = 1; i<=100; i++){
            var service = _sf.getService(ServiceType.HELLO);
            var message = service?.getMessage(i);
            if(message != ""){
                obj.Add(new result(i,message));
            }
        }
        return obj;
    }

    [HttpGet]
    [Route("hello-universe")]
    public List<result> getUniverse()
    {
        List<result> obj = new List<result>();
        for(int i = 1; i<=100; i++){
            var service = _sf.getService(ServiceType.UNIVERSE);
            var message = service?.getMessage(i);
            if(message != ""){
                obj.Add(new result(i,message));
            }
        }
        return obj;
    }
}

public class result{
    public result(int _id, string _message){
        Id = _id;
        message = _message;
    }
    public int Id{get;set;}
    public string message{get;set;}
}