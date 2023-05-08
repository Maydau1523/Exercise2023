public class MyGenericClass <T>
{

  private T genericNemberValue;

  public MyGenericClass( T genericNemberValue)
  {
      this.genericNemberValue = genericNemberValue;
  }
  public T genericMethod ( T genericPaarametrer)
  {
      Console.WriteLine("Parameter type {0}, value : {1}",typeof(T).ToString(),genericParameter)
      Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(), genericMemberVariable);
      return genericMemberVariable; 
  } 
 public T genericProperty { get; set; } 

} 


