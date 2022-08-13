internal class Program
{
    private static void Main(string[] args)
    {

        try
        {
                    
        Console.WriteLine("Bir sayı giriniz: ");
        int sayi = Int32.Parse(Console.ReadLine());
        }
        catch (Exception ex)
        {           
            Console.WriteLine("Hata: " +ex);
        }

        finally
        {
            Console.WriteLine("Islem Tamamlandi.");
        }


        try
        {
            //int a = Int32.Parse(null);
            //int a = Int32.Parse("okankanka");
            int a = Int32.Parse("12000000000");
        }
        catch (ArgumentNullException ex)
        {
            
            Console.WriteLine("Bos deger girildi.");
            Console.WriteLine("Hata: "+ex);
        }

        catch (FormatException ex)
        {
            
            Console.WriteLine("Lutfen bir sayi giriniz!");
            Console.WriteLine("Hata: "+ex);
        }

        catch (OverflowException ex)
        {
            
            Console.WriteLine("Yuksek bir deger girdiniz");
            Console.WriteLine("Hata: "+ex);
        }

        finally
        {

            Console.WriteLine("Islem Tamamlandı.");
        }
    }
}