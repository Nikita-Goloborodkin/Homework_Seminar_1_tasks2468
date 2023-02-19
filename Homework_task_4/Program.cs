int num_1 = Convert.ToInt32(Console.ReadLine());
int num_2 = Convert.ToInt32(Console.ReadLine());
int num_3 = Convert.ToInt32(Console.ReadLine());
if (num_1>num_2 && num_1>num_3)
{
    Console.WriteLine("Max = "+num_1);
}
else{
    if (num_1<num_2 && num_2>num_3){
        Console.WriteLine("Max = " + num_2);
    }
    else{
        Console.WriteLine("Max = " + num_3);
    }
}