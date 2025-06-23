using System;

public class MonthDaysCalculator
{
    // Enum untuk merepresentasikan bulan-bulan
    public enum Month
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    public static void Main(string[] args)
    {
        int[] daysInMonthNonLeapYear = new int[]
        {
            0,   // Placeholder untuk indeks 0
            31,  // Januari
            28,  // Februari (tahun non-kabisat)
            31,  // Maret
            30,  // April
            31,  // Mei
            30,  // Juni
            31,  // Juli
            31,  // Agustus
            30,  // September
            31,  // Oktober
            30,  // November
            31   // Desember
        };

        Console.WriteLine("--- Penghitung Jumlah Hari dalam Bulan (Tahun Non-Kabisat) ---");

        // Contoh penggunaan:
        Console.WriteLine($"Jumlah hari di Januari: {GetDaysInMonth(Month.January, daysInMonthNonLeapYear)}");
        Console.WriteLine($"Jumlah hari di Februari: {GetDaysInMonth(Month.February, daysInMonthNonLeapYear)}");
        Console.WriteLine($"Jumlah hari di April: {GetDaysInMonth(Month.April, daysInMonthNonLeapYear)}");

        Console.WriteLine("\nMasukkan angka bulan (1-12) untuk mencari jumlah hari:");
        if (int.TryParse(Console.ReadLine(), out int monthNumber))
        {
            if (Enum.IsDefined(typeof(Month), monthNumber))
            {
                Month selectedMonth = (Month)monthNumber;
                int days = GetDaysInMonth(selectedMonth, daysInMonthNonLeapYear);
                Console.WriteLine($"Jumlah hari di {selectedMonth} adalah: {days}");
            }
            else
            {
                Console.WriteLine("Angka bulan tidak valid. Harap masukkan antara 1 dan 12.");
            }
        }
        else
        {
            Console.WriteLine("Input tidak valid. Harap masukkan angka.");
        }
    }
    public static int GetDaysInMonth(Month month, int[] daysTable)
    {
        // Menggunakan nilai enum sebagai indeks untuk mengakses tabel
        return daysTable[(int)month];
    }
}