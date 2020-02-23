using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionSortScript : MonoBehaviour
{
    void SelectionSort(int[] listaSinOrdenar)
    {
        int min;
        int temp;
        
        for (int i = 0; i < listaSinOrdenar.Length; i++)
        {
            min = i;
            
            for(int j = i+1; j < listaSinOrdenar.Length; j++)
            {
                if(listaSinOrdenar[j] < listaSinOrdenar[min])
                {
                    min = j;
                }
            }
            
            if(min != i)
            {
                temp = listaSinOrdenar[i];
                listaSinOrdenar[i] = listaSinOrdenar[min];
                listaSinOrdenar[min] = temp;
                ImprimirLista(listaSinOrdenar);
            }
        }
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
        
        int[] lista = generarLista(100);
        ImprimirLista(lista);
        SelectionSort(lista);
        
        watch.Stop();
        
        print($"Execution Time: {watch.ElapsedMilliseconds} ms");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
