﻿using Lab5Lib;
using System.Formats.Tar;
using System.Security.Cryptography;
using System.Text;

Console.WriteLine("Лабораторная работа # 5");
// ------ УСПЕШНО --------------------------------------------------

{
    IWriter writer = new StrWriter();
    IWriter rsa = new DecRSA(writer);
    IWriter hash = new DecSHA512(rsa);
    string? result = hash.Save("AAAAABBBBCCCCC");

    bool testresult = testSHA512_SA(result, Lab5Lib.Constant.Delimitr);
    Console.WriteLine(string.Format("тест {0} - {1} ", 1, testresult ? "успешно" : "НЕ успешно"));
}
{
    IWriter writer = new FileWriter(@"D:\test2.txt");
    IWriter rsa = new DecRSA(writer);
    IWriter hash = new DecSHA512(rsa);
    string? result = hash.Save("BBBBCCCCC");

    StreamReader reader = new StreamReader(result);
    string? message = reader.ReadLine();
    reader.Close();
    bool testresult = testSHA512_SA(message, Lab5Lib.Constant.Delimitr);
    Console.WriteLine(string.Format("тест {0} - {1} ", 2, testresult ? "успешно" : "НЕ успешно"));

}
{
    IWriter writer = new StrWriter();
    IWriter rsa = new DecRSA(writer);
    IWriter hash = new DecMD5(rsa);
    string? result = hash.Save("AAAAACCCCBBBBB");

    bool testresult = testMD5_SA(result, Lab5Lib.Constant.Delimitr);
    Console.WriteLine(string.Format("тест {0} - {1} ", 3, testresult ? "успешно" : "НЕ успешно"));
}
{
    IWriter writer = new FileWriter(@"D:\test4.txt");
    IWriter rsa = new DecRSA(writer);
    IWriter hash = new DecMD5(rsa);
    string? result = hash.Save("AAAAABBBBDDDDDCCCCC");

    StreamReader reader = new StreamReader(result);
    string? message = reader.ReadLine();
    bool testresult = testMD5_SA(message, Lab5Lib.Constant.Delimitr);
    Console.WriteLine(string.Format("тест {0} - {1} ", 4, testresult ? "успешно" : "НЕ успешно"));
}
{
    IWriter writer = new StrWriter();
    IWriter hash = new DecSHA512(writer);
    string? result = hash.Save("AAAAAEEEEEBBBBCCCCC");

    bool testresult = testSHA512(result, Lab5Lib.Constant.Delimitr);
    Console.WriteLine(string.Format("тест {0} - {1} ", 5, testresult ? "успешно" : "НЕ успешно"));
}
{
    IWriter writer = new StrWriter();
    IWriter hash = new DecMD5(writer);
    string? result = hash.Save("AAAAABBBBCCCCCHHHH");

    bool testresult = testMD5(result, Lab5Lib.Constant.Delimitr);
    Console.WriteLine(string.Format("тест {0} - {1} ", 6, testresult ? "успешно" : "НЕ успешно"));
}

{
    IWriter writer = new FileWriter();
    IWriter rsa = new DecRSA(writer);
    IWriter hash = new DecSHA512(rsa);
    string? result = hash.Save("AAAAABBBBDDDDDCCCCC");

    StreamReader reader = new StreamReader(result);
    string? message = reader.ReadLine();
    bool testresult = testSHA512_SA(message, Lab5Lib.Constant.Delimitr);
    Console.WriteLine(string.Format("тест {0} - {1} ", 7, testresult ? "успешно" : "НЕ успешно"));
}



