var N = Convert.ToInt32(Console.ReadLine());
string output = string.Empty;

for(int i = 1; i <= N; i++){
    if(i % 2 == 0){
        output = output + i + " ";
    }
}
Console.WriteLine(output);
