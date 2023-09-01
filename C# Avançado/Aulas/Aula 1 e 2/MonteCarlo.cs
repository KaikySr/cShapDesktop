

// int N = 1000; // Tamanho da amostras
// int M = 5000; // Amostras a serem utilizadas
// int K = 50;
// // Vezes que o Monte Carlo será executado
// var seed = DateTime.Now.Millisecond;
// var rand = new Random(seed); // Objeto para gerar números aleatórios

// float sum = 0f;
// float sqSum = 0f;
// float[] dist = new float[M];

// float aval = 0;
// double time = 0;
// for (int i = 0; i < K; i++)
// {
//     for (int j = 0; j < dist.Length; j++)
//         dist[j] = 0;
//     sum = 0f;
//     sqSum = 0f;

//     var dt = DateTime.Now;

//     run(); // Código entra aqui

//     var span = DateTime.Now - dt;
//     time += span.TotalMilliseconds;
//     aval += avaliate();
// }

// Console.WriteLine($"{100 * aval / K}% of precision in {time / K} ms per computation.");

// void compute(int index)
// {
//     var value = 0f;
//     for (int i = 0; i < N; i++)
//         value += rand.NextSingle(); // Geramos muitos valores aleatórios e somamos para tirar a média
//     value /= N;
//     dist[index] = value;
//     sum += value;
//     sqSum += value * value;
// }

// float avaliate()
// {
//     float avg = sum / M;
//     float std = sqSum - sum * sum / M;
//     std /= M;
//     std = MathF.Sqrt(std);
//     int count1 = 0;
//     int count2 = 0;
//     int count3 = 0;
//     foreach (var y in dist)
//     {
//         if (y > avg + 2 * std)
//         {
//             count1++;
//             count2++;
//             count3++;
//         }
//         else if (y > avg + std)
//         {
//             count1++;
//             count2++;
//         }
//         else if (y > avg)
//         {
//             count1++;
//         }
//     }
//     var exp1 = M * 0.5f;
//     var exp2 = M * 0.159f;
//     var exp3 = M * 0.022f;
//     var err1 = MathF.Abs(count1 - exp1) / exp1;
//     var err2 = MathF.Abs(count2 - exp2) / exp2;
//     var err3 = MathF.Abs(count3 - exp3) / exp3;
//     var prec = 1f - (err1 + err2 + err3) / 3;
//     return prec < 0 ? 0 : prec;
// }
// void run()
// {
//     for (int i = 0; i < M; i++)
//         compute(i);
// }

// void threadWrongRun()
// {
//     for (int i = 0; i < M; i++)
//     {
//         Thread thread = new Thread(() =>
//         {
//             compute(i);
//         });
//         thread.Start();
//     }
// }

// void threadRun()
// {
//     for (int i = 0; i < M; i++)
//     {
//         int j = i;
//         Thread thread = new Thread(() =>
//         {
//             compute(j);
//         });
//         thread.Start();
//     }
// }

// void wrongParallelForRun()
// {
//     Parallel.For(0, M, i =>
//     {
//         compute(i);
//     });
// }