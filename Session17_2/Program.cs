// See https://aka.ms/new-console-template for more information


Queue<string> queue = new Queue<string>();
queue.Enqueue("Laura");
queue.Enqueue("Esteban");
queue.Enqueue("Cintia");
queue.Enqueue("Vlad");

while(  queue.TryDequeue(out string item))
{
   if (item!= null)
        Console.WriteLine(item);
}


Queue<People> ColaTortillas = new Queue<People>();
 
ColaTortillas.Enqueue(new People(){ Name="Esteban", Kg= 10, IsUsingPaper = true });

ColaTortillas.Enqueue(new People(){ Name="Xiomara", Kg= 3, IsUsingPaper = true });

ColaTortillas.Enqueue(new People(){ Name="Cesar", Kg= 6, IsUsingPaper = true });


while(ColaTortillas.TryDequeue(out People item))
{
    Console.WriteLine($"Se despacho a {item.Name} con {item.kg} y debe {item.Total} ");
}