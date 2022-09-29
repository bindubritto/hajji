public class HelloUniverseService: IMessageService
{

  public string getMessage(int a){
    if(a % 3 == 0 && a % 5 == 0){
      return "Hello Universe";
    }
    else if(a % 3 == 0){
      return "Hello";
    }
    else if(a % 5 == 0){
      return "Universe";
    }
    else return "";
  }

}