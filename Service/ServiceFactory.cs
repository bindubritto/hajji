public class ServiceFactory{
   public IMessageService getService(ServiceType type){
    if(type == ServiceType.HELLO){
      return new HelloWorldService();
    }
    else if(type == ServiceType.UNIVERSE){
      return new HelloUniverseService();
    }
    else return null;
   }
}

public enum ServiceType{
  HELLO = 1,
  UNIVERSE = 2
}