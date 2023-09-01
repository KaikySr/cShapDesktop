using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Concurrent; 
using System.Collections.Generic; 

//random
Random rand = new Random();

//numero de soldados pra cada lado e quantidade de batalhas
int atacantes = 1000;
int defensores = 500;
int batalhas = 10_000;

//runção para rodar o dado
int roll() => rand.Next(6) + 1;

//lista de soldados
List<int> DadosAtacantes = new List<int>();
List<int> DadosDefensores = new List<int>();

//fila de soldados
Queue<int> QueueAtacantes = new Queue<int>();
Queue<int> QueueDefensores = new Queue<int>();

//Contabilizar vitorias
int VitoriasAtacantes = 0;
int VitoriasDefensores = 0;

//////////// RUN /////////////////
// variavel para contar o tempo
double time = 0;
var dt = DateTime.Now;

Batalha();
Console.WriteLine(VitoriasAtacantes);
Console.WriteLine(VitoriasDefensores);

var span = DateTime.Now - dt;
time += span.TotalMilliseconds;
//////////// RUN /////////////////

void GerarDados()
{
    for (int i = 0; i < atacantes; i++)
    {
        int DadoAtual = roll();
        DadosAtacantes.Add(DadoAtual);
    }

    for (int i = 0; i < defensores; i++)
    {
        int DadoAtual = roll();
        DadosDefensores.Add(DadoAtual);
    }
}

void AdicionarNaFila()
{
    foreach(int n in DadosAtacantes)
        QueueAtacantes.Enqueue(n);

    foreach(int n in DadosDefensores)
        QueueDefensores.Enqueue(n);
}

void VerificarVitoria(List<int> list1, List<int> list2, int index)
{
    if (list1[index] > list2[index])
    {
        VitoriasAtacantes++;
        defensores--;

        QueueAtacantes.Enqueue(list1[index]);
    } 
    else
    { 
        VitoriasDefensores++;
        atacantes--; 

        QueueDefensores.Enqueue(list2[index]);
    }
}

void Batalha()
{
    bool loop = true;
    while (loop)
    {
        GerarDados();
        AdicionarNaFila();

        List<int> sortAtc = new List<int>();
        List<int> sortDef = new List<int>();

        for (int i = 0; i < 3; i++)
        {
            sortAtc.Add(QueueAtacantes.Dequeue());
            sortDef.Add(QueueDefensores.Dequeue());
        }

        sortAtc.Sort();
        sortDef.Sort();
        if (atacantes > 1 && defensores > 0)
        {
            if (sortAtc.Count >= 3 && sortDef.Count >= 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    VerificarVitoria(sortAtc, sortDef, i);
                }
            }
            else
            {
                if (sortAtc.Count > sortDef.Count)
                {
                    for (int i = 0; i < sortAtc.Count; i++)
                    {
                        VerificarVitoria(sortAtc, sortDef, i);
                    }
                }
                else
                {
                    for (int i = 0; i < sortDef.Count; i++)
                    {
                        VerificarVitoria(sortAtc, sortDef, i);
                    }
                }
            }
        }
        else
        {
            // Console.WriteLine("Fim");
            loop = false;
        }
    }
}
