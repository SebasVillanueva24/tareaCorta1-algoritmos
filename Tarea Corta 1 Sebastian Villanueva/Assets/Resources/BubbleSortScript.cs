using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSortScript : MonoBehaviour
{
    void BubbleSort(int[] listaSinOrdenar)
    {
        int[] arr = { 78, 55, 45, 98, 13 };
        int temp;
        for (int j = 0; j <= listaSinOrdenar.Length - 2; j++) {
            for (int i = 0; i <= listaSinOrdenar.Length - 2; i++) {
                if (listaSinOrdenar[i] > listaSinOrdenar[i + 1]) {
                    temp= listaSinOrdenar[i + 1];
                    listaSinOrdenar[i + 1] = listaSinOrdenar[i];
                    listaSinOrdenar[i] = temp;
                    ImprimirLista(listaSinOrdenar);
                }
            }
        }

        string resultado = "";
        for (int i = 0; i < listaSinOrdenar.Length; i++)
        {
            resultado = resultado + listaSinOrdenar[i] + ", ";
        }
        
        print(resultado);
    }
    
    void ImprimirLista(int[] algunaLista)
    {
        string resultado = "";
        for (int i = 0; i < algunaLista.Length; i++)
        {
            resultado = resultado + algunaLista[i] + ", ";
        }
        
        print(resultado);
    }

    int[] generarLista(int tamanno)
    {
        Random r = new Random();
        int[] arr = new int[tamanno];

        for (int i = 0; i < tamanno; i++)
        {
            arr[i] = Random.Range(1,tamanno+1);
        }

        return arr;

    }
    
    // Start is called before the first frame update
    void Start()
    {
        var watch = System.Diagnostics.Stopwatch.StartNew();
        
        int[] lista = generarLista(90);
        ImprimirLista(lista);
        BubbleSort(lista);
        
        watch.Stop();
        
        print($"Execution Time: {watch.ElapsedMilliseconds} ms");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
