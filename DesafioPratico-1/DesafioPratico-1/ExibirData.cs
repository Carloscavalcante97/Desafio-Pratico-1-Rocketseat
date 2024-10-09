
using Microsoft.VisualBasic;

namespace DesafioPratico_1;

public  class ExibirData
{
    public static string ExibirDataAtual()
    {
        DateTime data = DateTime.Now;
        string dataCompleta = data.ToString("dddd, dd, 'de' MMMM 'de' yyyy HH:mm:ss");
        string dataFormato = data.ToString("dd/mm/yyyy");
        string horaFormato = data.ToString("HH:mm");
        string dataMesExtenso = data.ToString("dd/MMMM/yyyy");
        return     $"Data Completa: {dataCompleta}\n"+
                   $"Apenas data: {dataFormato}\n" +
                   $"Apenas hora: {horaFormato}\n" +
                   $"Data com mês por extenso: {dataMesExtenso}";
    }
}
