namespace month_name;
public class MonthNameInCalendar
{
  
  

    public static string MonthName(int month)
    {
        if(month == 1) return "janeiro";
        if(month == 2) return "fevereiro";
        if(month == 3) return "março";
        if(month == 4) return "abril";
        if(month == 5) return "maio";
        if(month == 6) return "junho";
        if(month == 7) return "julho";
        if(month == 8) return "agosto";
        if(month == 9) return "setembro";
        if(month == 10) return "outubro";
        if(month == 11) return "novembro";
        if(month == 12) return "dezembro";
        return "inválido";
    }
}