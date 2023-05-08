MyGenericClass<String> strGenericClass = new MyGenericClass<string>("hola");;;
strGenericClass.genericProperty - "this is a generic property";

var result - strGenericClass.genericMetho("some value");

Console.WriteLine(result);




MyGenericClass<int> intGenericClass = new MyGenericClass<int>(100);

intGenericClass.genericProperty = 200;

var result2 = intGenericClass.genericMethod(300);

Console.WriteLine(result2);



List<int> listado = new List<int>();

listado.Add(100);
listado.Short();


List<string> listadostr= new List<string>();
listadostr.Add("otro valor");
listadostr.Short();