// ------  НЕ УСПЕШНО --------------------------------------------------
{
    IWriter writer = new StrWriter();  //DecSHA512 для вычисления хэша, но зрезультат с помощью функции testMD5
    IWriter hash = new DecSHA512(writer);
    string? result = hash.Save("AAAAABBBBCCCCC");

    bool testresult = testMD5(result, Lab5Lib.Constant.Delimitr);
    Console.WriteLine(string.Format("тест {0} - {1} ", 8, testresult ? "успешно" : "НЕ успешно"));
}
{
    IWriter writer = new StrWriter();  
    IWriter hash = new DecSHA512(writer);
    string? result = hash.Save(string.Format("{0}{1}{2}", "AAAAA", Lab5Lib.Constant.Delimitr, "BBBBCCCCC"));  // разделитель в тексте

    bool testresult = testSHA512(result, Lab5Lib.Constant.Delimitr);
    Console.WriteLine(string.Format("тест {0} - {1} ", 9, testresult ? "успешно" : "НЕ успешно"));
}
{
    IWriter writer = new StrWriter(); //DecMD5 , функция testSHA512..
    IWriter hash = new DecMD5(writer);
    string? result = hash.Save(string.Format("{0}{1}{2}", "AAAAA", Lab5Lib.Constant.Delimitr, "BBBBCCCCC"));
    bool testresult = testSHA512(result, Lab5Lib.Constant.Delimitr);
    Console.WriteLine(string.Format("тест {0} - {1} ", 10, testresult ? "успешно" : "НЕ успешно"));
}
{
    IWriter writer = new StrWriter(); //DecMD5 , но результат с помощью функции testSHA512_SA
    IWriter rsa = new DecRSA(writer);
    IWriter hash = new DecMD5(rsa);
    string? result = hash.Save("HHHAAAAABBBBCCCCC");

    bool testresult = testSHA512_SA(result, Lab5Lib.Constant.Delimitr);
    Console.WriteLine(string.Format("тест {0} - {1} ", 11, testresult ? "успешно" : "НЕ успешно"));
}
{
    IWriter writer = new FileWriter(@"D:\test12.txt");
    IWriter rsa = new DecRSA(writer); //В проверочном вызове testSHA512_SA  передаем строку "BBBBXCCCC",
                                      //которая явно отличается от исходной строки "BBBBCCCCC".
    IWriter hash = new DecSHA512(rsa);
    string? result = hash.Save("BBBBCCCCC");


    StreamReader reader = new StreamReader(result);
    string? message = reader.ReadLine();
    bool testresult = testSHA512_SA("BBBBXCCCC", Lab5Lib.Constant.Delimitr);
    Console.WriteLine(string.Format("тест {0} - {1} ", 12, testresult ? "успешно" : "НЕ успешно"));
}
{
    IWriter writer = new FileWriter(@"D:\test13.txt");
    IWriter rsa = new DecRSA(writer); //DecMD5 для вычисления хэша, но  результат с помощью функции testSHA512_SA
    IWriter hash = new DecMD5(rsa);
    string? result = hash.Save("BBBBCCCCC");

    StreamReader reader = new StreamReader(result);
    string? message = reader.ReadLine();
    bool testresult = testSHA512_SA(message, Lab5Lib.Constant.Delimitr);

    Console.WriteLine(string.Format("тест {0} - {1} ", 13, testresult ? "успешно" : "НЕ успешно"));
}
        

        static bool testSHA512(string? message, char Delimitr = '\uffff')
{
    bool rc = false;
    try
    {
        message = message ?? string.Empty;
        int k1 = message.IndexOf(Delimitr);
        if (k1 == -1) throw new Exception("Delimitr not found");
        string xs = message.Substring(0, k1);
        string xsbhcs = message.Substring(k1 + 1);
        byte[] xsbhc = Convert.FromBase64String(xsbhcs);
        rc = eqSHA512(xs, xsbhc);
    }
    catch (Exception ex)
    {
        Console.WriteLine(string.Format("testSHA512: {0}", ex.Message));
    }
    return rc;
}
static bool testMD5(string? message, char Delimitr = '\uffff')
{
    bool rc = false;
    try
    {
        message = message ?? string.Empty;
        int k1 = message.IndexOf(Delimitr);
        if (k1 == -1) throw new Exception("Delimitr not found");
        string xs = message.Substring(0, k1);
        string xsbhcs = message.Substring(k1 + 1);
        byte[] xsbhc = Convert.FromBase64String(xsbhcs);
        rc = eqMD5(xs, xsbhc);
    }
    catch (Exception ex)
    {
        Console.WriteLine(string.Format("testMD5: {0}", ex.Message));
    }
    return rc;

}
static bool testSHA512_SA(string? message, char Delimitr = '\uffff')
{
    bool rc = false;
    try
    {
        message = message ?? string.Empty;
        int k1 = message.IndexOf(Delimitr);
        int k2 = message.IndexOf(Delimitr, k1 + 1);
        if (k1 == -1 || k2 == -1) throw new Exception("Delimitr not found");
        string xs = message.Substring(0, k1); //от 0 до k1
        string xsbhcs = message.Substring(k1 + 1, k2 - k1 - 1);
        string xparam = message.Substring(k2 + 1);
        byte[] xsbh = deRSA(xsbhcs, xparam);
        rc = eqSHA512(xs, xsbh);
    }
    catch (Exception ex)
    {
        Console.WriteLine(string.Format("testSHA512_SA: {0}", ex.Message));
    }
    return rc;
}

