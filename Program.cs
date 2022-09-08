//Task64
Console.Write("Task 64. This program will deduce all natural numbers between the two numbers, which you will be asked to enter.");
Console.WriteLine("Please, enter the first number:");
int int_M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please, enter the second number:");
int int_N = Convert.ToInt32(Console.ReadLine());

string Numerical_calc (int M, int N){
       if (M < N)
    {
        return $"{M} " + Numerical_calc(M+1, N);
    }
    else
    {
        return $"{N} ";
    };
};
    
if (int_M != int_N) {
    if (int_N < int_M) {
        int temporal = int_M;
        int_M = int_N;
        int_N = temporal;
        Console.WriteLine("Second number was lower than the first number, reversing");
    };
     Console.WriteLine("First number is {0}, second number is {1}, intermediaries are: {2}", int_M, int_N, Numerical_calc(int_M, int_N));}
else {
    Console.WriteLine("Starting and ending are the same, can not compute.");
};
Console.WriteLine();
Console.WriteLine();

//Task66
Console.WriteLine("Task 66. This program will provide a sum of all natural numbers between the two numbers, which you will be asked to enter.");

Console.WriteLine("Please, enter the first number:");
int sum_A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please, enter the second number:");
int sum_B = Convert.ToInt32(Console.ReadLine());

int Numberical_sum (int M, int N) {
       if (M <= N)
    {
        return M + Numberical_sum(M+1, N);
    }
    else
    {
        return 0;
    };
};
if (sum_A != sum_B) {
    if (sum_B < sum_A) {
        int temporal2 = sum_A;
        sum_A = sum_B;
        sum_B = temporal2;
        Console.WriteLine("Second number was lower than the first number, reversing");
    };
     Console.WriteLine("First number is {0}, second number is {1}, sum of them is: {2}", sum_A, sum_B, Numberical_sum(sum_A, sum_B));}
else {
    Console.WriteLine("Starting and ending are the same, can not compute.");
};
Console.WriteLine();
Console.WriteLine();
//Task68
//Но, сразу пояснение - работает она с небольшими числами, как только выходим за пределы разумного - начинается stackoverflow. 
//Посмотрел алгоритмы решения на SO, пришел в ужас. Буду на досуге колупать, уж больно интересно. 
//Но, насколько понимаю, такой формат является решением задачи?

Console.WriteLine("Task 66. This program will provide the resolution of an Aackermann function, based on two numbers, which you will be asked to enter.");
Console.WriteLine("Please, enter the first number:");
int Ack_A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please, enter the second number:");
int Ack_B = Convert.ToInt32(Console.ReadLine());

Int32 Ackermann (int A, int B){
  if (A == 0)
  {
    return B+1;
  } else if (A>0 && B==0) {
    return Ackermann(A-1,1);
  } else if (A>0 && B>0) {
    return Ackermann(A-1, Ackermann(A,B-1));
  };
  return 0;
};

 if (Ack_A > 0 && Ack_B > 0)
    {
        Console.WriteLine("Result of the Ackermann function given inputs {0} and {1} is: {2}", Ack_A, Ack_B, Ackermann(Ack_A,Ack_B));
    }else{
        Console.WriteLine("Incorrect inputs - the numbers must not be negative.");
    };