static bool testMD5_SA(string? message, char Delimitr = '\uffff')
{
    bool rc = false;
    try
    {
        message = message ?? string.Empty;
        int k1 = message.IndexOf(Delimitr);
        int k2 = message.IndexOf(Delimitr, k1 + 1); // Находим индекс второго вхождения разделителя Delimitr, начиная поиск с позиции k1 + 1.
        if (k1 == -1 || k2 == -1) throw new Exception("Delimitr not found");
        string xs = message.Substring(0, k1);
        string xsbhcs = message.Substring(k1 + 1, k2 - k1 - 1); // Извлекаем подстроку между первым и вторым разделителем.
        string xparam = message.Substring(k2 + 1);
        byte[] xsbh = deRSA(xsbhcs, xparam);
        rc = eqMD5(xs, xsbh);
    }
    catch (Exception ex)
    {
        Console.WriteLine(string.Format("testMD5_SA: {0}", ex.Message));
    }
    return rc;
}



static byte[] deRSA(string sbhcs, string xmlparam)
{
    byte[] rc = { };
    try
    {
        byte[] xsbhc = Convert.FromBase64String(sbhcs);
        using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
        {
            rsa.FromXmlString(xmlparam);
            rc = rsa.Decrypt(xsbhc, RSAEncryptionPadding.Pkcs1);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(string.Format("deRSA: {0}", ex.Message));
    }
    return rc;
}
static bool eqMD5(string s, byte[] hash)
{
    bool rc = true;
    s = s ?? string.Empty;
    byte[] sb = Encoding.ASCII.GetBytes(s);
    MD5 md5 = MD5.Create();
    byte[] sbh = md5.ComputeHash(sb);
    rc = sbh.SequenceEqual(hash);  //Метод проверяет, содержат ли обе последовательности одинаковые элементы в том же порядке
    return rc;
}

static bool eqSHA512(string s, byte[] hash)
{
    bool rc = true;
    s = s ?? string.Empty;
    byte[] sb = Encoding.ASCII.GetBytes(s);
    SHA512 sha512 = SHA512.Create();
    byte[] sbh = sha512.ComputeHash(sb);
    rc = sbh.SequenceEqual(hash); //Метод проверяет, содержат ли обе последовательности одинаковые элементы в том же порядке
    return rc;
}




//public class HttpFormatter : IWriter
//{
//    private readonly IWriter _writer;

//    public HttpFormatter(IWriter writer)
//    {
//        _writer = writer;
//    }

//    public string? Save(string message)
//    {
//        // Формируем HTTP/1.1 сообщение
//        string httpMessage = $"POST / HTTP/1.1\r\n" +
//                             $"Host: localhost\r\n" +
//                             $"Content-Length: {message.Length}\r\n" +
//                             $"\r\n" +
//                             $"{message}";

//        // Передаем форматированное сообщение следующему декоратору
//        return _writer.Save(httpMessage);
//    }
//}